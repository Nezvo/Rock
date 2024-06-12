using System;
using System.Collections.Generic;

using Rock.Model;

namespace Rock.ViewModels.Blocks.OscMatching.MatchingTool
{
    public class ProjectResponseBag
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Partner { get; set; }
        public string Location { get; set; }
        public Gender Gender { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? CampusGuid { get; set; }
        public int? SuggestedOscId { get; set; }
        public string SuggestedOscName { get; set; }
        public int? SelectedOscId { get; set; }
        public string SelectedOscName { get; set; }
        public int? Capacity { get; set; }
        public string GenderString { get; set; }
        public string FullDate { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public List<string> TimeOfDay { get; set; }
    }
}
