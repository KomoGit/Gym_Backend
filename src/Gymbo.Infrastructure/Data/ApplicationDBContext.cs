using Gymbo.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Gymbo.Infrastructure.Data
{
    public class ApplicationDBContext(IConfiguration _configuration):DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("Default") ?? throw new ConnectionStringNotFoundException());
        }
    }
}
