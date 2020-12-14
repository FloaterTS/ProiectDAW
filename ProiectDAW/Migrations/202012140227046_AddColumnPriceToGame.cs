namespace ProiectDAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnPriceToGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameModels", "GamePrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameModels", "GamePrice");
        }
    }
}
