using API.Data;
using API.Model.Blog;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using GraphQL.AspNet.Interfaces.Controllers;


namespace API.Controllers
{
    public class BlogController : GraphController
    {
        private readonly ApplicationDbContext _context;

        public BlogController()
        {
            using (_context = new ApplicationDbContext()) {}
        }

        [Query("blog", typeof(Blog))]
        public IGraphActionResult GetBlog()
        {
            List<Blog>? blogs = _context.Blogs.ToList();
            return Ok(blogs);
        }
    }
}
