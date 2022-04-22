namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Date", c => c.String());
            DropColumn("dbo.Appointments", "dt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "dt", c => c.String());
            DropColumn("dbo.Appointments", "Date");
        }
    }
}
