using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wedding_planner.Models
{
   public class Wedding
   {
      [Key]
      public int WeddingId {get;set;}

      public int UserId {get;set;}

      [Required (ErrorMessage="Please enter Wedder One's name")]
      [MinLength (2, ErrorMessage="Wedder One needs to be at least 2 characters")]
      public string WedderOne {get;set;}

      [Required (ErrorMessage="Please enter Wedder Two's name")]
      [MinLength (2, ErrorMessage="Wedder Two needs to be at least 2 characters")]
      public string WedderTwo {get;set;}

      [Required (ErrorMessage="Please provide Date for this Wedding")]
      public DateTime? Date {get;set;} 

      [Required (ErrorMessage="Plase provide address for this Wedding")]
      [MinLength (2, ErrorMessage="The address needs to be at least 2 characters")]
      public string WeddingAddress {get;set;}

      public DateTime CreatedAt {get;set;} = DateTime.Now;
      public DateTime UpdatedAt {get;set;} = DateTime.Now;

      public User weddingCreator {get;set;}
      public List<RSVP> guestList {get;set;}

   }
}