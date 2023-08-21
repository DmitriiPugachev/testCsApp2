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
            return _dataContext.Items.Where(item => item.Id == id).First();
        }
        public Item CreateItem(ItemRequestDto itemRequest)
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
            _dataContext.SaveChanges();
            return newItem;
        }
        public Item UpdateItem(Guid id, ItemRequestDto itemRequest)
        {
            Item updatedItem = new Item(
                itemRequest.city,
                itemRequest.startDate,
                itemRequest.endDate,
                itemRequest.price,
                itemRequest.status,
                itemRequest.color
            );
            Item itemToUpdate = _dataContext.Items.Where(item => item.Id == id).First();
            _dataContext.Items.Remove(itemToUpdate);
            _dataContext.Items.Add(updatedItem);
            _dataContext.SaveChanges();
            return updatedItem;
        }
        public void DeleteItem(Guid id)
        {
            Item itemToRemove = _dataContext.Items.Where(item => item.Id == id).First();
            _dataContext.Items.Remove(itemToRemove);
            _dataContext.SaveChanges();
        }
    }
}