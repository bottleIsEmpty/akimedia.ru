namespace akimedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingDirectorsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('�������', '���������')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('���������', '�����')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('�����', '��������')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('�����', '������')");
            Sql("INSERT INTO Directors (Name, Surname) VALUES ('������', '��������')");
        }
        
        public override void Down()
        {
        }
    }
}
