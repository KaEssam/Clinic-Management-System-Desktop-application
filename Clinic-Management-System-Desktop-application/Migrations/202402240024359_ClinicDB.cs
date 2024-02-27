namespace Clinic_Management_System_Desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "done");
        }
    }
}
