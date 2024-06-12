using System;
using System.Collections.Generic;

using Rock.Model;

namespace Rock.ViewModels.Blocks.OscMatching.MatchingTool
{
    public class OnSiteCoordinatorResponseBag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public List<string> DayPreference { get; set; }
        public List<string> TimePreference { get; set; }
        public Guid? CampusGuid { get; set; }
        public int MaxProjects { get; set; }
        public int CurrentProjects { get; set; }
        public decimal MatchPercentage { get; set; }
        public string ExtraInfo { get; set; }

        public string GenderString => Gender.ToString();
        public string Projects => $"{CurrentProjects}/{MaxProjects}";
        public string FormattedMatchPercentage => $"{MatchPercentage:F1} %";
        public bool CanBeAssigned => CurrentProjects < MaxProjects;
    }
}
