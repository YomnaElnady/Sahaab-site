namespace Sahaab_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddListOfPhoneNumbers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Numbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Numbers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Numbers", new[] { "Customer_Id" });
            DropTable("dbo.Numbers");
        }
    }
}
