# laburger

This repository now includes a comprehensive solution for a chat application, featuring a Node.js chat client front end, a .NET Core API server for handling calls, and an Azure Cosmos DB database integration for storing chat history.

## Components

### Node.js Chat Client Front End
The `nodejs-chat-client/` directory contains the front end of the chat client implemented using Node.js. It is responsible for the user interface and the real-time communication with the .NET Core API server.

### .NET Core API Server
The `.NETCoreAPI/` directory houses the .NET Core API server files. This server handles calls from the Node.js chat client, managing the sending and receiving of messages.

### Azure Cosmos DB Database Integration
Files for integrating with Azure Cosmos DB for storing chat history can be found in the `AzureCosmosDBIntegration/` directory. This setup ensures that chat history is persistently stored and can be retrieved as needed.

## Setup Instructions

To set up each component of the chat application, follow the instructions provided in the respective directories. Each directory contains a README.md file with detailed setup steps.

- For the Node.js chat client front end, see `nodejs-chat-client/README.md`.
- For the .NET Core API server, refer to `.NETCoreAPI/README.md`.
- For the Azure Cosmos DB database integration, consult `AzureCosmosDBIntegration/README.md`.
