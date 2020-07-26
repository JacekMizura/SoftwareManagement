namespace SoftwareManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductTypes", "Product_ProductID", c => c.Int());
            CreateIndex("dbo.ProductTypes", "Product_ProductID");
            AddForeignKey("dbo.ProductTypes", "Product_ProductID", "dbo.Products", "ProductID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTypes", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.ProductTypes", new[] { "Product_ProductID" });
            DropColumn("dbo.ProductTypes", "Product_ProductID");
        }
    }
}
