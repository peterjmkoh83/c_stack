using Microsoft.EntityFrameworkCore;

namespace prac.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
    }
}