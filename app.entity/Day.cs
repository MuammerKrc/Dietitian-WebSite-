using System.Collections.Generic;

namespace app.entity
{
    public class Day : BaseClass
    {
        public int? MounthId { get; set; }
        public Mounth Mounth { get; set; }
        public int CurrentDay { get; set; }
        public bool Active { get; set; }
        public List<Hour> Hours{get;set;}
    }
}