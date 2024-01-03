
/********************************************************************************************************************
 Add the specified number of PersonAlias records for each qualified Person record that already exists in the
 target database.

    1. The new PersonAlias records will be added non-sequentially per Person to simulate the fragmented organization
       of this table in real-world scenarios.
    2. The last PersonAlias record added for a given Person will become the primary PersonAlias for that Person.
        2a. This process will set all other [PersonAlias].[AliasPersonId] & [PersonAlias].[AliasPersonGuid] values
            for this Person to NULL, to ensure we exercise portions of the code intended to be tested by adding
            all of these excessive PersonAlias records.

NOTE: This might take a while to run. Check the [Messages] tab for progress.

*********************************************************************************************************************/

DECLARE @EveryNPeopleQualifier [int] = 100; -- Every 10 people will get new PersonAlias records.
-- OR --
DECLARE @SpecificPersonId [int] = 0; -- A specific Person can be targeted.

-- THIS ALWAYS APPLIES:
DECLARE @NewAliasPerPersonCount [int] = 100; -- Each Person will get 100 new PersonAlias records.

/***************************
 DON'T EDIT ANYTHING BELOW.
****************************/

---------------------------------------------------------------------------------------------------

SET NOCOUNT ON;

DECLARE @PersonIds TABLE
(
    [Id] [int] IDENTITY(1,1) NOT NULL
    , [PersonId] [int] NOT NULL
    , [PersonGuid] [uniqueidentifier] NOT NULL
);

IF @SpecificPersonId > 0
BEGIN
    INSERT INTO @PersonIds
        SELECT [Id], [Guid]
        FROM [Person]
        WHERE [Id] = @SpecificPersonId;
END
ELSE
BEGIN
    INSERT INTO @PersonIds
        SELECT [Id], [Guid] FROM [Person]
        WHERE ([Id] % @EveryNPeopleQualifier = 0);
END

DECLARE @iPerson [int]
    , @iPersonMax [int]
    , @PersonId [int]
    , @PersonGuid [uniqueidentifier]
    , @NewPersonAliasId [int];

DECLARE @iPersonAlias [int] = 1;

DECLARE @PeopleCount [int] = (SELECT COUNT(*) FROM @PersonIds);
DECLARE @AliasesToCreateCount [int] = @PeopleCount * @NewAliasPerPersonCount;
DECLARE @AliasesCreatedCount [int] = 0;
DECLARE @ProgressMessage [nvarchar](100);

WHILE @iPersonAlias <= @NewAliasPerPersonCount
BEGIN
    SET @iPerson = (SELECT MIN([Id]) FROM @PersonIds);
    SET @iPersonMax = (SELECT MAX([Id]) FROM @PersonIds);

    WHILE @iPerson <= @iPersonMax
    BEGIN
        SELECT @PersonId = [PersonId]
            , @PersonGuid = [PersonGuid]
        FROM @PersonIds
        WHERE [Id] = @iPerson;

        INSERT INTO [PersonAlias]
        (
            [PersonId]
            , [Guid]
        )
        VALUES
        (
            @PersonId
            , NEWID()
        );

        -- If this is the last PersonAlias created for this Person, it
        -- should become the primary PersonAlias for the Person.
        IF @iPersonAlias = @NewAliasPerPersonCount
        BEGIN
            SET @NewPersonAliasId = (SELECT @@IDENTITY);

            -- Make all PersonAlias records for this Person non-primary.
            UPDATE [PersonAlias]
            SET [AliasPersonId] = NULL  
                , [AliasPersonGuid] = NULL
            WHERE [PersonId] = @PersonId;

            -- Set this latest PersonAlias record to be primary.
            UPDATE [PersonAlias]
            SET [AliasPersonId] = @PersonId
                , [AliasPersonGuid] = @PersonGuid
            WHERE [Id] = @NewPersonAliasId;

            -- Tie this new PersonAlias record back to the Person.
            UPDATE [Person]
            SET [PrimaryAliasId] = @NewPersonAliasId
            WHERE [Id] = @PersonId;
        END

        -- Report progress every 100 records
        SET @AliasesCreatedCount = @AliasesCreatedCount + 1;
        IF @AliasesCreatedCount % 100 = 0
        BEGIN
            SET @ProgressMessage = CONCAT('Created ', @AliasesCreatedCount, ' of ', @AliasesToCreateCount, ' PersonAliases.');
            RAISERROR(@ProgressMessage, 0, 1) WITH NOWAIT;
        END

        SET @iPerson = @iPerson + 1;
    END

    SET @iPersonAlias = @iPersonAlias + 1;
END

SET NOCOUNT OFF;
