namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "appointTime", c => c.Int(nullable: false));
            DropColumn("dbo.Appointments", "time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "time", c => c.Int(nullable: false));
            DropColumn("dbo.Appointments", "appointTime");
        }
    }
}
