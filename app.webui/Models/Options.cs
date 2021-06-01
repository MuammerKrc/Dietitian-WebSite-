using System.Collections.Generic;

namespace app.webui.Models
{
    public class Options
    {
        //1=none 2=2meal 3=3meal
        public int Meal;
        //1=none 2=women 3=man
        public string Adı;
        public int Cinsiyet;
        public int MinWeight;
        public int MaxWeight;
        public List<int> Recipe;
    }
}