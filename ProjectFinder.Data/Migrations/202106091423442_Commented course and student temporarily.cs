namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commentedcourseandstudenttemporarily : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Project", "Student");
            DropColumn("dbo.Project", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "Student", c => c.Int(nullable: false));
        }
    }
}
