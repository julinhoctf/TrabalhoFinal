namespace MusicMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarNomeCampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musics", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Musics", "nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musics", "nome", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Musics", "Name");
        }
    }
}
