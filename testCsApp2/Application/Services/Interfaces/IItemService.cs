using testCsApp2.Domain.Entities;
using testCsApp2.Application.DTOs;

namespace testCsApp2.Application.Services.Interfaces
{
    public interface IItemService
    {
        Item GetItem(Guid id);
        Task<Item> CreateItem(ItemRequestDto itemRequest);
        //ItemResponseDto UpdateItem(Guid id, ItemRequestDto itemRequest);
        //void DeleteItem(Guid id);
    }
}