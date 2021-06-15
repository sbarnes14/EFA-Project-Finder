namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Forthebois : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "Project_ProjectId", c => c.Int());
            AddColumn("dbo.Student", "Project_ProjectId", c => c.Int());
            CreateIndex("dbo.Course", "Project_ProjectId");
            CreateIndex("dbo.Student", "Project_ProjectId");
            AddForeignKey("dbo.Course", "Project_ProjectId", "dbo.Project", "ProjectId");
            AddForeignKey("dbo.Student", "Project_ProjectId", "dbo.Project", "ProjectId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "Project_ProjectId", "dbo.Project");
            DropForeignKey("dbo.Course", "Project_ProjectId", "dbo.Project");
            DropIndex("dbo.Student", new[] { "Project_ProjectId" });
            DropIndex("dbo.Course", new[] { "Project_ProjectId" });
            DropColumn("dbo.Student", "Project_ProjectId");
            DropColumn("dbo.Course", "Project_ProjectId");
        }
    }
}
