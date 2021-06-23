using System;

namespace app.entity
{
    public class DietWekkly : BaseClass
    {
        public string Name { get; set; }
        public float? GüncelKilo { get; set; }
        public float? GüncelBel { get; set; }
        public float? GüncelKalca { get; set; }
        public float? GüncelGögüs { get; set; }
        public float? Dietuyumluluk { get; set; }
        public int ortSu { get; set; }
        public int ortalamaAdim { get; set; }
        public bool Detox { get; set; }
        public int DietId { get; set; }
        public Diet Diet { get; set; }
        public DietMenü DietMenü { get; set; }
        public bool Active { get; set; }
        public bool IsUpdate { get; set; }
        public bool GivedDate { get; set; }
        public string DateTime { get; set; }
        public Calendar Calendar { get; set; }
    }
}