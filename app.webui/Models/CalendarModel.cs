using System;
using System.Collections.Generic;
using System.Linq;
using app.entity;

namespace app.webui.Models
{
    public class CalendarModel
    {
        private List<String> allDay = new List<string>() { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi" };
        public DateTime time { get; set; }
        private DateTime tempTime { get; set; }
        private int CurrentMounth { get; set; }
        private int CurrentDayOfWeek { get; set; }
        private int StartingDay { get; set; }
        public List<ThisWeek> TakeWeek { get; set; }
        public Mounth AllDate { get; set; }
        public CalendarModel(DateTime _time, Mounth _alldate)
        {
            if (_time.Year == 1)
            {
                time = DateTime.Now;
                tempTime = DateTime.Now;
            }
            else
            {
                time = _time;
                tempTime = _time;
            }
            AllDate = _alldate;
            CurrentMounth = time.Month;
            CurrentDayOfWeek = ((int)time.DayOfWeek);
            MakeThisWeek();
        }
        private void MakeThisWeek()
        {
            StartingDay = time.Day;
            TakeWeek = new List<ThisWeek>();

            for (int i = 0; i < 7; i++)
            {
                tempTime = time.AddDays(i);
                bool TempInThisMounth = false;


                ThisWeek t1 = new ThisWeek();
                t1.number = i + 1;
                t1.CurrentDayOfMounth = tempTime.Day;
                t1.DayName = allDay[((int)tempTime.DayOfWeek)];

                if (tempTime.Month == CurrentMounth)
                {
                    TempInThisMounth = true;
                    if (AllDate.Days != null)
                    {
                        if (AllDate.Days.Count > 0)
                        {
                            var item = AllDate.Days.FirstOrDefault(i => i.CurrentDay == tempTime.Day);
                            if(item!=null)
                            {
                                if(item.Hours.Count>0)
                                {
                                    foreach(var y in item.Hours)
                                    {
                                        t1.dates.Add(new DateModel(){
                                            StartTime=y.CurrentHour
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    TempInThisMounth = false;
                }
                t1.InThisMounth = TempInThisMounth;
                TakeWeek.Add(t1);
            }
        }
    }
    public class ThisWeek
    {
        public int number;
        public int CurrentDayOfMounth;
        public bool InThisMounth;
        public string DayName;
        public List<DateModel> dates = new List<DateModel>();
    }
    public class DateModel
    {
        public string StartTime;
        public string FullName;
    }
}