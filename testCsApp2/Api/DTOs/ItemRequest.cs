using TestCsApp.Domain.Enums;

namespace TestCsApp.Domain.Contracts
{
    public record ItemRequest
    {
        public string city;
        public DateTime startDate;
        public DateTime endDate;
        public double price;
        public ItemStatuses status;
        public string color;
    }
}