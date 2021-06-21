using System;

namespace app.entity
{
    public class DateRequest : BaseClass
    {
        public int WeekId { get; set; }
        public string FullName { get; set; }
        public DateTime RequestTİme { get; set; }
        public DateType typeOfRequest { get; set; }
    }
    public enum DateType
    {
        Diet = 1,
        Pilates = 2
    }
}