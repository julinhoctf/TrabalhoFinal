namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSignatureCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SignatureCustomers",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Bonus = c.Byte(nullable: false),
                        EndsIn = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "SignatureCustomerId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "SignatureCustomerId");
            AddForeignKey("dbo.Customers", "SignatureCustomerId", "dbo.SignatureCustomers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SignatureCustomerId", "dbo.SignatureCustomers");
            DropIndex("dbo.Customers", new[] { "SignatureCustomerId" });
            DropColumn("dbo.Customers", "SignatureCustomerId");
            DropTable("dbo.SignatureCustomers");
        }
    }
}
