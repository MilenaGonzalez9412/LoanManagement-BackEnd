namespace LoanManagement.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditRequest1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CreditRequests", "CreditStatus", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CreditRequests", "CreditStatus", c => c.String());
        }
    }
}
