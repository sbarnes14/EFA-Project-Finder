namespace ProjectFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatetimeoffsettodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "EnrollDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "EnrollDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
