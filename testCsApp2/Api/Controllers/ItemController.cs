using testCsApp2.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using testCsApp2.Domain.Entities;
using testCsApp2.Application.DTOs;

namespace testCsApp2.Api.Controllers
{   
    [ApiController]
    [Route("api/v1/item")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("{id:guid}")]
        public Item GetItem(Guid id)
        {
            return _itemService.GetItem(id);
        }
        [HttpPost]
        public Item CreateItem(ItemRequestDto itemRequest)
        {
            return _itemService.CreateItem(itemRequest);
        }
        [HttpPut]
        public Item UpdateItem(Guid id, ItemRequestDto itemRequest)
        {
            return _itemService.UpdateItem(id, itemRequest);
        }
        [HttpDelete("{id:guid}")]
        public void DeleteItem(Guid id)
        {
            _itemService.DeleteItem(id);
        }
    }
}