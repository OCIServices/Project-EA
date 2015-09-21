namespace Project_EA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BrokerInformations", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "Address1", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "City", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "State", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "Zip", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "Payee", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "PayeeTaxId", c => c.String(nullable: false));
            AlterColumn("dbo.BrokerInformations", "SsnTin", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.BrokerInformations", "IsProducerAppointed", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BrokerInformations", "IsProducerAppointed", c => c.String());
            AlterColumn("dbo.BrokerInformations", "SsnTin", c => c.String(maxLength: 9));
            AlterColumn("dbo.BrokerInformations", "PayeeTaxId", c => c.String());
            AlterColumn("dbo.BrokerInformations", "Payee", c => c.String());
            AlterColumn("dbo.BrokerInformations", "EmailAddress", c => c.String());
            AlterColumn("dbo.BrokerInformations", "PhoneNumber", c => c.String());
            AlterColumn("dbo.BrokerInformations", "Zip", c => c.String());
            AlterColumn("dbo.BrokerInformations", "State", c => c.String());
            AlterColumn("dbo.BrokerInformations", "City", c => c.String());
            AlterColumn("dbo.BrokerInformations", "Address1", c => c.String());
            AlterColumn("dbo.BrokerInformations", "LastName", c => c.String());
            AlterColumn("dbo.BrokerInformations", "FirstName", c => c.String());
        }
    }
}
