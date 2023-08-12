using Azure.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using rediscachedemoazure.TableStorage.Entity;
using rediscachedemoazure.TableStorage.Interface;

namespace rediscachedemoazure.TableStorage.Service
{
    public class TableStorageService : ITableStorageService
    {
        private const string _tableName = "Item";
        private readonly IConfiguration _configuration;

        public TableStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">partition key</param>
        /// <param name="id">row key</param>
        /// <returns></returns>
        public async Task DeleteEntityAsync(string category, string id)
        {
           var tableclient =await GetTableClient();  
           var rs= await tableclient.DeleteEntityAsync(category, id);
            return;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">this is partition for grouping of rows</param>
        /// <param name="id">this is key for each row</param>
        /// <returns></returns>
        public async Task<GroceryItemEntity> GetEntityAsync(string category, string id)
        {
            var tableclient = await GetTableClient();
            return await tableclient.GetEntityAsync<GroceryItemEntity>(category, id);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity">entity to insert. if not exist create new or else update the existing one</param>
        /// <returns></returns>
        public async Task<GroceryItemEntity> UpsertEntityAsync(GroceryItemEntity entity)
        {
            var tableclient = await GetTableClient(); 
           var res = await tableclient.UpsertEntityAsync(entity);
            return entity;

            
        }

        private async Task<TableClient> GetTableClient()
        {
            var serviceClient = new TableServiceClient(_configuration["StorageConnectionString"]);

            var tableClient = serviceClient.GetTableClient(_tableName);
            await tableClient.CreateIfNotExistsAsync();
            return tableClient;
        }
    }
}
