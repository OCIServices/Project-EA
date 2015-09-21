namespace Project_EA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ssntinMinandMax : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BrokerInformations", "SsnTin", c => c.String(maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BrokerInformations", "SsnTin", c => c.String(nullable: false, maxLength: 9));
        }
    }
}
