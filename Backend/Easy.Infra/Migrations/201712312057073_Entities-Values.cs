namespace Easy.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitiesValues : DbMigration
    {
        public override void Up()
        {            
            AlterColumn("dbo.BANK_INFORMATION", "Name", c => c.String(maxLength: 30));
            AlterColumn("dbo.BANK_INFORMATION", "CPF", c => c.String(maxLength: 15));
            AlterColumn("dbo.BANK_INFORMATION", "Bank", c => c.String(maxLength: 15));
            AlterColumn("dbo.BANK_INFORMATION", "Agency", c => c.String(maxLength: 10));
            AlterColumn("dbo.BANK_INFORMATION", "Account", c => c.String(maxLength: 25));
            AlterColumn("dbo.DEVELOPER", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DEVELOPER", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DEVELOPER", "Skype", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Phone", c => c.String(maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(maxLength: 50));
            AlterColumn("dbo.DEVELOPER", "Portfolio", c => c.String(maxLength: 50));
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(maxLength: 50));
            AlterColumn("dbo.DEVELOPER", "Crud", c => c.String(maxLength: 50));
            AlterColumn("dbo.KNOWLED", "OtherKnowledge", c => c.String(maxLength: 60));            
        }
        
        public override void Down()
        {
            AddColumn("dbo.DEVELOPER", "HourFourToEight", c => c.Boolean(nullable: false));
            AlterColumn("dbo.KNOWLED", "OtherKnowledge", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.DEVELOPER", "Crud", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Bank", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.DEVELOPER", "Portfolio", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DEVELOPER", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DEVELOPER", "Skype", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.DEVELOPER", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.DEVELOPER", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.BANK_INFORMATION", "Account", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.BANK_INFORMATION", "Agency", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.BANK_INFORMATION", "Bank", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.BANK_INFORMATION", "CPF", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.BANK_INFORMATION", "Name", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.DEVELOPER", "HourSixToEight");
        }
    }
}
