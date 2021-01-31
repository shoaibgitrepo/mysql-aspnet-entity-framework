namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.Users", "Name", c => c.String(unicode: false));
            AlterColumn("dbo.Users", "Username", c => c.String(unicode: false));
            AlterColumn("dbo.Departments", "Name", c => c.String(unicode: false));
        }
    }
}
