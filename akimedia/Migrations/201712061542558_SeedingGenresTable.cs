namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('����������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����')");
            Sql("INSERT INTO Genres (Name) VALUES ('������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����')");
            Sql("INSERT INTO Genres (Name) VALUES ('����������')");
            Sql("INSERT INTO Genres (Name) VALUES ('��������������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('��������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('��������������')");
            Sql("INSERT INTO Genres (Name) VALUES ('������������')");
            Sql("INSERT INTO Genres (Name) VALUES ('����������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('����������������')");
            Sql("INSERT INTO Genres (Name) VALUES ('��������')");
            Sql("INSERT INTO Genres (Name) VALUES ('���������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('������')");
            Sql("INSERT INTO Genres (Name) VALUES ('������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
            Sql("INSERT INTO Genres (Name) VALUES ('����')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������-���')");
            Sql("INSERT INTO Genres (Name) VALUES ('��������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����')");
            Sql("INSERT INTO Genres (Name) VALUES ('���-���')");
            Sql("INSERT INTO Genres (Name) VALUES ('����������')");
            Sql("INSERT INTO Genres (Name) VALUES ('�������')");
        }
        
        public override void Down()
        {
        }
    }
}
