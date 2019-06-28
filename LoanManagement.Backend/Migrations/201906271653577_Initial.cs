namespace LoanManagement.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BankClients", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.BankClients", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.BankClients", "Birthdate", c => c.DateTime(nullable: false));
            DropColumn("dbo.BankClients", "ClientFirstName");
            DropColumn("dbo.BankClients", "ClientLastName");
            DropColumn("dbo.BankClients", "ClientBirthdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BankClients", "ClientBirthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BankClients", "ClientLastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.BankClients", "ClientFirstName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.BankClients", "Birthdate");
            DropColumn("dbo.BankClients", "LastName");
            DropColumn("dbo.BankClients", "FirstName");
        }
    }
}
