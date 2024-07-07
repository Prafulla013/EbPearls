using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ebpearls_api.Data
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
        public string Designation { get; set; }
    }
    public enum UserStatus
    {
        Open = 1,
        Closed = 2
    }
}
