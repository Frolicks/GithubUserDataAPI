using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GithubUserDataApplication.Models;
using Octokit;

//TODO -total repository count,
// total stargazers for all repos,
// total fork count for all repos,
// average size of a repo,
// list of languages with their counts sorted by usage
namespace GithubUserDataApplication
{
    /// <summary>
    /// This class contains the logic for getting user data from Github and returning UserData objects. 
    /// </summary>
    internal class UserDataLogic
    {
        private readonly GitHubClient _gitHubClient;
        public UserDataLogic(GitHubClient client)
        {
            _gitHubClient = client;  
        }

        public async Task<UserData> GetUserData(string username)
        {
            var repos = await GetRepositoryList(username);

            //get repoCount
            int repoCount = repos.Count();

            int totalStarGazers = 0;
            int totalForkCount = 0; 
            long totalSize = 0; 
            Dictionary<string, int> languages = new Dictionary<string, int>(); 
            foreach(Repository r in repos)
            {
                totalStarGazers += r.StargazersCount;
                totalForkCount += r.ForksCount;
                totalSize += r.Size; 
            }

            long avgRepoSize = totalSize / (long)repoCount;

            return new UserData(username, repoCount, totalStarGazers, totalForkCount, avgRepoSize, languages); 
        }

        /// <summary>
        /// TODO include forked 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Repository>> GetRepositoryList(string username)
        {
            var request = new SearchRepositoriesRequest()
            {
                User = username
            };
            var result = await _gitHubClient.Search.SearchRepo(request);
            return result.Items; 
        }

    }
}
