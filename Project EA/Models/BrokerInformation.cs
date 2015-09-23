using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Project_EA.Models
{
    public class BrokerInformation
    {
        
        public int ID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("DOI License Number")]
        public string DOILicenseNumber { get; set; }

        [Required]
        [DisplayName("Address 1")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^(\d{5}|\d{5}-\d{4})$", ErrorMessage = "Not a Valid Zip Code")]
        public string Zip { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string FaxNumber { get; set; }

        [RegularExpression(@"[a-zA-Z.0-9_]*[@][a-zA-Z]*[.][a-zA-Z]*", ErrorMessage = "Not a valid Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailAddress { get; set; }

        public string AgencyName { get; set; }

        public string NameOfGeneralAgent { get; set; }

        [Required]
        public string Payee { get; set; }

        [Required]
        public string PayeeTaxId { get; set; }

        
        [StringLength(9, MinimumLength = 9)]
        public string SsnTin { get; set; }

        [Required]
        public int BrokerCommissionSplitPercent { get; set; }

        [Required]
        public string IsProducerAppointed { get; set; }

        public string ProducerTitle { get; set; }

    }

    public class ProjectEADBContext :DbContext
    {
        public DbSet<BrokerInformation> BrokerInformations { get; set; }
    }
}