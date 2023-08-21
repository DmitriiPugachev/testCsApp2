using testCsApp2.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using testCsApp2.Domain.Entities;

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

        [HttpGet]
        public Item GetItem(Guid Id)
        {
            return _itemService.GetItem(Id);
        }
    }
}