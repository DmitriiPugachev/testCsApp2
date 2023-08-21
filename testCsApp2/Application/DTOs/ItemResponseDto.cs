using testCsApp2.Domain.Enums;

namespace testCsApp2.Application.DTOs
{
    public record ItemResponseDto
    {
        public Guid id;
        public string city;
        public DateTime startDate;
        public DateTime endDate;
        public double price;
        public ItemStatuses status;
        public string color;
    }
}