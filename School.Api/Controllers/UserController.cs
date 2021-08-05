using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Api.Models;

namespace School.Api.Controllers {

    [Route("api/v1/user")]
    [ApiController]

    public class UserController : ControllerBase {

        [HttpPost]
        [Route("authenticate")]
        public IActionResult AuthenticateUser(LoginViewModelInput loginViewModelInput) {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser(RegisterUserViewModelInput registerUserViewModelInput) {
            return Created("", registerUserViewModelInput);
        }
    }
}

