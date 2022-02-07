using ProductPortal.Domain.Enums;
using ProductPortal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Models
{
    public class CategoryProduct
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public ICategory? Category { get; set; }

        [Required]
        public IProduct? Product { get; set; }

        public bool Sticky { get; set; }

        public int? Position { get; set; }

        [Required]
        public ProductInCategoryState State { get; set; }
    }
}
