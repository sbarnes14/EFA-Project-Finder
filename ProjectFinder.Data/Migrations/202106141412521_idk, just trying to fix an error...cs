namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idkjusttryingtofixanerror : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "GithubProfile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "GithubProfile", c => c.String(nullable: false));
        }
    }
}
