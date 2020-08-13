namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produkt", "Rodzaj", c => c.String());
            DropColumn("dbo.Produkt", "RodzajID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produkt", "RodzajID", c => c.String());
            DropColumn("dbo.Produkt", "Rodzaj");
        }
    }
}
