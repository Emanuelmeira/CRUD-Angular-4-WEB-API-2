namespace Easy.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TesteMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(nullable: false, maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
