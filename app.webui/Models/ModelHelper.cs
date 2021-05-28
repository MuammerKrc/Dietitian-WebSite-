using System.Collections.Generic;
using app.entity;

namespace app.webui.Models
{
    public static class ModelHelper
    {
        
        public static void MenüCreate(Menü m,List<MenüModel> l)
        {
            MenüModel m1=new MenüModel(m.MenüName1,m.Gived1);
            MenüModel m2=new MenüModel(m.MenüName2,m.Gived2);
            MenüModel m3=new MenüModel(m.MenüName3,m.Gived3);
            MenüModel m4=new MenüModel(m.MenüName4,m.Gived4);
            MenüModel m5=new MenüModel(m.MenüName5,m.Gived5);
            MenüModel m6=new MenüModel(m.MenüName6,m.Gived6);
            MenüModel m7=new MenüModel(m.MenüName7,m.Gived7);
            MenüModel m8=new MenüModel(m.MenüName8,m.Gived8);
            l.Add(m1);
            l.Add(m2);
            l.Add(m3);
            l.Add(m4);
            l.Add(m5);
            l.Add(m6);
            l.Add(m7);
            l.Add(m8);
        }
    }
}