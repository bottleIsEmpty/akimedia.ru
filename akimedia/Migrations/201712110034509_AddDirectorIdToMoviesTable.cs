namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectorIdToMoviesTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Director_Id", newName: "DirectorId");
            RenameIndex(table: "dbo.Movies", name: "IX_Director_Id", newName: "IX_DirectorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_DirectorId", newName: "IX_Director_Id");
            RenameColumn(table: "dbo.Movies", name: "DirectorId", newName: "Director_Id");
        }
    }
}
