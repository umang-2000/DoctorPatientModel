namespace Day4WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sch = c.String(),
                        docID = c.Int(nullable: false),
                        timeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Doctors", t => t.docID, cascadeDelete: true)
                .Index(t => t.docID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "docID", "dbo.Doctors");
            DropIndex("dbo.Schedules", new[] { "docID" });
            DropTable("dbo.Schedules");
        }
    }
}
