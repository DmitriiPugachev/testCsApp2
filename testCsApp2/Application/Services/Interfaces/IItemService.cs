using testCsApp2.Domain.Entities;
using testCsApp2.Application.DTOs;

namespace testCsApp2.Application.Services.Interfaces
{
    public interface IItemService
    {
        Item GetItem(Guid id);
        Item CreateItem(ItemRequestDto itemRequest);
        Item UpdateItem(Guid id, ItemRequestDto itemRequest);
        void DeleteItem(Guid id);
    }
}