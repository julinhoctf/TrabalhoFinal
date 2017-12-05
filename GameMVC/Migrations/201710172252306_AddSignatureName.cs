namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSignatureName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plataforms", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Musics", "nome", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MusicPlayers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MusicPlayers", "Name", c => c.String());
            AlterColumn("dbo.Musics", "nome", c => c.String());
            AlterColumn("dbo.Plataforms", "Name", c => c.String());
        }
    }
}
