using System;
using System.ComponentModel.DataAnnotations;

namespace bankAcct.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}
        public decimal Amount {get;set;} = 0;
        public int UserId {get;set;}
        public DateTime CreatedAt {get;set;}
        public User AcctHolder {get;set;}

    }
}