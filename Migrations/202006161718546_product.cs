namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
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
                        Price = c.String(),
                        ExpireTime = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
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
            DropIndex("dbo.ProductIngredients", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.ProductIngredients", new[] { "Product_ProductID" });
            DropTable("dbo.ProductIngredients");
            DropTable("dbo.Products");
            DropTable("dbo.Ingredients");
        }
    }
}
