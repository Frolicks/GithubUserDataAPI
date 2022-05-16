// See https://aka.ms/new-console-template for more information
using GithubUserDataApplication;
using Octokit;



var github = new GitHubClient(new ProductHeaderValue("GithubUserData"));
var userDataLogic = new UserDataLogic(github); 
//TODO figure out how to get int from get repositroy count (task))
Console.WriteLine(userDataLogic.GetRepositoryCount("Frolicks")); 
