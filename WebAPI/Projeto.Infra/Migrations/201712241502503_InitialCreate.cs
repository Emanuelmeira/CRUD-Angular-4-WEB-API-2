namespace Projeto.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANK_INFORMATION",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Bank = c.String(nullable: false, maxLength: 15),
                        Agency = c.String(nullable: false, maxLength: 10),
                        Account = c.String(nullable: false, maxLength: 25),
                        Chain = c.Boolean(nullable: false),
                        Savings = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DEVELOPER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 30),
                        Name = c.String(nullable: false, maxLength: 25),
                        Skype = c.String(nullable: false, maxLength: 15),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Linkedin = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 15),
                        State = c.String(nullable: false, maxLength: 10),
                        Portfolio = c.String(nullable: false, maxLength: 30),
                        HourUntilFour = c.Boolean(nullable: false),
                        HourFourToSix = c.Boolean(nullable: false),
                        HourFourToEight = c.Boolean(nullable: false),
                        HourAboveEight = c.Boolean(nullable: false),
                        HoursOfWeekend = c.Boolean(nullable: false),
                        MorningPeriod = c.Boolean(nullable: false),
                        AfternoonPeriod = c.Boolean(nullable: false),
                        NightPeriod = c.Boolean(nullable: false),
                        DawnPeriod = c.Boolean(nullable: false),
                        BusinessPeriod = c.Boolean(nullable: false),
                        Pretension = c.Int(nullable: false),
                        Bank = c.String(nullable: false, maxLength: 15),
                        Crud = c.String(nullable: false, maxLength: 30),
                        BankInformationId = c.Int(nullable: false),
                        KnowledgeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BANK_INFORMATION", t => t.BankInformationId, cascadeDelete: true)
                .ForeignKey("dbo.KNOWLED", t => t.KnowledgeId, cascadeDelete: true)
                .Index(t => t.BankInformationId)
                .Index(t => t.KnowledgeId);
            
            CreateTable(
                "dbo.KNOWLED",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ionic = c.Int(nullable: false),
                        Android = c.Int(nullable: false),
                        Ios = c.Int(nullable: false),
                        Html = c.Int(),
                        Css = c.Int(),
                        Bootstrap = c.Int(nullable: false),
                        Jquery = c.Int(nullable: false),
                        AngularJs = c.Int(nullable: false),
                        Java = c.Int(),
                        Aspnet = c.Int(nullable: false),
                        C = c.Int(),
                        Cplusplus = c.Int(),
                        Cake = c.Int(),
                        Django = c.Int(),
                        Majento = c.Int(),
                        Php = c.Int(nullable: false),
                        Wordpress = c.Int(nullable: false),
                        Phyton = c.Int(),
                        Ruby = c.Int(),
                        SqlServer = c.Int(),
                        MySql = c.Int(),
                        Salesforce = c.Int(),
                        Photoshop = c.Int(),
                        Illustrator = c.Int(),
                        Seo = c.Int(),
                        OtherKnowledge = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DEVELOPER", "KnowledgeId", "dbo.KNOWLED");
            DropForeignKey("dbo.DEVELOPER", "BankInformationId", "dbo.BANK_INFORMATION");
            DropIndex("dbo.DEVELOPER", new[] { "KnowledgeId" });
            DropIndex("dbo.DEVELOPER", new[] { "BankInformationId" });
            DropTable("dbo.KNOWLED");
            DropTable("dbo.DEVELOPER");
            DropTable("dbo.BANK_INFORMATION");
        }
    }
}
