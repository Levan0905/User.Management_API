namespace User.Management_Domain.Models
{
    public class AddUserRole_Request
    {
        public string UserName { get; set; } =  string.Empty;
        public string RoleName { get; set; } = string.Empty;
    }
}
