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

        [HttpPost("user")]
        public async Task<IActionResult> RegisterUserAsync([FromForm] RegisterUserRequest user)
        {
            var result = await this.userService.RegisterUserAsync(user);
            if(result != null)
            {
                return Ok();
            }
            return BadRequest("Error");
        }
    }
}
