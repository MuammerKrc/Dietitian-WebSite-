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
        public TraningType Traning { get; set; }
        public int? DietWekklyId { get; set; }
        public DietWekkly DietWekkly { get; set; }
        public int? PilatesWeekId { get; set; }
        public PilatesWeek PilatesWeek { get; set; }
        public DateTime DateTimeOfDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
    }

    public enum TraningType
    {
        Diet = 1,
        Pilates = 2
    }
}