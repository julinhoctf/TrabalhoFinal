namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItens : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Plataforms (Name) VALUES ('On-line')");
            Sql("INSERT INTO dbo.Plataforms (Name) VALUES ('Software')");
            Sql("INSERT INTO dbo.MusicPlayers (Name) VALUES ('Casual')");
            Sql("INSERT INTO dbo.MusicPlayers (Name) VALUES ('DJ')");
            Sql("INSERT INTO dbo.Musics (Nome) VALUES ('Highway To Hell')");
            Sql("INSERT INTO dbo.Musics (Nome) VALUES ('Back in Black')");
            Sql("INSERT INTO dbo.SignatureCustomers (Id, Bonus, EndsIn) VALUES (1, 30, 20)");
            Sql("INSERT INTO dbo.SignatureCustomers (Id, Bonus, EndsIn) VALUES (2, 50, 10)");
            Sql("INSERT INTO dbo.Customers (Name, isPremium, SignatureCustomerId) VALUES ('usuario teste', 1, 1)");
            Sql("INSERT INTO dbo.Customers (Name, isPremium, SignatureCustomerId) VALUES ('novo usuario teste', 0, 2)");

        }
        
        public override void Down()
        {
        }
    }
}
