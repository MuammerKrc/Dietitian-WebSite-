using System;

namespace app.entity
{
    public class Calendar : BaseClass
    {
        public int CurrentYear { get; set; }
        public int CurrentMounth { get; set; }
        public int CurrentDay { get; set; }
        public string CurrentHour { get; set; }
        public int StartingHour { get; set; }
        public int FinishedHour { get; set; }
        public string Traning { get; set; }
        public int? DietWekklyId { get; set; }
        public DietWekkly DietWekkly { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
    }
}