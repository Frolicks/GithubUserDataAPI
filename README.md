# GithubUserDataAPI
<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <p align="center">
    A Web API to get a Github User's stats in JSON format. Stats include total repositories, stargazers, forks; as well as average repo size and popular languages. 
    <br />
    <a href="https://github.com/Frolicks/GithubUserDataAPI">View Demo</a>
    ·
    <a href="https://github.com/Frolicks/GithubUserDataAPI/issues">Report Bug</a>
  </p>
</div>

<!-- ABOUT THE PROJECT -->
## About The Project

This Web API was created as a take home assignment for a Software Developer Internship application. 

Key Features
- Separation of Concerns: Separate projects for API and Application
- Inversion of Control: Dependency injection used to connect the Application to the API 

Constraints:
- Total Repo size doesn't account for shared objects, and thus may be less than actual size: https://stackoverflow.com/questions/8646517/how-can-i-see-the-size-of-a-github-repository-before-cloning-it
- The second consecutive call to SearchRepo() will have the SearchOptions of the prior call (e.g. If the first call has ExcludeForkedRepos, and the second has IncludeForkedRepos, then the second will still exclude forked repo in its result). 


<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [ASP.net](https://dotnet.microsoft.com/en-us/apps/aspnet)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these steps:

### Prerequisites

* [.net SDK 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) 

### Installation and Usage
 1. Clone the repo
   ```sh
   git clone https://github.com/Frolicks/GithubUserDataAPI.git
   ```

   2. From the API folder directory, run 
   ```sh
   dotnet watch run
   ```
<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Request URL: localhost:{PORT}/api/UserData/Frolicks?includeForked=false

Curl: 
```
curl -X 'GET' \
  'https://localhost:{PORT}/api/UserData/Frolicks?includeForked=false' \
  -H 'accept: text/plain'

```
<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Add front end with React 
- [ ] Host on Microsoft Azure

See the [open issues](https://github.com/Frolicks/GithubUserDataAPI/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Evan Cheng - EvanCheng42@gmail.com

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

 - Octokit Github .NET API https://github.com/octokit
 - ByteSize Utility Class https://github.com/omar/ByteSize
 - othneildrew's Readme Template 'https://github.com/othneildrew/Best-README-Template

<p align="right">(<a href="#top">back to top</a>)</p>





