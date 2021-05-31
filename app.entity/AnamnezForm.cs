using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace app.entity
{
    public class AnamnezForm : BaseClass
    {
        public Diet Diet { get; set; }
        public string Soru1 { get; set; }
        public string Soru2 { get; set; }
        public string Soru3 { get; set; }
        public string Soru4 { get; set; }
        public string Soru5 { get; set; }
        public string Soru6 { get; set; }
        public string Soru7 { get; set; }
        public string Soru8 { get; set; }
        public string Soru9 { get; set; }
        public string Soru10 { get; set; }
        public string Soru11 { get; set; }
        public string Soru12 { get; set; }
        public string Soru13 { get; set; }
        public string Soru14 { get; set; }
        public string Soru15 { get; set; }
        public string Soru16 { get; set; }
        public string Soru17 { get; set; }
        public string Soru18 { get; set; }
        public string Soru19 { get; set; }
        public string Soru20 { get; set; }
        public string morning { get; set; }
        public string Snack1 { get; set; }
        public string noon { get; set; }
        public string Snack2 { get; set; }
        public string Evening { get; set; }
        public string snack3 { get; set; }
        public int? water { get; set; }
        public int? Tea { get; set; }
        public int? Coffea { get; set; }
        public int? Soda { get; set; }
        public int? HerbalTea { get; set; }
        public int? Alkol { get; set; }
        public int? Juice { get; set; }
        public int? Cola { get; set; }
    }
}