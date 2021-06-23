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
         
        }
    }
}