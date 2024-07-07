using ebpearls_api.Data;

namespace ebpearls_api.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
        public string Designation { get; set; }
    }
}
