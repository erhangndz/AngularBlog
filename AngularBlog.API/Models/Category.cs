using AngularBlog.API.Models;
namespace AngularBlog.API.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Article> Articles { get; set; }
    }

}



