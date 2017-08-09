namespace MindstormApi.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public int TeamNumber { get; set; }
        public string TeamName { get; set; }
        public string Coach { get; set; }
        public string CoachEmail { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}