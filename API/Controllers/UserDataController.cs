using GithubUserDataApplication;
using GithubUserDataApplication.Models; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<UserData> GetUserData(string username)
        {
            return await _userDataLogic.GetUserData(username); 
        }
    }
}
