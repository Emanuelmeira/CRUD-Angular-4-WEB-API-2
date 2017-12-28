namespace Easy.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevaluecpf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BANK_INFORMATION", "CPF", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BANK_INFORMATION", "CPF", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
