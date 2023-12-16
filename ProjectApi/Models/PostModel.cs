using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class PostModel
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public AdminModel Admin { get; set; }
        public CategoryModel Category { get; set; }
        public DateTime DatePublished { get; set; }
        public List<CommentModel> Comments { get; set; } = new List<CommentModel>();
    }
}
