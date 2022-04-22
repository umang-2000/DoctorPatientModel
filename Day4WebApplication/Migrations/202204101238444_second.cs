namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Date", c => c.String());
            DropColumn("dbo.Appointments", "Dt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Dt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Appointments", "Date");
        }
    }
}
