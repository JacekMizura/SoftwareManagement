namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDetails", "IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.ProductTypes", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDetails", "ProductTypeID", "dbo.ProductTypes");
            DropIndex("dbo.ProductDetails", new[] { "ProductID" });
            DropIndex("dbo.ProductDetails", new[] { "ProductTypeID" });
            DropIndex("dbo.ProductDetails", new[] { "IngredientID" });
            DropIndex("dbo.ProductTypes", new[] { "Product_ProductID" });
            AddColumn("dbo.Products", "Type", c => c.String());
            DropTable("dbo.Ingredients");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.ProductTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        ProductTypeID = c.Int(nullable: false),
                        IngredientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.ProductTypeID, t.IngredientID });
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IngredientID);
            
            DropColumn("dbo.Products", "Type");
            CreateIndex("dbo.ProductTypes", "Product_ProductID");
            CreateIndex("dbo.ProductDetails", "IngredientID");
            CreateIndex("dbo.ProductDetails", "ProductTypeID");
            CreateIndex("dbo.ProductDetails", "ProductID");
            AddForeignKey("dbo.ProductDetails", "ProductTypeID", "dbo.ProductTypes", "ProductTypeID", cascadeDelete: true);
            AddForeignKey("dbo.ProductDetails", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
            AddForeignKey("dbo.ProductTypes", "Product_ProductID", "dbo.Products", "ProductID");
            AddForeignKey("dbo.ProductDetails", "IngredientID", "dbo.Ingredients", "IngredientID", cascadeDelete: true);
        }
    }
}
