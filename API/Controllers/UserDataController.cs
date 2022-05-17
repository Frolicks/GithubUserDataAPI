using GithubUserDataApplication;
using GithubUserDataApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Octokit;
namespace GithubUserDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        private readonly IUserDataLogic _userDataLogic;
        public UserDataController(IUserDataLogic userDataLogic)
        {
            _userDataLogic = userDataLogic;
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<UserData>> GetUserData(string username, bool includeForked = false)
        {
            try
            {
                return await _userDataLogic.GetUserData(username, includeForked);
            }
            catch (ApiValidationException e)
            {
                return new BadRequestObjectResult(e.Message);
            }

        }
    }
}
