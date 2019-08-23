using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace activity.Models
{
    public class Join
    {
        [Key]
        public int JoinId {get;set;}

        public int UserId {get;set;}
        
        public int ActivityId {get;set;}
        public User User {get;set;}
        public Activity Activity {get;set;}
    }
}