namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contractor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                        BuildingNumber = c.String(),
                        StreetNumber = c.String(),
                        Contractor_ContractorID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Contractors", t => t.Contractor_ContractorID)
                .Index(t => t.Contractor_ContractorID);
            
            CreateTable(
                "dbo.CategoryTypes",
                c => new
                    {
                        CategoryTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contractor_ContractorID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryTypeID)
                .ForeignKey("dbo.Contractors", t => t.Contractor_ContractorID)
                .Index(t => t.Contractor_ContractorID);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        ContractorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NIP = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Salary = c.String(),
                    })
                .PrimaryKey(t => t.ContractorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryTypes", "Contractor_ContractorID", "dbo.Contractors");
            DropForeignKey("dbo.Addresses", "Contractor_ContractorID", "dbo.Contractors");
            DropIndex("dbo.CategoryTypes", new[] { "Contractor_ContractorID" });
            DropIndex("dbo.Addresses", new[] { "Contractor_ContractorID" });
            DropTable("dbo.Contractors");
            DropTable("dbo.CategoryTypes");
            DropTable("dbo.Addresses");
        }
    }
}
