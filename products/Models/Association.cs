using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products.Models
{
    public class Association
    {
        [Key]
        [Column("id")]
        public int AssociationId {get;set;}

        [Column("product_id")]
        public int ProductId {get;set;}
        
        [Column("category_id")]
        public int CategoryId {get;set;}
        public Product Product {get;set;}
        public Category Category {get;set;}
    }
}