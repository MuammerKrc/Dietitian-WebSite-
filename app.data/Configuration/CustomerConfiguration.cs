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
                new Customer() { Id = 1, FirstName = "Dilek", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747" ,UserId="asdad",Gender=true},
                new Customer() { Id = 2, FirstName = "Sinem", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad",Gender=true },
                new Customer() { Id = 3, FirstName = "Muammer", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad" ,Gender=false},
                new Customer() { Id = 4, FirstName = "Ercan", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad",Gender=false},
                new Customer() { Id = 5, FirstName = "Mustafa", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad",Gender=false},
                new Customer() { Id = 6, FirstName = "Sercan", LastName = "Karaca",  Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad" ,Gender=false},
                new Customer() { Id = 7, FirstName = "Güven", LastName = "Karaca", Mail = "dlk@gmail.com", PhoneNumber = "5524673747",UserId="asdad",Gender=false}
            );
        }
    }
}