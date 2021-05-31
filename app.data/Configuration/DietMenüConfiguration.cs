using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class DietMenüConfiguration : IEntityTypeConfiguration<DietMenü>
    {
        public void Configure(EntityTypeBuilder<DietMenü> builder)
        {
            builder.HasData(
                new DietMenü(){Id=1,Gender=false,TwoMeals=false,Weight=80,FullName="Muammer Karaca"},
                new DietMenü(){Id=2,Gender=true,TwoMeals=false,Weight=80,FullName="Sinem Karaca"},
                new DietMenü(){Id=3,Gender=false,TwoMeals=false,Weight=65,FullName="Muammer Karaca"},
                new DietMenü(){Id=4,Gender=true,TwoMeals=false,Weight=75,FullName="Sinem Karaca"},
                new DietMenü(){Id=5,Gender=true,TwoMeals=true,Weight=80,FullName="Muammer Karaca"},
                new DietMenü(){Id=6,Gender=false,TwoMeals=true,Weight=60,FullName="Dilek Karaca"},
                new DietMenü(){Id=7,Gender=false,TwoMeals=true,Weight=65,FullName="Sercan Karaca"},
                new DietMenü(){Id=8,Gender=true,TwoMeals=false,Weight=80,FullName="Muammer Karaca"},
                new DietMenü(){Id=9,Gender=true,TwoMeals=true,Weight=70,FullName="Muammer Karaca"},
                new DietMenü(){Id=10,Gender=true,TwoMeals=false,Weight=80,FullName="Sercan Karaca"}
            );
        }
    }
}