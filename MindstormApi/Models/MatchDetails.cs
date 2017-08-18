using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class MatchDetails
    {
        public int MatchDetailsId { get; set; }
        public int MatchDefinitionId { get; set; }
        public MatchDefinition MatchDefinition { get; set; }
        public string Answer { get; set; }
        public string TeamSignature { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MatchYear { get; set; }
    }
}
