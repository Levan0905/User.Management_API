using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Management_Domain.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string RoleName { get; set; } = string.Empty;
        public List<NewUser>? Users { get; set; }
    }
}
