using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteSizeLib;
using GithubUserDataApplication.Models;
using Octokit;


namespace GithubUserDataApplication
{
    /// <summary>
    /// This class contains the logic for getting user data from Github and returning UserData objects. 
    /// </summary>
    public class UserDataLogic : IUserDataLogic
    {
        private readonly GitHubClient _gitHubClient;
        public UserDataLogic()
        {
            _gitHubClient = new GitHubClient(new ProductHeaderValue("GithubUserData"));
        }

        public async Task<UserData> GetUserData(string username, bool includeForked = false)
        {
            var repos = await GetRepositoryList(username, includeForked);

            //get repoCount
            int repoCount = repos.Count();

            int totalStarGazers = 0;
            int totalForkCount = 0;
            long totalSize = 0;
            Dictionary<string, int> languages = new Dictionary<string, int>();
            foreach (Repository r in repos)
            {
                totalStarGazers += r.StargazersCount;
                totalForkCount += r.ForksCount;
                totalSize += r.Size;

                if (r.Language != null)
                {
                    int val = 0;
                    languages[r.Language] = languages.TryGetValue(r.Language, out val) ? ++val : 1;
                }

            }


            string avgRepoSize = ByteSize.FromKiloBytes((totalSize / (long)repoCount)).ToString();
            var sortedLanguages = from entry in languages orderby entry.Value descending select entry;
            return new UserData(username, repoCount, totalStarGazers, totalForkCount, avgRepoSize, sortedLanguages);
        }

        private async Task<IEnumerable<Repository>> GetRepositoryList(string username, bool includeForked = false)
        {
            SearchRepositoriesRequest request = new SearchRepositoriesRequest() { User = username };
            if (includeForked)
                request = new SearchRepositoriesRequest() { User = username, Fork = ForkQualifier.IncludeForks };

            var result = await _gitHubClient.Search.SearchRepo(request);
            return result.Items;
        }

    }
}
