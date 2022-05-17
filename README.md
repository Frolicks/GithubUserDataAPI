# GithubUserDataAPI
WebAPI to retrieve user data from Github. Made with ASP.NET 

Notes:
- Total Repo size doesn't account for shared objects, and thus may be less than actual size: https://stackoverflow.com/questions/8646517/how-can-i-see-the-size-of-a-github-repository-before-cloning-it

 Dependencies: 
 - Octokit Github .NET API https://github.com/octokit
 - ByteSize Utility Class https://github.com/omar/ByteSize


 Bugs: 
 - The second consecutive call to SearchRepo() will have the SearchOptions of the prior call (e.g. If the first call has ExcludeForkedRepos, and the second has IncludeForkedRepos, then the second will still exclude forked repo in its result). 