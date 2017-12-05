namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToSignatureCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SignatureCustomers", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
            DropColumn("dbo.SignatureCustomers", "Name");
        }
    }
}
