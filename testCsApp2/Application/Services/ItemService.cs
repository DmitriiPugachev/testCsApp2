using testCsApp2.Application.Services.Interfaces;
using testCsApp2.Application.DTOs;
using TestCsApp.Domain.Enums;

namespace testCsApp2.Application.Services
{
    public class ItemService : IItemService
    {
        public ItemResponseDto GetItem(Guid id)
        {
            ItemResponseDto freshItem = new ItemResponseDto()
            {
                id = Guid.NewGuid(),
                city = "city",
                startDate = DateTime.Now,
                endDate = DateTime.Now,
                price = 0.9,
                status = ItemStatuses.YEARLY,
                color = "#f05969"
            };
            return freshItem;
        }
    }
}