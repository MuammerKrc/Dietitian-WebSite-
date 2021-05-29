using System.Collections.Generic;

namespace app.entity
{
    public class DietMenü : BaseClass
    {
        public string Path { get; set; }
        public bool Gender { get; set; }
        public bool TwoMeals { get; set; }
        public int Weight { get; set; }
        public List<CombineDietMenüRecipe> CombineDietMenüRecipes { get; set; }

    }
}