using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BankAccounts.Models
{
   public class Transactions
   {

        [Key] 
        public int TransactionsId { get; set; }
        public double Amount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User Creator {get;set;}

    }
}