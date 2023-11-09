using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Member> Members { get; set; }

        #region Blog
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<BlogCategory> Categories { get; set; }
        #endregion
        #region Shop Items
        //public DbSet<ItemCategory> ItemCategories { get; set; } 
        //public DbSet<Item> Items { get; set; }
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Do not keep sensitive data here.
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=password1234;database=GymAppDb");
        }
    }
}
