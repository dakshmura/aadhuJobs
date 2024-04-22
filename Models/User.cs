using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace aadhu.Models
{

    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]

        [Required(ErrorMessage = "Username is required")]
        public required string Username { get; set; }
        [StringLength(100)]

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }
        [StringLength(100)]

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
      

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public required string ConfirmPassword { get; set; }
        
    }
}