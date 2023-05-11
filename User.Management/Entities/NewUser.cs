using System.ComponentModel.DataAnnotations;

namespace User.Management_Domain.Entities
{
    public class NewUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public int RoleId { get; set; }

    }
}
