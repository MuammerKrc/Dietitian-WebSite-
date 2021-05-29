using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class CombineDietMenüRecipeConfiguration : IEntityTypeConfiguration<CombineDietMenüRecipe>
    {
        public void Configure(EntityTypeBuilder<CombineDietMenüRecipe> builder)
        {
            builder.HasKey(m => new { m.RecipeId, m.DietMenüId });

            builder.HasData(
                new CombineDietMenüRecipe(){DietMenüId=1,RecipeId=1},
                new CombineDietMenüRecipe(){DietMenüId=1,RecipeId=2},
                new CombineDietMenüRecipe(){DietMenüId=2,RecipeId=4},
                new CombineDietMenüRecipe(){DietMenüId=3,RecipeId=1},
                new CombineDietMenüRecipe(){DietMenüId=4,RecipeId=6},
                new CombineDietMenüRecipe(){DietMenüId=5,RecipeId=4},
                new CombineDietMenüRecipe(){DietMenüId=5,RecipeId=7},
                new CombineDietMenüRecipe(){DietMenüId=5,RecipeId=5},
                new CombineDietMenüRecipe(){DietMenüId=6,RecipeId=5},
                new CombineDietMenüRecipe(){DietMenüId=6,RecipeId=7},
                new CombineDietMenüRecipe(){DietMenüId=7,RecipeId=6},
                new CombineDietMenüRecipe(){DietMenüId=8,RecipeId=4},
                new CombineDietMenüRecipe(){DietMenüId=8,RecipeId=3},
                new CombineDietMenüRecipe(){DietMenüId=9,RecipeId=1},
                new CombineDietMenüRecipe(){DietMenüId=10,RecipeId=2}
            );
        }
    }
}