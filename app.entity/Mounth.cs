using System.Collections.Generic;

namespace app.entity
{
    public class Mounth : BaseClass
    {
        public int CurrentMounth { get; set; }
        public List<Day> Days { get; set; }
        public bool Active { get; set; }
    }
}