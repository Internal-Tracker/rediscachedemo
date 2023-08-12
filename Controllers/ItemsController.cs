using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rediscachedemoazure.TableStorage.Entity;
using rediscachedemoazure.TableStorage.Interface;
using rediscachedemoazure.TableStorage.Service;

namespace rediscachedemoazure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ITableStorageService _tablestorageservice;

        public ItemsController(ITableStorageService tablestorageservice)
        {
                _tablestorageservice = tablestorageservice; 
        }

        [HttpGet]
        [ActionName(nameof(GetAsync))]
        public async Task<IActionResult> GetAsync([FromQuery] string category, string id)
        {
            return Ok(await _tablestorageservice.GetEntityAsync(category, id));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] GroceryItemEntity entity)
        {
            entity.PartitionKey = entity.Category;

            string Id = Guid.NewGuid().ToString();
            entity.Id = Id;
            entity.RowKey = Id;

            var createdEntity = await _tablestorageservice.UpsertEntityAsync(entity);
            return CreatedAtAction(nameof(GetAsync), createdEntity);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] GroceryItemEntity entity)
        {
            entity.PartitionKey = entity.Category;
            entity.RowKey = entity.Id;

            await _tablestorageservice.UpsertEntityAsync(entity);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromQuery] string category, string id)
        {
            await _tablestorageservice.DeleteEntityAsync(category, id);
            return NoContent();
        }

    }
}
