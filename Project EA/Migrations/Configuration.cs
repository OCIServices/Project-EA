namespace Project_EA.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_EA.Models.ProjectEADBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project_EA.Models.ProjectEADBContext context)
        {
            context.BrokerInformations.AddOrUpdate(i => i.EmailAddress,
                new BrokerInformation
                {
                    FirstName = "Kenny",
                    LastName = "Peel",
                    Address1 = "17445 Arbor St",
                    Address2 = "Suite 310",
                    City = "Omaha",
                    State = "Nebraska",
                    Zip = "68130",
                    PhoneNumber = "4023308700",
                    FaxNumber = "4023308706",
                    EmailAddress = "kpeel@ociservices.com",
                    Payee = "Kenny Peel",
                    PayeeTaxId = "123456789",
                    SsnTin = "123456789",
                    BrokerCommissionSplitPercent = 50,
                    IsProducerAppointed = "Yes",
                    ProducerTitle = "IT"
                },

                new BrokerInformation
                {
                    FirstName = "Sean",
                    LastName = "Peel",
                    Address1 = "17445 Arbor St",
                    Address2 = "Suite 310",
                    City = "Omaha",
                    State = "Nebraska",
                    Zip = "68130",
                    PhoneNumber = "4023308700",
                    FaxNumber = "4023308706",
                    EmailAddress = "speel@ociservices.com",
                    Payee = "Sean Peel",
                    PayeeTaxId = "123456789",
                    SsnTin = "123456789",
                    BrokerCommissionSplitPercent = 50,
                    IsProducerAppointed = "Yes",
                    ProducerTitle = "IT"
                }

                );
        }
    }
}
