using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_aes_data_encrytion.Dto;
using dotnet_core_aes_data_encrytion.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_aes_data_encrytion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ExampleDB _db;
        public UserController(ExampleDB db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            User currentUser = _db.User.FirstOrDefault();

            UserDto userDto = new UserDto();

            userDto.Email = currentUser.Email;
            userDto.FirstName = currentUser.FirstName;
            userDto.LastName = currentUser.LastName;

            return Ok(userDto);
        }

        [HttpPost]
        public IActionResult Post(UserDto userDto)
        {
            User user = new User();

            user.Email = userDto.Email;
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;

            _db.User.Add(user);
            _db.SaveChanges();

            return Ok("Success");
        }
    }
}
