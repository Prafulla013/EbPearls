using ebpearls_api.Models;

namespace ebpearls_api.Interfaces
{
    public interface IUser
    {
        Task<List<UserModel>> GetUsers();
        Task<bool> AddUser(UserModel user);
    }
}
