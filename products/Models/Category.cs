using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products.Models
{
    public class Category
    {
        [Column("id")]
        [Key]
        public int CategoryId {get;set;}

        [Column("category",TypeName="VARCHAR(45)")]
        [Required(ErrorMessage="Category is required")]
        [MinLength(2,ErrorMessage="Category must be 2 characters or more")]
        public string CName {get;set;}

        [Column("created_at")]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Column("updated_at")]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Association> ProAss {get;set;}
    }
}