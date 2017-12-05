namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMusicAndPlataforms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plataforms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MusicPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MusicPlayers");
            DropTable("dbo.Plataforms");
        }
    }
}
