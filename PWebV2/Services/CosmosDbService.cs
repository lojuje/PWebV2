using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using PWebV2.Models;

namespace PWebV2.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }


        public async Task<IEnumerable<Home>> GetItemsAsyncHome(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Home>(new QueryDefinition(queryString));
            List<Home> results = new List<Home>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task<IEnumerable<About>> GetItemsAsyncAbout(string queryString)
        {
            var query = this._container.GetItemQueryIterator<About>(new QueryDefinition(queryString));
            List<About> results = new List<About>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task<IEnumerable<Project>> GetItemsAsyncProject(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Project>(new QueryDefinition(queryString));
            List<Project> results = new List<Project>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task AddItemAsync(Home item)
        {
            await this._container.CreateItemAsync<Home>(item, new PartitionKey(item.Id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<Home>(id, new PartitionKey(id));
        }

        public async Task<Home> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Home> response = await this._container.ReadItemAsync<Home>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task UpdateItemAsync(string id, Home item)
        {
            await this._container.UpsertItemAsync<Home>(item, new PartitionKey(id));
        }
    }
}
