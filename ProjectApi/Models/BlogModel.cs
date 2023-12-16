using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class BlogModel
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public List<PostModel> Posts { get; set; } = new List<PostModel>();
    }
}
