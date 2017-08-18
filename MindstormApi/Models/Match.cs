using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        // public int MatchDefinitionId { get; set; }
        // public MatchDefinition MatchDefinition { get; set; }
        public int MatchNumber { get; set; }
        public int TableNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime MatchYear { get; set; }
    }
}