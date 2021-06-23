using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class DietWekklyConfiguration : IEntityTypeConfiguration<DietWekkly>
    {
        public void Configure(EntityTypeBuilder<DietWekkly> builder)
        {
        }
    }
}