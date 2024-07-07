using ebpearls_api.Data;
using ebpearls_api.Interfaces;
using ebpearls_api.Models;
using Microsoft.EntityFrameworkCore;

namespace ebpearls_api.Services
{
    public class UserServices : IUser
    {
        private readonly AppDbContext _dbContext;

        public UserServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddUser(UserModel user)
        {
            _dbContext.Users.Add(new User
            {
                Name = user.Name,
                Age = user.Age,
                PhoneNumber = user.PhoneNumber,
                Status = user.Status,
                Designation = user.Designation
            });
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<UserModel>> GetUsers()
        {
            var user = await _dbContext.Users.Select(s => new UserModel
            {
                Name = s.Name,
                Age = s.Age,
                PhoneNumber = s.PhoneNumber,
                Status = s.Status,
                Designation = s.Designation
            }).ToListAsync();
            return user;
        }
    }
}
