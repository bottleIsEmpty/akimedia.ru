namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingDirectorsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('Квентин', 'Тарантино')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('Кристофер', 'Нолан')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('Френк', 'Дарабонт')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('Дэвид', 'Финчер')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('Стивен', 'Спилберг')");
        }
        
        public override void Down()
        {
        }
    }
}
