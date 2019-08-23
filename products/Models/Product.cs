using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        public int ProductId {get;set;}
        
        [Column("first_name", TypeName="VARCHAR(45)")]
        [Required(ErrorMessage="Product name cannot be empty")]
        [MinLength(2,ErrorMessage="Product name must be 2 characters or more")]
        public string Name {get;set;}

        [Column("description",TypeName="VARCHAR(255)")]
        [Required(ErrorMessage="Description cannot be empty")]
        [MinLength(2,ErrorMessage="Description must be 2 characters or more")]
        public string Description {get;set;}
        
        [Column("price", TypeName="DECIMAL")]
        [Required(ErrorMessage="Price cannot be empty")]
        [Price]
        public decimal? Price {get;set;}

        [Column("created_at")]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Column("updated_at")]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Association> CatAss {get;set;}

    }

    public class PriceAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || (decimal)value < 0)
                return new ValidationResult("Price cannot be negative");
            return ValidationResult.Success;
        }
    }
}