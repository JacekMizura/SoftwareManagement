namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
