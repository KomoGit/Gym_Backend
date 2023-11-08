using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Do not keep sensitive data here.
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=password1234;database=GymAppDb");
        }
    }
}
