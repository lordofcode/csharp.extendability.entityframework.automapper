using ProductPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProductPortal.Domain.Interfaces
{
    public interface IProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        string Name { get; set; }

        string Image { get; set; }

        [Required]
        DateTime CreateDate { get; set; }

        [Required]
        string CreateUser { get; set; }

        DateTime? ModifiedDate { get; set; }

        string ModifiedUser { get; set; }

        [Required]
        ProductState State { get; set; }

        string InternalNotes { get; set; }
    }
}
