# Big Health Code Take Home Assignment Instructions

## Pre-requisites to running tests
- Need Chromedriver installed on the computer (https://chromedriver.chromium.org/)
- Ideally have Visual Studio 2019 installed, if not, that the dotnet command line language
- With Visual Studio, have the Specflow extension installed
- .NET Core 3.1 installed (https://dotnet.microsoft.com/download/dotnet-core/3.1)

## To run the automated tests

### If using Visual Studio (recommended way)
- Open the test solution, 
- Restore the nuget packages
- Build the test solution
- From the Test Explorer, right click on the tests and click `Run all`
- The tests should run and an instance of the Chrome Driver should pop up

### If using the dotnet CLI
- Open the command prompt at the root of the folder containing the test solution
- Run the command `dotnet test`
- Test should start running, there are five total
