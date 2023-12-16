using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
    }
}
