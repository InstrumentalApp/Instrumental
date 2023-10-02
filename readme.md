# TeamFiveApp

 - [Installation and Setup](#installation-and-setup)  
 - [Suggested VSCode Extensions](#suggested-vscode-extensions)
---  
### Installation and Setup  
#### Dependencies  
1. Dotnet 7 SDK: https://dotnet.microsoft.com/en-us/download  
2. Install Ef Core Tool Globally on your system: `dotnet tool install --global dotnet-ef`  
3. NodeJS for your OS/System: https://nodejs.org/en  
4. Install MySQL Workbench/MySQL server
#### Project Initialization  
1. Clone this repository to your system and navigate to it using your console:  `cd TeamFiveApp`  
2. Copy and rename `appsettings.Secrets.json.EXAMPLE` to `appsettings.Secrets.json` and configure the DB connection string to your local DB credentials.  
3. CD into the Api: `cd Api/`
4. Run `dotnet restore` to install dotnet project dependencies.  
5. Run `dotnet ef database update` to build the database. 
6. Run `dotnet watch run` to run the backend API on localhost:5000.  
7. In another console, `cd Client/`  
8. Run `npm run dev` to start the frontend DEV server.  
9. Navigate to http://localhost:8000/ on your browser.  
10. You should see the react app.  
---  
### Suggested VSCode Extensions  
- [Postman Extension](https://marketplace.visualstudio.com/items?itemName=Postman.postman-for-vscode) - Allows you to run Postman directly in VSCode. (For testing API)  
- [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) - Language support for C#
- [Todo Tree](https://marketplace.visualstudio.com/items?itemName=Gruntfuggly.todo-tree) - Comments with TODO in the text are searchable, allowing you to leave TODOs in your code to fix later.
- [React Snippets](https://marketplace.visualstudio.com/items?itemName=dsznajder.es7-react-js-snippets) - Great boilerplates for creating a new react component quickly.  