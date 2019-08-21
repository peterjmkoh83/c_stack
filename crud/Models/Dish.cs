using System;
using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
   public class Dish
   {
      [Key]
      public int DishId {get;set;}

      [Required(ErrorMessage="Dish Name must be provided")]
      public string Name {get;set;}

      [Required(ErrorMessage="Chef Name must be provided")]
      public string Chef {get;set;}

      [Required(ErrorMessage="Please provide rating for Tastiness")]
      [Range(1, 6, ErrorMessage="Rating must be between 1 to 5")]
      public int Tastiness {get;set;}

      [Required(ErrorMessage="Please provide amount of Calories")]
      [Range(1,10000)]
      public int Calories {get;set;}

      [Required]
      public string Description {get;set;}
      public DateTime CreatedAt = DateTime.Now;
      public DateTime UpdatedAt = DateTime.Now;

   }
}