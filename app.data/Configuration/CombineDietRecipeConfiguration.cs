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
     
        }
    }
}