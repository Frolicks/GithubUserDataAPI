# GithubUserDataAPI
WebAPI to retrieve user data from Github. Made with ASP.NET 

Key Features
- Separation of Concerns: Separate projects for API and Application
- Inversion of Control: Dependency injection used to connect the Application to the API 

 Dependencies: 
 - Octokit Github .NET API https://github.com/octokit
 - ByteSize Utility Class https://github.com/omar/ByteSize

Notes:
- Total Repo size doesn't account for shared objects, and thus may be less than actual size: https://stackoverflow.com/questions/8646517/how-can-i-see-the-size-of-a-github-repository-before-cloning-it

 Bugs: 
 - The second consecutive call to SearchRepo() will have the SearchOptions of the prior call (e.g. If the first call has ExcludeForkedRepos, and the second has IncludeForkedRepos, then the second will still exclude forked repo in its result). 