using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class MissionItem
    {
        public int MissionItemId { get; set; }
        public string QuestionDescription { get; set; }
        public string Type { get; set; } // bool / range/ string list
        public int? MinRange { get; set; }
        public int? MaxRange { get; set; }
        public string OptionList { get; set; }
        public int SortOrder { get; set; }
        public int MissionId { get; set; }
        public Mission Mission { get; set; }
        public string[] OptionListArray
        {
            get
            {
                return string.IsNullOrEmpty(OptionList) ? null : OptionList.Split(',');
            }
        }
        public List<string> RangeListArray
        {
            get
            {
                if (Type == "range")
                {
                    var RangeList = new List<string>();
                    for (var x = MinRange; x <= MaxRange; x++)
                    {
                        RangeList.Add(x.ToString());
                    }
                    return RangeList;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
