namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commentinglinesfortesting : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "GithubProfile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "GithubProfile", c => c.String(nullable: false));
        }
    }
}
