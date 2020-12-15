namespace ProiectDAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "ApplicationUserId", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "ApplicationUserId");
        }
    }
}
