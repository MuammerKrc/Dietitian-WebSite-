using System;

namespace app.entity
{
    public class Hour : BaseClass
    {
        public string CurrentHour { get; set; }
        public int StartingHour { get; set; }
        public int FinishedHour { get; set; }
        public int? DietWekklyId { get; set; }
        public DietWekkly DietWekkly { get; set; }
        public bool Active { get; set; }
        public int DayId { get; set; }
        public Day Day { get; set; }
    }
}