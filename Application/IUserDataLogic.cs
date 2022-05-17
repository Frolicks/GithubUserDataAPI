using GithubUserDataApplication.Models;

namespace GithubUserDataApplication
{
    public interface IUserDataLogic
    {
        /// <summary>
        /// Returns a UserData object that describes a Github user. 
        /// May throw a Octokit.APIValidationException 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="includeForked"></param>
        /// <returns></returns>
        Task<UserData> GetUserData(string username, bool includeForked = false);
    }
}