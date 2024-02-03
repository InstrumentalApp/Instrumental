# Instrumental

![ezgif com-video-to-gif (2)](https://github.com/InstrumentalApp/Instrumental/assets/69173728/5c271db9-91f0-4660-9940-399e561e23b4)

 - [Installation and Setup](#installation-and-setup)  
 - [Suggested VSCode Extensions](#suggested-vscode-extensions)
 - [Github Standards](#github-standards)
 - [Squashing Commits](#squashing-commits)
 - [Updating a Pull Request](#updating-a-pull-request)
 - [Api Routes](#api-routes)
---  
### Installation and Setup  
#### Dependencies  
1. Dotnet 7 SDK: https://dotnet.microsoft.com/en-us/download  
2. Install Ef Core Tool Globally on your system: `dotnet tool install --global dotnet-ef`  
3. NodeJS for your OS/System: https://nodejs.org/en  
4. Install MySQL Workbench/MySQL server
#### Project Initialization  
1. Clone this repository to your system and navigate to it using your console:  `cd Instrumental`
2.  CD into the Api: `cd Api/`  
3. Copy and rename `appsettings.Secrets.json.EXAMPLE` to `appsettings.Secrets.json` and configure the DB connection string to your local DB credentials.    
4. Run `dotnet restore` to install dotnet project dependencies.  
5. Run `dotnet ef database update` to build the database. 
6. Run `dotnet watch run` to run the backend API on localhost:5000.  
7. In another console, `cd Client/`
8. Run `npm i` to install frontend dependencies.
9. Run `npm run dev` to start the frontend DEV server.  
10. Navigate to http://localhost:8000/hello on your browser.  
11. You should see the react app.  
---  
### Github Standards  
#### When beginning to work on a Jira ticket  
1. Move to the main branch and pull: 
`git checkout main`  
`git pull`  
2. Create a new branch named after your Jira Ticket Number, for example `git checkout -b IB-22` for ticket number IB-22.  
#### If changes are requested to your pull request
1. Please see [updating a pull request](#updating-a-pull-request)  
---  
### Squashing Commits  

(TBD)  

---  
### Updating a Pull Request  
If you make a pull request and your reviewers request changes to your code before merging:  
1. Go back to the branch you worked on for this Trello ticket/ pull request:  
`git checkout <branch name>`  
2. Create additional changes.  
3. Add your changes and commit them. Optionally, [squash them](#squashing-commits) as well.  
4. If you did not squash, `git push` will update your pull request with the new changes.  
5. If you DID squash, you must use `git push --force` to update your request.  
6. Await further review of your code!  
---
