using System;
using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class DietConfiguration : IEntityTypeConfiguration<Diet>
    {
        public void Configure(EntityTypeBuilder<Diet> builder)
        {

            builder.HasData(
                new Diet(){Id=1,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=1},
                new Diet(){Id=2,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=2},
                new Diet(){Id=3,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=3},
                new Diet(){Id=4,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=4},
                new Diet(){Id=5,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=5},
                new Diet(){Id=6,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=6},
                new Diet(){Id=7,DateEnd=DateTime.Now,DateStart=DateTime.Now,Height=168,StartingBreastSize=84,StartingWaistline=90,StartingWeight=80,CustomerId=7}
            );
        }
    }
}