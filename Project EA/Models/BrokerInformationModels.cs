using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Project_EA.Models
{
    public class BrokerInformationModels
    {
        
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DOILicenseNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string FaxNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public string AgencyName { get; set; }

        public string NameOfGeneralAgent { get; set; }

        public string Payee { get; set; }

        public string PayeeTaxId { get; set; }

        public string SsnTin { get; set; }

        public int BrokerCommissionSplitPercent { get; set; }

        public string IsProducerAppointed { get; set; }

        public string ProducerTitle { get; set; }

    }

    public class ProjectEADBContext :DbContext
    {
        public DbSet<BrokerInformationModels> BrokerInformations { get; set; }
    }
}