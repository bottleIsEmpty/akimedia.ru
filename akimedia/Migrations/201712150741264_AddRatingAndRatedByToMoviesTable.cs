namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingAndRatedByToMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Byte());
            AddColumn("dbo.Movies", "RatedBy", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "RatedBy");
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
