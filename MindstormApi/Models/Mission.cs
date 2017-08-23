using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class Mission
    {
        public int MissionId { get; set; }
        public string MissionDescription { get; set; }
        public List<MissionItem> MissionItems { get; set; }
        public DateTime Created { get; set; }
        public int SortOrder { get; set; }
        public int MatchYear { get; set; }

        public Mission()
        {
            MissionItems = new List<MissionItem>();
        }
    }
}
