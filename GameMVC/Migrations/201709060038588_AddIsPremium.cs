namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsPremiumCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isPremium", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isPremium");
        }
    }
}
