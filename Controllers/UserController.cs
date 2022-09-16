using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AIDA_API.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using AIDA_API.Models;

namespace AIDA_API.Controllers
{
    [Route("AIDA_API/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        private readonly UserContext _userContext;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUsers(int id)
        {
            return await _userRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUsers([FromBody] User user)
        {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(GetUsers),new {id=newUser.user_id}, newUser);
        }

        [HttpPut]
        public async Task<ActionResult> PutUsers(int id, [FromBody] User user)
        {
            if (id != user.user_id)
                return BadRequest();

            await _userRepository.Update(user);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var userToDelete = await _userRepository.Get(id);
            if (userToDelete == null)
                return NotFound();

            await _userRepository.Delete(userToDelete.user_id);
            return NoContent();
        }
    }
}
