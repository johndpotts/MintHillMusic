namespace MintHillMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        Difficulty = c.String(),
                        ChordChart = c.String(),
                    })
                .PrimaryKey(t => t.SongID);
            
            AlterColumn("dbo.Reviews", "Contents", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String());
            AlterColumn("dbo.Reviews", "Contents", c => c.String());
            DropTable("dbo.Songs");
        }
    }
}
