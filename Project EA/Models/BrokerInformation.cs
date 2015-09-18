using System.Data.Entity;

namespace Project_EA.Models
{
    public class BrokerInformation
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DOILicenseNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AgencyName { get; set; }
        public string NameOfGeneralAgent { get; set; }
        public string Payee { get; set; }
        public string PayeeTaxId { get; set; }
        public int SsnTin { get; set; }
        public int BrokerCommissionSplitPercent { get; set; }
        public string IsProducerAppointed { get; set; }
        public string ProducerTitle { get; set; }
    }

    public class BrokerInformationsDBContext :ApplicationDbContext
    {
        public DbSet<BrokerInformation> BrokerInformations { get; set; }
    }
}