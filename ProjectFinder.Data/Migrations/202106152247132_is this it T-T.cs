namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isthisitTT : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Student", "Project_ProjectId", "dbo.Project");
            DropIndex("dbo.Student", new[] { "Project_ProjectId" });
            RenameColumn(table: "dbo.Student", name: "Project_ProjectId", newName: "ProjectId");
            AlterColumn("dbo.Student", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "ProjectId");
            AddForeignKey("dbo.Student", "ProjectId", "dbo.Project", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ProjectId", "dbo.Project");
            DropIndex("dbo.Student", new[] { "ProjectId" });
            AlterColumn("dbo.Student", "ProjectId", c => c.Int());
            RenameColumn(table: "dbo.Student", name: "ProjectId", newName: "Project_ProjectId");
            CreateIndex("dbo.Student", "Project_ProjectId");
            AddForeignKey("dbo.Student", "Project_ProjectId", "dbo.Project", "ProjectId");
        }
    }
}
