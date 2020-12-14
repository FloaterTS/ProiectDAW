namespace ProiectDAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyPackageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyPackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyPackageName = c.String(nullable: false),
                        BuyPackagePrice = c.Int(nullable: false),
                        BuyPackageDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BuyPackages");
        }
    }
}
