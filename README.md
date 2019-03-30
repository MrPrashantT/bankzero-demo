# BankZero PoC

This Proof-of-concept application is built to demonstrate how Auth0 can achieve BankZero's identity requirements for their online banking platform.

The application is built based on the [ASP.NET Core MVC Quickstart documentation](https://auth0.com/docs/quickstart/webapp/aspnet-core/01-login).

### System Requirements
  - [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/core)

### Running the application
  - Ensure that you have replaced the appsettings.json file with the values for your Auth0 account.
  - Run the application from the command line:

    ```
    dotnet run
    ```
  - Go to http://localhost:3000 in your web browser to view the website.

### BankZero Requirements

| Requirement | Auth0 Feature |
|-------------|---------------|
| Users can sign up with a username / password in the Auth0 DB | [Auth0 Database Connections](https://auth0.com/docs/connections/database/custom-db/create-db-connection) |
  Users who previously signed up can authenticate with username/password| [Auth0 Database Connections](https://auth0.com/docs/connections/database/custom-db/create-db-connection) and [Universal Login](https://auth0.com/docs/universal-login)  |
| The Auth0 Lock sign-in screen has been customized user experience to align with the bank’s brand | [Universal Login Customization](https://auth0.com/docs/universal-login#simple-customization) |
| Users can also log in via Google and another social provider| [Social Connections](https://auth0.com/docs/identityproviders#social) |
| Only users with email domain of “bankzero.com” can login to the application | [Rules - Email Domain Whitelist](https://auth0.com/rules/simple-domain-whitelist)|
| Demonstrate two different users logging in to the demo application withone user assigned to the first role and the second user assigned to the second role. | [Role Based Access Control (RBAC)](https://auth0.com/docs/authorization/concepts/rbac)

