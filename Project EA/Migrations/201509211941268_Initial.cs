namespace Project_EA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrokerInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOILicenseNumber = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                        AgencyName = c.String(),
                        NameOfGeneralAgent = c.String(),
                        Payee = c.String(),
                        PayeeTaxId = c.String(),
                        SsnTin = c.String(),
                        BrokerCommissionSplitPercent = c.Int(nullable: false),
                        IsProducerAppointed = c.String(),
                        ProducerTitle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BrokerInformations");
        }
    }
}
