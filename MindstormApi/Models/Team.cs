using System;

namespace MindstormApi.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public int TeamNumber { get; set; }
        public string TeamName { get; set; }
        public string CoachFirstName { get; set; }
        public string CoachLastName { get; set; }
        public string CoachEmail { get; set; }
        public string AltCoachFirstName { get; set; }
        public string AltCoachlastName { get; set; }
        public string AltCoachEmail { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CompetitionID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}