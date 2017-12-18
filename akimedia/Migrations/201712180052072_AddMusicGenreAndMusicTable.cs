namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMusicGenreAndMusicTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        MusicianId = c.Int(nullable: false),
                        Album = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        Poster = c.String(),
                        Rating = c.Byte(),
                        RatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musicians", t => t.MusicianId, cascadeDelete: true)
                .Index(t => t.MusicianId);
            
            CreateTable(
                "dbo.MusicMusGenres",
                c => new
                    {
                        Music_Id = c.Int(nullable: false),
                        MusGenre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Music_Id, t.MusGenre_Id })
                .ForeignKey("dbo.Musics", t => t.Music_Id, cascadeDelete: true)
                .ForeignKey("dbo.MusGenres", t => t.MusGenre_Id, cascadeDelete: true)
                .Index(t => t.Music_Id)
                .Index(t => t.MusGenre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musics", "MusicianId", "dbo.Musicians");
            DropForeignKey("dbo.MusicMusGenres", "MusGenre_Id", "dbo.MusGenres");
            DropForeignKey("dbo.MusicMusGenres", "Music_Id", "dbo.Musics");
            DropIndex("dbo.MusicMusGenres", new[] { "MusGenre_Id" });
            DropIndex("dbo.MusicMusGenres", new[] { "Music_Id" });
            DropIndex("dbo.Musics", new[] { "MusicianId" });
            DropTable("dbo.MusicMusGenres");
            DropTable("dbo.Musics");
            DropTable("dbo.MusGenres");
        }
    }
}
