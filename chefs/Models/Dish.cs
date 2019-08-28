using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefs.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        public string Name {get;set;}

        [Required]
        [Range(1, 10000, ErrorMessage="Calories must be greater than 0")]
        public int Calory {get;set;}

        [Required]
        [Range(1, 5, ErrorMessage="Tastiness must be between 1 - 5")]
        public int Tasty {get;set;}

        [Required]
        public string Description {get;set;}

        public int ChefId {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public Chef Creator {get;set;}
    }
}