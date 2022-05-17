// See https://aka.ms/new-console-template for more information
using GithubUserDataApplication;
using Octokit;



var testUsername = "Frolicks"; 
var github = new GitHubClient(new ProductHeaderValue("GithubUserData"));
var userDataLogic = new UserDataLogic(github);


var a = await userDataLogic.GetUserData(testUsername);
Console.WriteLine(a); 