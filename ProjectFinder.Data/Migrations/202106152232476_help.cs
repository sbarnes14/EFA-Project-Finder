namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class help : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Course", "Project_ProjectId", "dbo.Project");
            DropIndex("dbo.Course", new[] { "Project_ProjectId" });
            DropColumn("dbo.Course", "Project_ProjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "Project_ProjectId", c => c.Int());
            CreateIndex("dbo.Course", "Project_ProjectId");
            AddForeignKey("dbo.Course", "Project_ProjectId", "dbo.Project", "ProjectId");
        }
    }
}
