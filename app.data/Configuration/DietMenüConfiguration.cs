using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class DietMenüConfiguration : IEntityTypeConfiguration<DietMenü>
    {
        public void Configure(EntityTypeBuilder<DietMenü> builder)
        {
          
        }
    }
}