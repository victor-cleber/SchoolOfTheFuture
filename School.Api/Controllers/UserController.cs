using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Api.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace School.Api.Controllers {

    [Route("api/v1/user")]
    [ApiController]

    public class UserController : ControllerBase {

        /// <summary>
        /// This service allwos to authenticate a user already created
        /// </summary>
        /// <param name="loginViewModelInput">View model to represent a login</param>
        /// <returns> Return a ok status, user data and a authentication token </returns>
        [SwaggerResponse(statusCode: 200, description: "Success authentication", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Inform all fields", Type = typeof(ValidateFieldsViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type= typeof(GenericErrorViewModel))]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult AuthenticateUser(LoginViewModelInput loginViewModelInput) {
            return Ok(loginViewModelInput);
        }

        /// <summary>
        /// Register a new user
        /// </summary>
        /// <param name="registerUserViewModelInput">View model to represent a user</param>
        /// <returns> Return a ok status, user data and a authentication token </returns>
        [SwaggerResponse(statusCode: 200, description: "Success authentication", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Inform all fields", Type = typeof(ValidateFieldsViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [HttpPost]
        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser(RegisterUserViewModelInput registerUserViewModelInput) {
            return Created("", registerUserViewModelInput);
        }
    }
}

