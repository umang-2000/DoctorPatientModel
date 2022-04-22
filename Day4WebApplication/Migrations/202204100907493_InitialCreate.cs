namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        DoctorID = c.Int(nullable: false),
                        Dt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        speciality = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        allergies = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
