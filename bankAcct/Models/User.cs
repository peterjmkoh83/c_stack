using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bankAcct.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "First name needs to be at least 2 characters") ]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Last name needs to be at least 2 characters")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password needs to be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [NotMapped]
        [Required(ErrorMessage = "Cofirm Password is required")]
        [Compare("Password", ErrorMessage= "Passwords do not match")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Transaction> Transactions {get;set;}

        

    }

    
}