# EFReletionships

This project is a simple ASP.NET Core Web API that uses Azure Key Vault to store secrets.

## Getting Started

To run the project, you will need to have the following installed:

* Visual Studio 2019 or later
* The .NET Core SDK
* The Azure CLI

Once you have the prerequisites installed, you can follow these steps to run the project:

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. In the Solution Explorer, right-click on the project and select "Run".

The project will be started in development mode. You can access the API at `http://localhost:5000/api/`.

## Secrets

The project uses Azure Key Vault to store secrets. The secrets are used to connect to the database.

To configure the project, you will need to create a Key Vault and store the following secrets:

* `EFRelationship:EFRelationshipURL`
* `EFRelationship:TenatId`
* `EFRelationship:ClientId`
* `EFRelationship:ClientSecretId`

Once you have created the secrets, you can configure the project by editing the `appsettings.json` file.

## Swagger

The project uses Swagger to document the API. You can view the documentation at `http://localhost:5000/swagger/`.

## License

The project is licensed under the MIT License.
