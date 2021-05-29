namespace app.entity
{
    public class CombineDietMenüRecipe
    {
        public int DietMenüId{get;set;}
        public DietMenü DietMenü{get;set;}
        public int RecipeId{get;set;}
        public Recipe Recipe{get;set;}
    }
}