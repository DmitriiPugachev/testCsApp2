using testCsApp2.Domain.Enums;

namespace testCsApp2.Application.DTOs
{
    public record ItemRequestDto
    {
        public string city;
        public DateTime startDate;
        public DateTime endDate;
        public double price;
        public ItemStatuses status;
        public string color;
    }
}