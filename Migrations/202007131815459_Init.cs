namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        ContractorId = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Country = c.String(),
                        BuildingNumber = c.String(),
                        StreetNumber = c.String(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Contractors", t => t.ContractorId, cascadeDelete: true)
                .Index(t => t.ContractorId);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        ContractorID = c.Int(nullable: false, identity: true),
                        AddressID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NIP = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        REGON = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ContractorID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IngredientID);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        ProductTypeID = c.Int(nullable: false),
                        IngredientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.ProductTypeID, t.IngredientID })
                .ForeignKey("dbo.Ingredients", t => t.IngredientID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.ProductTypeID)
                .Index(t => t.IngredientID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        ValidityTerm = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        InventoryItemId = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        ContractorID = c.Int(nullable: false),
                        ItemType = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryItemId)
                .ForeignKey("dbo.Contractors", t => t.ContractorID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.ContractorID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "ProductTypeID", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.InventoryItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.InventoryItems", "ContractorID", "dbo.Contractors");
            DropForeignKey("dbo.ProductDetails", "IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.Addresses", "ContractorId", "dbo.Contractors");
            DropIndex("dbo.InventoryItems", new[] { "ContractorID" });
            DropIndex("dbo.InventoryItems", new[] { "ProductID" });
            DropIndex("dbo.ProductDetails", new[] { "IngredientID" });
            DropIndex("dbo.ProductDetails", new[] { "ProductTypeID" });
            DropIndex("dbo.ProductDetails", new[] { "ProductID" });
            DropIndex("dbo.Addresses", new[] { "ContractorId" });
            DropTable("dbo.Users");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.InventoryItems");
            DropTable("dbo.Products");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Employees");
            DropTable("dbo.Contractors");
            DropTable("dbo.Addresses");
        }
    }
}
