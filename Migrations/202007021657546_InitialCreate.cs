namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        ZipCode = c.Int(nullable: false),
                        Country = c.String(),
                        BuildingNumber = c.Int(nullable: false),
                        StreetNumber = c.Int(nullable: false),
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
                        NIP = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        REGON = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ContractorID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IngredientID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        ExpireTime = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
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
            
            CreateTable(
                "dbo.ProductIngredients",
                c => new
                    {
                        Product_ProductID = c.Int(nullable: false),
                        Ingredient_IngredientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductID, t.Ingredient_IngredientID })
                .ForeignKey("dbo.Products", t => t.Product_ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_IngredientID, cascadeDelete: true)
                .Index(t => t.Product_ProductID)
                .Index(t => t.Ingredient_IngredientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductIngredients", "Ingredient_IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.ProductIngredients", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.CategoryTypes", "Contractor_ContractorID", "dbo.Contractors");
            DropForeignKey("dbo.Addresses", "Contractor_ContractorID", "dbo.Contractors");
            DropIndex("dbo.ProductIngredients", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.ProductIngredients", new[] { "Product_ProductID" });
            DropIndex("dbo.CategoryTypes", new[] { "Contractor_ContractorID" });
            DropIndex("dbo.Addresses", new[] { "Contractor_ContractorID" });
            DropTable("dbo.ProductIngredients");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Employees");
            DropTable("dbo.Contractors");
            DropTable("dbo.CategoryTypes");
            DropTable("dbo.Addresses");
        }
    }
}
