using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Management_Domain.Entities
{
    public class NewUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [Column(TypeName = "nvarchar(100)")]       
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DisplayName("User Name")]
        [Column(TypeName="nvarchar(100)")]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; } = string.Empty;
        
        public List<Role>? Roles { get; set; } 
        public DateTime Date { get; set; }

    }
}
