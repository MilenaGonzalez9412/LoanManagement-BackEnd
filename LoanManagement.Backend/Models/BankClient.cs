using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagement.Backend.Models
{
    public class BankClient
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public int DocNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
    }
}