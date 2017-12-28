namespace Easy.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesDeveloper : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DEVELOPER", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DEVELOPER", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DEVELOPER", "Skype", c => c.String(nullable: false, maxLength: 305));
            AlterColumn("dbo.DEVELOPER", "Phone", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.DEVELOPER", "Portfolio", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.DEVELOPER", "Portfolio", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DEVELOPER", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DEVELOPER", "Skype", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.DEVELOPER", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.DEVELOPER", "Email", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
