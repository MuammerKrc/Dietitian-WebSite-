using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(
                new Recipe(){Id=1,Name="Salata Tarifi",Active=true},
                new Recipe(){Id=2,Name="Kabak Tarifi",Active=true},
                new Recipe(){Id=3,Name="Tuzlu Tarifi",Active=true},
                new Recipe(){Id=4,Name="Omlet Tarifi",Active=true},
                new Recipe(){Id=5,Name="Su Tarifi",Active=true},
                new Recipe(){Id=6,Name="Kahve Tarifi",Active=true},
                new Recipe(){Id=7,Name="Karnıbahar Tarifi",Active=true}
            );
        }
    }
}