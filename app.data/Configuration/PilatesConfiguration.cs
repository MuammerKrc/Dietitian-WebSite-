using System;
using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class PilatesConfiguration : IEntityTypeConfiguration<Pilates>
    {
        public void Configure(EntityTypeBuilder<Pilates> builder)
        {
            builder.HasData(
                new Pilates() { Id = 1, DateStart = DateTime.Now, CustomerId = 1 },
                new Pilates() { Id = 2, DateStart = DateTime.Now, CustomerId = 2 },
                new Pilates() { Id = 3, DateStart = DateTime.Now, CustomerId = 3 },
                new Pilates() { Id = 4, DateStart = DateTime.Now, CustomerId = 4 },
                new Pilates() { Id = 5, DateStart = DateTime.Now, CustomerId = 5 },
                new Pilates() { Id = 6, DateStart = DateTime.Now, CustomerId = 6 },
                new Pilates() { Id = 7, DateStart = DateTime.Now, CustomerId = 7 }
            );
        }
    }
}