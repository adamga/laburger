using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace AzureCosmosDBIntegration
{
    public class DatabaseConfig
    {
        private CosmosClient cosmosClient;
        private Database database;
        private Container container;

        public DatabaseConfig(string connectionString, string databaseName, string containerName)
        {
            this.cosmosClient = new CosmosClient(connectionString);
            this.database = this.cosmosClient.GetDatabase(databaseName);
            this.container = this.database.GetContainer(containerName);
        }

        public async Task AddChatMessageAsync(ChatMessage message)
        {
            await this.container.CreateItemAsync(message, new PartitionKey(message.Id));
        }

        public async Task<ChatMessage> GetChatMessageAsync(string id)
        {
            try
            {
                ItemResponse<ChatMessage> response = await this.container.ReadItemAsync<ChatMessage>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }
    }

    public class ChatMessage
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public string SentBy { get; set; }
        public string SentTo { get; set; }
        public string Timestamp { get; set; }
    }
}
