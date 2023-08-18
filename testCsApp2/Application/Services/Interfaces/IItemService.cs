using testCsApp2.Application.DTOs;

namespace testCsApp2.Application.Services.Interfaces
{
    public interface IItemService
    {
        ItemResponseDto GetItem(Guid id);
        //ItemResponseDto CreateItem(ItemRequestDto itemRequest);
        //ItemResponseDto UpdateItem(Guid id, ItemRequestDto itemRequest);
        //void DeleteItem(Guid id);
    }
}