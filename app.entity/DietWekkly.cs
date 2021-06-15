using System;

namespace app.entity
{
    public class DietWekkly : BaseClass
    {
        public string Name { get; set; }
        public int CurrentWeight { get; set; }
        public int CurrentWaistline { get; set; }
        public int CurrentBreastSize { get; set; }
        public int DietImplementation { get; set; }
        public double AvgWater { get; set; }
        public int AvgNmbrOfSteps { get; set; }
        public bool Detox { get; set; }
        public int? DietId { get; set; }
        public Diet Diet { get; set; }
        public DietMenü DietMenü { get; set; }
        public bool Active { get; set; }
        public bool GivedDate { get; set; }
        public string DateTime { get; set; }
        public Calendar Calendar { get; set; }
    }
}