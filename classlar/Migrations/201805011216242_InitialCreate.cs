namespace classlar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerCode = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        CustomerPhone = c.String(nullable: false, maxLength: 50),
                        CargoNameCode = c.String(nullable: false, maxLength: 50),
                        Loan = c.Double(nullable: false),
                        TotalAmountOfMoney = c.Double(nullable: false),
                        TotalAmountOfNumber = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerCode);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        VendorID = c.Int(nullable: false),
                        CustomerCode = c.Int(nullable: false),
                        ProductID = c.String(nullable: false, maxLength: 50),
                        Color = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Vendor", t => t.VendorID)
                .ForeignKey("dbo.Customer", t => t.CustomerCode)
                .Index(t => t.VendorID)
                .Index(t => t.CustomerCode)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 50),
                        ProductType = c.String(nullable: false, maxLength: 50),
                        Color = c.String(nullable: false, maxLength: 50),
                        LotID = c.Int(nullable: false),
                        BuyPrice = c.Int(nullable: false),
                        VendorID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Lot", t => t.LotID)
                .ForeignKey("dbo.Vendor", t => t.VendorID)
                .Index(t => t.LotID)
                .Index(t => t.VendorID);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        LotID = c.Int(nullable: false),
                        LotType = c.String(nullable: false, maxLength: 50),
                        LotQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LotID);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        StockID = c.Int(nullable: false),
                        ProductID = c.String(nullable: false, maxLength: 50),
                        LotID = c.Int(nullable: false),
                        CountOfProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockID)
                .ForeignKey("dbo.Lot", t => t.LotID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.LotID);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        VendorID = c.Int(nullable: false),
                        VendorName = c.String(nullable: false, maxLength: 50),
                        VendorAddress = c.String(nullable: false, maxLength: 50),
                        VendorEmail = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.VendorID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "CustomerCode", "dbo.Customer");
            DropForeignKey("dbo.Product", "VendorID", "dbo.Vendor");
            DropForeignKey("dbo.Order", "VendorID", "dbo.Vendor");
            DropForeignKey("dbo.Stock", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Order", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Stock", "LotID", "dbo.Lot");
            DropForeignKey("dbo.Product", "LotID", "dbo.Lot");
            DropIndex("dbo.Stock", new[] { "LotID" });
            DropIndex("dbo.Stock", new[] { "ProductID" });
            DropIndex("dbo.Product", new[] { "VendorID" });
            DropIndex("dbo.Product", new[] { "LotID" });
            DropIndex("dbo.Order", new[] { "ProductID" });
            DropIndex("dbo.Order", new[] { "CustomerCode" });
            DropIndex("dbo.Order", new[] { "VendorID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Vendor");
            DropTable("dbo.Stock");
            DropTable("dbo.Lot");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
