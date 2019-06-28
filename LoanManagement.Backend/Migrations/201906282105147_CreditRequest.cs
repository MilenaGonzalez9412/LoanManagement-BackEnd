namespace LoanManagement.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CreditRequests", "CreditAmount", c => c.Int(nullable: false));
            AlterColumn("dbo.CreditRequests", "CreditStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CreditRequests", "CreditStatus", c => c.Int(nullable: false));
            DropColumn("dbo.CreditRequests", "CreditAmount");
        }
    }
}
