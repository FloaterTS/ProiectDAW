namespace ProiectDAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGameTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.GameModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GameModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(nullable: false),
                        GameDescription = c.String(nullable: false),
                        GamePrice = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
