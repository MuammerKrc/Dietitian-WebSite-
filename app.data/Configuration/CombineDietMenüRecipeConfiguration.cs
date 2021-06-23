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

           
        }
    }
}