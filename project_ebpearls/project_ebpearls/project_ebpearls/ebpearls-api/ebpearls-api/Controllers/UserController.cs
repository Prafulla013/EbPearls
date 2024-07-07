using Ctara.Infrastructure.Common.Handlers;
using ebpearls_api.Interfaces;
using ebpearls_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ebpearls_api.Controllers
{
    [AdminAccess]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserModel command)
        {
            var response = await _user.AddUser(command);
            return Ok(response);
        }

        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserModel>), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var response = await _user.GetUsers();
            return Ok(response);
        }
    }
}
