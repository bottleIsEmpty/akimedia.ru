namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Мультфильм')");
            Sql("INSERT INTO Genres (Name) VALUES ('Аниме')");
            Sql("INSERT INTO Genres (Name) VALUES ('Боевик')");
            Sql("INSERT INTO Genres (Name) VALUES ('Драма')");
            Sql("INSERT INTO Genres (Name) VALUES ('Триллер')");
            Sql("INSERT INTO Genres (Name) VALUES ('Ужасы')");
            Sql("INSERT INTO Genres (Name) VALUES ('Блокбастер')");
            Sql("INSERT INTO Genres (Name) VALUES ('Биографический')");
            Sql("INSERT INTO Genres (Name) VALUES ('Вестерн')");
            Sql("INSERT INTO Genres (Name) VALUES ('Военный')");
            Sql("INSERT INTO Genres (Name) VALUES ('Детектив')");
            Sql("INSERT INTO Genres (Name) VALUES ('Детский')");
            Sql("INSERT INTO Genres (Name) VALUES ('Документальный')");
            Sql("INSERT INTO Genres (Name) VALUES ('Исторический')");
            Sql("INSERT INTO Genres (Name) VALUES ('Кинокомикс')");
            Sql("INSERT INTO Genres (Name) VALUES ('Комедия')");
            Sql("INSERT INTO Genres (Name) VALUES ('Короткометражный')");
            Sql("INSERT INTO Genres (Name) VALUES ('Криминал')");
            Sql("INSERT INTO Genres (Name) VALUES ('Мелодрама')");
            Sql("INSERT INTO Genres (Name) VALUES ('Мистика')");
            Sql("INSERT INTO Genres (Name) VALUES ('Музыка')");
            Sql("INSERT INTO Genres (Name) VALUES ('Мюзикл')");
            Sql("INSERT INTO Genres (Name) VALUES ('Научный')");
            Sql("INSERT INTO Genres (Name) VALUES ('Нуар')");
            Sql("INSERT INTO Genres (Name) VALUES ('Приключения')");
            Sql("INSERT INTO Genres (Name) VALUES ('Реалити-шоу')");
            Sql("INSERT INTO Genres (Name) VALUES ('Семейный')");
            Sql("INSERT INTO Genres (Name) VALUES ('Спорт')");
            Sql("INSERT INTO Genres (Name) VALUES ('Ток-шоу')");
            Sql("INSERT INTO Genres (Name) VALUES ('Фантастика')");
            Sql("INSERT INTO Genres (Name) VALUES ('Фэнтези')");
        }
        
        public override void Down()
        {
        }
    }
}
