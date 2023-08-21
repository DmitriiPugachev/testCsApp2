using testCsApp2.Application.DTOs;
using testCsApp2.Application.Services.Interfaces;
using testCsApp2.Domain.Entities;
using testCsApp2.Infrastructure.Persistence;

namespace testCsApp2.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly DataContext _dataContext;

        public ItemService (DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Item GetItem(Guid id)
        {
            Item dbItem = _dataContext.Items.Where(item => item.Id == id).First();
            return dbItem;
        }
        public async Task<Item> CreateItem(ItemRequestDto itemRequest)
        {
            Item newItem = new Item(
                itemRequest.city,
                itemRequest.startDate,
                itemRequest.endDate,
                itemRequest.price,
                itemRequest.status,
                itemRequest.color
            );
            _dataContext.Items.Add(newItem);
            await _dataContext.SaveChangesAsync();
            return newItem;
        }
    }
}