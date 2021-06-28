using System;
using System.Collections.Generic;

namespace app.entity
{
    public class Pilates : BaseClass
    {
        public bool Active { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<PilatesWeek> PilatesWeeks { get; set; }
    }
}