using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using testCsApp2.Domain.Common;
using testCsApp2.Domain.Enums;

namespace testCsApp2.Domain.Entities
{
        [Index("City")]
        [Index("StartDate")]
        [Index("EndDate")]
        [Index("Price")]
        [Index("Status")]
    public class Item : BaseEntity
    {
        public Item(
            string city,
            DateTime startDate,
            DateTime endDate,
            double price,
            ItemStatuses status,
            string color
        )
        {
            City = city;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            Status = status;
            Color = color;
        }

        [Column]
        [Required]
        public string City { get; set; }

        [Column]
        [Required]
        public DateTime StartDate { get; set; }

        [Column]
        [Required]
        public DateTime EndDate { get; set; }

        [Column]
        [Required]
        public double Price { get; set; }

        [Column]
        [Required]
        public ItemStatuses Status { get; set; }

        [Column]
        [Required]
        [StringLength(7)]
        public string Color { get; set; }
    }
}