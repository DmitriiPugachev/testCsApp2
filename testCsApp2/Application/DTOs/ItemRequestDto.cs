using testCsApp2.Domain.Enums;

namespace testCsApp2.Application.DTOs
{
    public record ItemRequestDto
    {
        public string city { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double price { get; set; }
        public ItemStatuses status { get; set; }
        public string color { get; set; }
    }
}