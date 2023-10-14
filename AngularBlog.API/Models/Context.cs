using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AngularBlog.API.Models
{
    public class Context:DbContext
    {


        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
      
    }
}
