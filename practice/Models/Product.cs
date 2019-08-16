using System.ComponentModel.DataAnnotations;

public class Product
{
   [Required]
   [Display(Name="Product Name")]
   public string ProductName {get;set;}

   [Required]
   [Display(Name="Price")]
   public double Price {get;set;}
}