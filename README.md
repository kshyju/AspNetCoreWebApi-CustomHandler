# AspNetCoreWebApi-CustomHandler
Sample app using aspnet core web api as azure functions custom handler web server.

Add `local.settings.json` to root and add below code.

````
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "",
    "FUNCTIONS_WORKER_RUNTIME": "custom",
    "AzureFunctionsJobHost__customHandler__description__defaultExecutablePath": "dotnet",
    "AzureFunctionsJobHost__customHandler__description__workingDirectory": "",
    "AzureFunctionsJobHost__customHandler__description__arguments__0": "run --configuration release --urls=http://localhost:%FUNCTIONS_CUSTOMHANDLER_PORT%"
  }
}
````
To run, execute `func start` on root.

### Endpoints(created on web api):

  - http://localhost:7071/api/time
  - http://localhost:7071/hello
  - http://localhost:7071/foo
