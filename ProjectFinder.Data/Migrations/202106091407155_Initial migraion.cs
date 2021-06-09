namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigraion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Project", "Student", c => c.Int(nullable: false));
            DropColumn("dbo.Project", "Students");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "Students", c => c.Int(nullable: false));
            DropColumn("dbo.Project", "Student");
            DropColumn("dbo.Project", "OwnerId");
        }
    }
}
