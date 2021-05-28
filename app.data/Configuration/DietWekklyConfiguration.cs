using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class DietWekklyConfiguration : IEntityTypeConfiguration<DietWekkly>
    {
        public void Configure(EntityTypeBuilder<DietWekkly> builder)
        {
            builder.HasData(
                new DietWekkly() { Id = 1, AvgNmbrOfSteps = 2500, DietImplementation = 4, AvgWater = 2.5, CurrentWaistline = 80, CurrentBreastSize = 70, CurrentWeight = 80, DietId = 1,},
                new DietWekkly() { Id = 2, AvgNmbrOfSteps = 2700, DietImplementation = 3, AvgWater = 2, CurrentWaistline = 79, CurrentBreastSize = 68, CurrentWeight = 78, DietId = 1 },
                new DietWekkly() { Id = 3, AvgNmbrOfSteps = 2300, DietImplementation = 2, AvgWater = 3, CurrentWaistline = 76, CurrentBreastSize = 67, CurrentWeight = 75, DietId = 1 },
                new DietWekkly() { Id = 4, AvgNmbrOfSteps = 200, DietImplementation = 5, AvgWater = 2, CurrentWaistline = 75, CurrentBreastSize = 65, CurrentWeight = 60, DietId = 1 },
                 new DietWekkly() { Id = 5, AvgNmbrOfSteps = 2500, DietImplementation = 4, AvgWater = 2.5, CurrentWaistline = 80, CurrentBreastSize = 70, CurrentWeight = 80, DietId = 2 },
                new DietWekkly() { Id = 6, AvgNmbrOfSteps = 2700, DietImplementation = 3, AvgWater = 2, CurrentWaistline = 79, CurrentBreastSize = 68, CurrentWeight = 78, DietId =2 },
                new DietWekkly() { Id = 7, AvgNmbrOfSteps = 2300, DietImplementation = 2, AvgWater = 3, CurrentWaistline = 76, CurrentBreastSize = 67, CurrentWeight = 75, DietId = 2 },
                new DietWekkly() { Id = 8, AvgNmbrOfSteps = 200, DietImplementation = 5, AvgWater = 2, CurrentWaistline = 75, CurrentBreastSize = 65, CurrentWeight = 60, DietId = 2 },
                 new DietWekkly() { Id = 9, AvgNmbrOfSteps = 2500, DietImplementation = 4, AvgWater = 2.5, CurrentWaistline = 80, CurrentBreastSize = 70, CurrentWeight = 80, DietId = 3 },
                new DietWekkly() { Id = 10, AvgNmbrOfSteps = 2700, DietImplementation = 3, AvgWater = 2, CurrentWaistline = 79, CurrentBreastSize = 68, CurrentWeight = 78, DietId = 3 },
                new DietWekkly() { Id = 11, AvgNmbrOfSteps = 2300, DietImplementation = 2, AvgWater = 3, CurrentWaistline = 76, CurrentBreastSize = 67, CurrentWeight = 75, DietId = 4 },
                new DietWekkly() { Id = 12, AvgNmbrOfSteps = 200, DietImplementation = 5, AvgWater = 2, CurrentWaistline = 75, CurrentBreastSize = 65, CurrentWeight = 60, DietId = 4 },
                 new DietWekkly() { Id = 13, AvgNmbrOfSteps = 2500, DietImplementation = 4, AvgWater = 2.5, CurrentWaistline = 80, CurrentBreastSize = 70, CurrentWeight = 80, DietId = 4 },
                new DietWekkly() { Id = 14, AvgNmbrOfSteps = 2700, DietImplementation = 3, AvgWater = 2, CurrentWaistline = 79, CurrentBreastSize = 68, CurrentWeight = 78, DietId = 5 },
                new DietWekkly() { Id = 15, AvgNmbrOfSteps = 2300, DietImplementation = 2, AvgWater = 3, CurrentWaistline = 76, CurrentBreastSize = 67, CurrentWeight = 75, DietId = 5 },
                new DietWekkly() { Id = 16, AvgNmbrOfSteps = 200, DietImplementation = 5, AvgWater = 2, CurrentWaistline = 75, CurrentBreastSize = 65, CurrentWeight = 60, DietId = 5 }
            );
        }
    }
}