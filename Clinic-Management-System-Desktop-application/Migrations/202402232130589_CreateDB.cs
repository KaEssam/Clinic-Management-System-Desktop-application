namespace Clinic_Management_System_Desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        AppointmenDate = c.DateTime(nullable: false),
                        StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Staffs", t => t.StaffId)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StaffName = c.String(nullable: false, maxLength: 50),
                        StaffPhone = c.String(nullable: false, maxLength: 11),
                        StaffUserName = c.String(nullable: false),
                        StaffPassword = c.String(nullable: false),
                        StaffRole = c.String(),
                        StaffAddress = c.String(),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(nullable: false, maxLength: 50),
                        PatientPhone = c.String(nullable: false, maxLength: 11),
                        PatientAddress = c.String(nullable: false),
                        PatientGender = c.String(),
                        PatientAge = c.Int(nullable: false),
                        PatientMaritalStatus = c.String(),
                        appointments = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PrescriptionName = c.String(nullable: false, maxLength: 50),
                        PrescriptionType = c.String(nullable: false),
                        PrescriptionNotes = c.String(),
                    })
                .PrimaryKey(t => t.PrescriptionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Patients");
            DropTable("dbo.Staffs");
            DropTable("dbo.Appointments");
        }
    }
}
