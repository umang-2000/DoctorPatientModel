namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "time", c => c.Int(nullable: false));
            AlterColumn("dbo.Appointments", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "Date", c => c.String());
            DropColumn("dbo.Appointments", "time");
        }
    }
}
