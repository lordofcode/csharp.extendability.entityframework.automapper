using ProductPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Interfaces
{
    public interface ICategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public string CreateUser { get; set; }
        
        public DateTime? ModifiedDate { get; set; }

        public string ModifiedUser { get; set; }

        [Required]
        public CategoryState State { get; set; }
    }
}
