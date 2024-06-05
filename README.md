# FizzBuzz
For running this project after download

Go to FizzBuzzMvcApp folder in command prompt

Run the following commands one after another 
  1. dotnet restore -> to restore dependencies 
  2. dotnet build -> to build the application
  3. dotnet run -> to run the application

For UnitTests

Go to FizzBuzzMvcApp.Tests folder in command prompt

Run the following command
  1. dotnet test - executes and displays unit test results

If there is a conflict with the port with dotnet run command, please change the port in FizzBuzzMVCApp/Properties/launchSettings.json -> section profiles -> http

Please open the browser and use http://localhost:given_port_number/ -> will take to default FizzBizz processor page.

Working screenshot can be found with file name FizzBizz_Working.png in the repo

Note: This has been developed with ASP.NET MVC. UI can be be developed independently using angular or react or anyother javascript framework.
