namespace Sahaab_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddListOfPhoneNumbers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NumberId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NumberId");
        }
    }
}
