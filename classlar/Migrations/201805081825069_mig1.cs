namespace classlar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "SellPrice", c => c.Single(nullable: false));
            AddColumn("dbo.Order", "ProductCound", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order", "ProductCound");
            DropColumn("dbo.Order", "SellPrice");
        }
    }
}
