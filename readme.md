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
### Suggested VSCode Extensions  
- [Postman Extension](https://marketplace.visualstudio.com/items?itemName=Postman.postman-for-vscode) - Allows you to run Postman directly in VSCode. (For testing API)  
- [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) - Language support for C#
- [Todo Tree](https://marketplace.visualstudio.com/items?itemName=Gruntfuggly.todo-tree) - Comments with TODO in the text are searchable, allowing you to leave TODOs in your code to fix later.
- [React Snippets](https://marketplace.visualstudio.com/items?itemName=dsznajder.es7-react-js-snippets) - Great boilerplates for creating a new react component quickly.  
---  
### Github Standards  
#### When beginning to work on a Trello ticket  
1. Move to the main branch and pull: 
`git checkout main`  
`git pull`  
2. Create a new branch for your ticket, for example: `git checkout -b making-token-service`  
#### Along the way
1. Create separate commits for files. For example, If you are working on `SomeComponent.jsx` in React:
`git add Client/src/Components/SomeComponent.jsx` (adjust the route accordingly)
`git commit -m "Update something in SomeComponent"`
2. If you make a second change to the same file after committing, there are multiple ways to "squash" this file's commits into one. Please see [squashing commits](#squashing-commits). This step is optional depending on your desire to learn advanced git techs, and Josh is willing to demo and explain these processes.
#### When you are finished working / ready to push
1. Assuming you have been committing along the way, your files should be committed.  
2. `git push -u origin <branch name>`  
3. Click the link in the console to open the pull request page on github.  
4. Fill out the pull request template as much as needed, and add members as "reviewers" in the right.  
5. Reviewers can comment and request changes to your request.  
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
### Api Routes  
#### Register New User: /api/auth/register  
Expected JSON:   
```
{
	"firstName":"Jane",
	"lastName": "Doe",
	"email": "example@mail.com",
	"password":"Password1!",
	"confirm": "Password1!"
}
```
Returned JSON:  
```
{
    "id": 2,
    "firstName": "Jane",
    "lastName": "Doe",
    "email": "example@mail.com"
}
```
#### Login: /api/auth/login  
Expected JSON:  
```
{
    "email":"example@mail.com",
    "password": "Password1!"
}
```
Returned JSON:  (This will be altered based on needed dashboard data)
```
{

    "refreshToken": "WjMSxiBLYViMk6hM1m6eFZ1s37JQAFC70RCX8BvBqsU=",
    "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIiLCJuYmYiOjE2OTY0NTk4MjQsImV4cCI6MTY5NjQ2NzAyNCwiaWF0IjoxNjk2NDU5ODI0LCJpc3MiOiJUZWFtRml2ZSIsImF1ZCI6IkxvY2FsSG9zdCJ9.Z16Wl0J4rKR7n0xA8nSFtU_TN163a9UC9J5GEmn4T4E"
}
```

