using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class AdminModel { 
    [Key]
    public int AdminId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}
}
