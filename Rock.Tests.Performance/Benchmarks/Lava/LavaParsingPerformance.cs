using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using Rock.Lava;
using Rock.Lava.Fluid;

namespace Rock.Tests.Performance.Benchmarks.Security
{
    /// <summary>
    /// Performs some basic performance tests on the...
    /// class. TL;DR; It's fast.
    /// </summary>
    [MemoryDiagnoser( false )]
    [Attributes.OperationsPerSecondColumn]
    [GroupBenchmarksBy( BenchmarkLogicalGroupRule.ByCategory )]
    [CategoriesColumn]
    public class LavaParsingPerformance
    {
        private FluidEngine fluidEngine = new FluidEngine();

        #region Test Data

        private readonly string _template = @"
{% liquid

    assign NickName = 'Ted'
    assign lastName = 'Decker'

    if lastName == ''
        assign result = 'nope'
    else
        if NickName == 'Cindy'
            assign result = 'female'
        elseif NickName == 'Ted'
            assign result = 'male'
        else
            assign result = 'unknown'
        endif
    endif

    echo result
%}
";
        private readonly string _expectedOutput = "male";

        #endregion


        [GlobalSetup]
        public void Setup()
        {
            var engineOptions = new LavaEngineConfigurationOptions
            {
                DefaultEnabledCommands = new List<string>()
            };

            fluidEngine.Initialize( engineOptions );
            fluidEngine.RegisterFilters( typeof( Rock.Lava.Filters.TemplateFilters ) );

            // Verify that it's working as expected.
            var output = fluidEngine.ParseTemplate( _template );
            if ( output.HasErrors != false )
            {
                throw new System.Exception( "Lava engine setup failed: the template has errors." );
            }

            var renderResult = fluidEngine.RenderTemplate( output.Template, new LavaRenderParameters() );
            if ( output == null || renderResult.Text.Trim() != _expectedOutput )
            {
                throw new System.Exception( "Lava engine setup failed: unexpected output." );
            }
        }

        [Benchmark]
        [BenchmarkCategory( "Lava" )]
        public LavaParseResult ParseLavaIfElseIfTemplate()
        {
            return fluidEngine.ParseTemplate( _template );
        }

    }
}
