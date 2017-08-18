using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class Points
    {
        public int PointsId { get; set; }
        public int MatchDefinitionId { get; set; }
        public string MatchDefinitionDesc { get; set; }
        public int Point { get; set; }
       
    }
}
