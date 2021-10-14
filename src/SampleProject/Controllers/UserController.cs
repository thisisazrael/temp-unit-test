using Microsoft.AspNetCore.Mvc;
using SampleProject.Dtos;
using SampleProject.Services;

namespace SampleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]
        public ActionResult<GetUserResponse> Create()
        {
            var user = _userService.CreateUser();

            return Ok(user);
        }
    }
}
