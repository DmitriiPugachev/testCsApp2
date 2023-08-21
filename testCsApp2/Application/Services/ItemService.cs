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
    }
}