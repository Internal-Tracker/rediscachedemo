using rediscachedemoazure.TableStorage.Entity;

namespace rediscachedemoazure.TableStorage.Interface
{
    public interface ITableStorageService
    {
        Task<GroceryItemEntity> GetEntityAsync(string category, string id);
        Task<GroceryItemEntity> UpsertEntityAsync(GroceryItemEntity entity);
        Task DeleteEntityAsync(string category, string id);
    }
}
