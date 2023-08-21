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
        public async Task<Item> CreateItem(ItemRequestDto itemRequest)
        {
            return await _itemService.CreateItem(itemRequest);
        }
    }
}