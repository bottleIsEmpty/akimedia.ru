namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookGenresTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        WriterId = c.Int(nullable: false),
                        DateReleased = c.DateTime(nullable: false),
                        Poster = c.String(),
                        Description = c.String(),
                        Rating = c.Byte(),
                        RatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Writers", t => t.WriterId, cascadeDelete: true)
                .Index(t => t.WriterId);
            
            CreateTable(
                "dbo.BookBookGenres",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        BookGenre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.BookGenre_Id })
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.BookGenres", t => t.BookGenre_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.BookGenre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookBookGenres", "BookGenre_Id", "dbo.BookGenres");
            DropForeignKey("dbo.BookBookGenres", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "WriterId", "dbo.Writers");
            DropIndex("dbo.BookBookGenres", new[] { "BookGenre_Id" });
            DropIndex("dbo.BookBookGenres", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "WriterId" });
            DropTable("dbo.BookBookGenres");
            DropTable("dbo.Books");
            DropTable("dbo.BookGenres");
        }
    }
}
