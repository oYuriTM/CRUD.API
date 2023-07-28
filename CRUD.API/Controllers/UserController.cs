using CRUD.Domain.Dto.Users;
using CRUD.Domain.Interface.Services;
using CRUD.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRegisterDto user) => 
            Ok(await _userService.Create(user));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _userService.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _userService.GetById(id));

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserUpdateDto userIn)
        {
            await _userService.Update(userIn);
            return NoContent();
        }
    }
}
