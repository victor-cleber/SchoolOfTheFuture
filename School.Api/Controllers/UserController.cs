using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Api.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

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
        [ValidateCusomisedModelState]
        public IActionResult AuthenticateUser(LoginViewModelInput loginViewModelInput) {
            ///if (!ModelState.IsValid) {
            ///    return BadRequest(new ValidateFieldsViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            ///}
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
        [ValidateCusomisedModelState]
        public IActionResult RegisterUser(RegisterUserViewModelInput registerUserViewModelInput) {
            ///if (!ModelState.IsValid) {
            ///     return BadRequest(new ValidateFieldsViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            ///}
            return Created("", registerUserViewModelInput);
        }
    }
}

