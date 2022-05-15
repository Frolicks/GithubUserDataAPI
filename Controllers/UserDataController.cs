using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GithubUserDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {

        [HttpGet("{username}")]
        public IActionResult GetUserData(string username)
        {
            return Ok("Hello" + username); 
        }
    }
}
