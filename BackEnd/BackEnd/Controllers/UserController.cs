using BackEnd.Data.Models;
using BackEnd.Services;
using BackEnd.Services.Abstraction;
using BackEnd.Services.Requests;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("get/all")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var result = await this.userService.GetUsersAsync();
            return Ok(result);
        }
        [HttpGet("get/user")]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            var result = await this.userService.GetUserByIdAsync(id);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest("User dont exist");
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUserAsync([FromForm] RegisterUserRequest user)
        {

            var result = await this.userService.RegisterUserAsync(user);
            if(result != null)
            {
                return Ok();
            }
            return BadRequest("Error");
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginUserAsync([FromBody] LoginUserRequest user)
        {
            var result = await this.userService.LoginUserAsync(user);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest("User Dont exist");
        }
    }
}
