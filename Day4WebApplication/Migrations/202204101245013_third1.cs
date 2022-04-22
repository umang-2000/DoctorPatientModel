namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "allergies", c => c.String());
            DropColumn("dbo.Patients", "disease");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "disease", c => c.String());
            DropColumn("dbo.Patients", "allergies");
        }
    }
}
