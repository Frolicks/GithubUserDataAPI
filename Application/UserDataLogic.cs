using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit; 

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

        public async Task<int> GetRepositoryCount(string username)
        {
            var user = await _gitHubClient.User.Get(username);
            if(user)
                return user.PublicRepos; 
            return -1; 

            //TODO return await github.User.Get("half-ogre");
        }

    }
}
