using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasData(
                new Customer() { Id = 1, FirstName = "Dilek", LastName = "Karaca", DietId = 1, PilatesId = 1, Mail = "dlk@gmail.com", PhoneNumber = "5524673747" ,UserId="asdad"},
                new Customer() { Id = 2, FirstName = "Sinem", LastName = "Karaca", DietId = 2, PilatesId = 2, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad" },
                new Customer() { Id = 3, FirstName = "Muammer", LastName = "Karaca", DietId = 3, PilatesId = 3, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad" },
                new Customer() { Id = 4, FirstName = "Ercan", LastName = "Karaca", DietId = 4, PilatesId = 4, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad"},
                new Customer() { Id = 5, FirstName = "Mustafa", LastName = "Karaca", DietId = 5, PilatesId = 5, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad"},
                new Customer() { Id = 6, FirstName = "Sercan", LastName = "Karaca", DietId = 6, PilatesId = 6, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad" },
                new Customer() { Id = 7, FirstName = "Güven", LastName = "Karaca", DietId = 7, PilatesId = 7, Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad"}
            );
        }
    }
}