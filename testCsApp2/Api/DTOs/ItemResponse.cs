using TestCsApp.Domain.Enums;

namespace TestCsApp.Domain.Contracts
{
    public record ItemResponse
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