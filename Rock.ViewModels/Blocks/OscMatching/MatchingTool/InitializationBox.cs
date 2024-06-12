using Rock.ViewModels.Core.Grid;

namespace Rock.ViewModels.Blocks.OscMatching.MatchingTool
{
    public class InitializationBox
    {
        public bool IsOptimized { get; set; }
        public bool IsInitialConfigSet { get; set; }
        public GridDefinitionBag ProjectsGridDefinition { get; set; }
        public GridDefinitionBag OnSiteCoordinatorsGridDefinition { get; set; }
    }
}
