namespace MintHillMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Contents = c.String(),
                        ReviewerEmail = c.String(),
                        Instructor_InstructorID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Instructors", t => t.Instructor_InstructorID)
                .Index(t => t.Instructor_InstructorID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.InstructorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Instructor_InstructorID", "dbo.Instructors");
            DropIndex("dbo.Reviews", new[] { "Instructor_InstructorID" });
            DropTable("dbo.Instructors");
            DropTable("dbo.Reviews");
        }
    }
}
