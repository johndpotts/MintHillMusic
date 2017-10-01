namespace MintHillMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class another : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Instructor_InstructorID", "dbo.Instructors");
            DropIndex("dbo.Reviews", new[] { "Instructor_InstructorID" });
            RenameColumn(table: "dbo.Reviews", name: "Instructor_InstructorID", newName: "InstructorID");
            AlterColumn("dbo.Reviews", "InstructorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "InstructorID");
            AddForeignKey("dbo.Reviews", "InstructorID", "dbo.Instructors", "InstructorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "InstructorID", "dbo.Instructors");
            DropIndex("dbo.Reviews", new[] { "InstructorID" });
            AlterColumn("dbo.Reviews", "InstructorID", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "InstructorID", newName: "Instructor_InstructorID");
            CreateIndex("dbo.Reviews", "Instructor_InstructorID");
            AddForeignKey("dbo.Reviews", "Instructor_InstructorID", "dbo.Instructors", "InstructorID");
        }
    }
}
