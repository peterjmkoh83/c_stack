using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace chefs.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        
        [Required]
        public string FirstName {get;set;}
        
        [Required]
        public string LastName {get;set;}
        
        [Required]
        public DateTime DOB {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Dish> CookedDishes {get;set;}
        
    }
}