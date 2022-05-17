using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubUserDataApplication.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public int RepoCount { get; set; }
        public int StargazerCount { get; set; }
        public int ForkCount { get; set; }
        public string AverageRepoSize { get; set; }


        //todo sort langauges by usecount
        public IOrderedEnumerable<KeyValuePair<string,int>> Languages { get; set; }

        public UserData(string p_username, int p_repoCount, int p_stargazerCount, int p_forkCount, string p_averageRepoSize, IOrderedEnumerable<KeyValuePair<string, int>> p_languages)
        {
            Username = p_username;
            RepoCount = p_repoCount;
            StargazerCount = p_stargazerCount;
            ForkCount = p_forkCount;
            AverageRepoSize = p_averageRepoSize;
            Languages = p_languages; 
        }

        public override string ToString()
        {
            string output = "Username: {0}\nRepoCount:{1}\nStargazerCount:{2}\nForkCount:{3}\nAverageRepoSize:{4}";
            output = String.Format(output, Username, RepoCount, StargazerCount, ForkCount, AverageRepoSize);

            output += "\nLanguages: "; 
            foreach(KeyValuePair<string, int> entry in Languages)
            {
                output += String.Format("{0} {1}\n", entry.Key, entry.Value); 
            }
            return output; 
        }
    }
}
