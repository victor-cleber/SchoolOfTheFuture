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

        /// <summary>
        /// Authenticate a user
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns code="200"></returns>
        [HttpPost]
        [Route("authenticate")]
        public IActionResult AuthenticateUser(LoginViewModelInput loginViewModelInput) {
            return Ok(loginViewModelInput);
        }

        /// <summary>
        /// Register a new user
        /// </summary>
        /// <param name="registerUserViewModelInput"></param>
        /// <returns code="201"></returns>
        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser(RegisterUserViewModelInput registerUserViewModelInput) {
            return Created("", registerUserViewModelInput);
        }
    }
}

