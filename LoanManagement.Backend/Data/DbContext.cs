using LoanManagement.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoanManagement.Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
         base("LoanManagement")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<BankClient> BankClient { get; set; }

        public DbSet<CreditRequest> CreditRequest { get; set; }
    }
}