using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace activity.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId {get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Title must be 2 characters or more")]
        public string Title {get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Description must be 2 characters or more")]
        [MaxLength(50,ErrorMessage="Description must be less than 50 characters")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Join> joinGuests {get;set;}
    }
}