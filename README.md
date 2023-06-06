HOW TO RUN:
1. Navigate to my Renew Automation repository: https://github.com/paolopenus22/RenewAutomation
2. Click the '<> Code' button.
3. CLick 'Open with Visual Studio'
4. Select a Path to where you want to save the repository in your local machine (eg. C:\Users\[User Name]\source\repos\RenewAutomation
5. Build and Save the Solution
6. Open Command Prompt
7. Change the directory to the path of the repository (eg. cd C:\Users\[User Name]\source\repos\RenewAutomation)
8. Verify you are in the correct directory
9. Change the directory again to the path of RenewAutomation.dll (eg. cd .\RenewAutomation\bin\Debug\net5.0)
10. Verify you are in the correct directory
11. Type 'dotnet test ./RenewAutomation.dll'


ABOUT THE FRAMEWORK
1. Framework is built using a pattern called Service Object Model. In this pattern, Data Models, Endpoints and Tests are separated to different folders.
2. Data Models folder is where we store the values available in an endpoint (userId, id, title, body, etc.)
3. TestEndpoints folder is where we store the endpoints that will be used for testing
4. Tests folder is specifically for testing the endpoint and using the data models
