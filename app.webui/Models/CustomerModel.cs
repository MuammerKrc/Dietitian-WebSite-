using System.ComponentModel.DataAnnotations;
using app.entity;

namespace app.webui.Models
{
    public class CustomerModel
    {
        public int Id{get;set;}

        [Required]
        public string UserId { get; set; }

        [Display(Name = "Cinsiyet")]
        public bool Gender { get; set; }


        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Bu alan en az 3 karakter olmalıdır")]
        public string FirstName { get; set; }


        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Bu alan en az 3 karakter olmalıdır")]
        public string LastName { get; set; }


        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Bu Alan Sizi Bilgilendirmek İçin Gereklidir")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Adı")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Bu Alan Sizi Bilgilendirmek İçin Gereklidir")]
        public string Mail { get; set; }
        [Required]
        public int RemaningDietPackages { get; set; }
        [Required]
        public int RemaningPilatesPackages { get; set; }
        public Diet Diet { get; set; }
        public Pilates Pilates { get; set; }

        public CustomerModel(Customer c)
        {
            this.Id=c.Id;
            this.UserId = c.UserId;
            this.Gender = c.Gender;
            this.FirstName = c.FirstName;
            this.LastName = c.LastName;
            this.PhoneNumber = c.PhoneNumber;
            this.Mail = c.Mail;
            this.RemaningDietPackages = c.RemaningDietPackages;
            this.RemaningPilatesPackages = c.RemaningPilatesPackages;
            this.Diet = c.Diet;
            this.Pilates = c.Pilates;
        }

        public Customer GetCustomer()
        {
            Customer customer = new Customer()
            {
                UserId = this.UserId,
                Gender = this.Gender,
                FirstName = this.FirstName,
                LastName = this.LastName,
                PhoneNumber = this.PhoneNumber,
                Mail = this.Mail,
                RemaningDietPackages = this.RemaningDietPackages,
                RemaningPilatesPackages = this.RemaningPilatesPackages,
                Diet = this.Diet,
                Pilates = this.Pilates
            };
            return customer;
        }
    }
}