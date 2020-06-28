namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (Username, Name, Email) VALUES ('username1', 'Name 1', 'username1@domain.com')");
            Sql("INSERT INTO Users (Username, Name, Email) VALUES ('username2', 'Name 2', 'username2@domain.com')");
            Sql("INSERT INTO Users (Username, Name, Email) VALUES ('username3', 'Name 3', 'username3@domain.com')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Users WHERE Username IN ('username1', 'username2', 'username3')");
        }
    }
}
