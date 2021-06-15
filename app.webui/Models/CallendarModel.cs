using System;
using System.Collections.Generic;
using app.entity;

namespace app.webui.Models
{
    public class CallendarModel
    {
        private List<string> allDay = new List<string>() { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi" };

        public DateTime CurrentTime { get; set; }
        public DateTime StartTime{get;set;}
        public DateTime FinishTime{get;set;}
        public List<Week> Weeks;
        public CallendarModel(DateTime time)
        {
            CurrentTime = time;
            Weeks = new List<Week>();
            MakeCalendar();
        }

        void MakeCalendar()
        {
            int DayOfWeek = ((int)CurrentTime.DayOfWeek);
            DateTime tempTime = new DateTime();
            if (DayOfWeek == 0)
            {
                tempTime = CurrentTime.AddDays(-6);
            }
            else if (DayOfWeek == 1)
            {
                tempTime = CurrentTime;
            }
            else if (DayOfWeek > 1)
            {
                tempTime = CurrentTime.AddDays((1 - DayOfWeek));
            }
            for (var y = 0; y < 7; y++)
            {
                Week w = new Week()
                {
                    Time=tempTime,
                    CurrentLocalTime = tempTime.ToShortDateString(),
                    DayName = allDay[((int)tempTime.DayOfWeek)],
                    DayOfWeek = ((int)tempTime.DayOfWeek)
                };
                if(y==0)
                {
                    StartTime=tempTime;
                }
                if(y==6)
                {
                    FinishTime=tempTime;
                }
                Weeks.Add(w);
                tempTime=tempTime.AddDays(1);
            }
        }
    }

    public class Week
    {
        public DateTime Time;
        public string CurrentLocalTime;
        public string DayName;
        public int DayOfWeek;
        public List<Calendar> AllDateInDay=new List<Calendar>();
    }

}