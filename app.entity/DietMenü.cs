using System.Collections.Generic;

namespace app.entity
{
    public class DietMen├╝ : BaseClass
    {
        public string FullName { get; set; }
        public string Path { get; set; }
        public bool Gender { get; set; }
        public bool TwoMeals { get; set; }
        public int Weight { get; set; }
        public string Content { get; set; }
        public int DietWekklyId { get; set; }
        public DietWekkly DietWekkly { get; set; }
        public List<CombineDietMen├╝Recipe> CombineDietMen├╝Recipes { get; set; }
    }
}