using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagement.Backend.Models
{
    public class CreditRequest
    {
        [Key]
        public int RequestId { get; set; }

        [StringLength(50)]
        [Required]
        public string CompanyName { get; set; }
        
        [Required]
        public int CompanyNit { get; set; }

        [Required]
        public int CurrentSalary { get; set; }

        [Required]
        public DateTime AdmissionDateCompany { get; set; }

        [Required]
        public int ClientId { get; set; }
        public virtual BankClient Client { get; set; }

        [StringLength(20)]
        public string CreditStatus { get; set; }

        public int CreditAmount { get; set; }
    }
}