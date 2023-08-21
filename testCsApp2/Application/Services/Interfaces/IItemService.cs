using testCsApp2.Domain.Entities;

namespace testCsApp2.Application.Services.Interfaces
{
    public interface IItemService
    {
        Item GetItem(Guid id);
        //ItemResponseDto CreateItem(ItemRequestDto itemRequest);
        //ItemResponseDto UpdateItem(Guid id, ItemRequestDto itemRequest);
        //void DeleteItem(Guid id);
    }
}