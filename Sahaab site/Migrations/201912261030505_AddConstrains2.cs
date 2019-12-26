namespace Sahaab_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConstrains2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
