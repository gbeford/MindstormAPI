using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class MatchDefinition
    {
        public int MatchDefinitionId { get; set; }
        public int SortOrder { get; set; } // puts question on the page in order
        public int MissionOrder { get; set; }  // groups them by category
        public string MissionDescription { get; set; }
        public string QuestionDescription { get; set; }
        public bool Type { get; set; } // bool / range/ string list
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public string OptionList { get; set; }
        public bool Validate { get; set; }

    }
}
