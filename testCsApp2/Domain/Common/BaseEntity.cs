using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestCsApp.Domain.Common
{
    [Index("Id", IsUnique = true)]
    public abstract class BaseEntity
    {
        [Key]
        [Column]
        [Required]
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}