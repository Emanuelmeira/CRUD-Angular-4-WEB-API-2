namespace Projeto.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataEF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DEVELOPER", "Linkedin", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
