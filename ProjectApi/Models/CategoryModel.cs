using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
