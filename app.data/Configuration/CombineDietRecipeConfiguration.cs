using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class CombineDietRecipeConfiguration : IEntityTypeConfiguration<CombineDietRecipe>
    {
        public void Configure(EntityTypeBuilder<CombineDietRecipe> builder)
        {
            builder.HasKey(m=>new{m.DietId,m.RecipeId});
            builder.HasData(
                new CombineDietRecipe(){DietId=1,RecipeId=1},
                new CombineDietRecipe(){DietId=1,RecipeId=2},
                new CombineDietRecipe(){DietId=1,RecipeId=3},
                new CombineDietRecipe(){DietId=2,RecipeId=4},
                new CombineDietRecipe(){DietId=2,RecipeId=1},
                new CombineDietRecipe(){DietId=2,RecipeId=2}
            );
        }
    }
}