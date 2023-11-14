using API.Model;
using API.Model.Blog;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<User> Members { get; set; }

        #region Blog
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        #endregion
        #region Shop Items
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Do not keep sensitive data here.
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=password1234;database=GymAppDb");
        }
    }
}
