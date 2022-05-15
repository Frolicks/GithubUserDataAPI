// See https://aka.ms/new-console-template for more information
using GithubUserDataApplication;
using Octokit;



var github = new GitHubClient(new ProductHeaderValue("GithubUserData"));
var userDataLogic = new UserDataLogic(github); 
