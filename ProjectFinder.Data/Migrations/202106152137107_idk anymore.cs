namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idkanymore : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Student", "CourseId", "dbo.Course");
            DropIndex("dbo.Student", new[] { "CourseId" });
            DropColumn("dbo.Student", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "CourseId");
            AddForeignKey("dbo.Student", "CourseId", "dbo.Course", "CourseId", cascadeDelete: true);
        }
    }
}
