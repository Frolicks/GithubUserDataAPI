using GithubUserDataApplication.Models;

namespace GithubUserDataApplication
{
    public interface IUserDataLogic
    {
        Task<UserData> GetUserData(string username, bool includeForked = false);
    }
}