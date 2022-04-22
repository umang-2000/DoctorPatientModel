namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Appointments", "PatientID");
            CreateIndex("dbo.Appointments", "DoctorID");
            AddForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors", "id", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "PatientID", "dbo.Patients", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "DoctorID" });
            DropIndex("dbo.Appointments", new[] { "PatientID" });
        }
    }
}
