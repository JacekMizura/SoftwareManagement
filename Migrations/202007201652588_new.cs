namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contractors", "NIP", c => c.String(maxLength: 10));
            AlterColumn("dbo.Contractors", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Contractors", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contractors", "Name", c => c.String());
            AlterColumn("dbo.Contractors", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Contractors", "NIP", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
