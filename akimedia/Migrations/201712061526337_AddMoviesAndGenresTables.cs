namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesAndGenresTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Type = c.Boolean(nullable: false),
                        DateReleased = c.DateTime(nullable: false),
                        Poster = c.String(),
                        Description = c.String(),
                        Director_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Directors", t => t.Director_Id, cascadeDelete: true)
                .Index(t => t.Director_Id);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Genre_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Movies", "Director_Id", "dbo.Directors");
            DropIndex("dbo.MovieGenres", new[] { "Genre_Id" });
            DropIndex("dbo.MovieGenres", new[] { "Movie_Id" });
            DropIndex("dbo.Movies", new[] { "Director_Id" });
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
