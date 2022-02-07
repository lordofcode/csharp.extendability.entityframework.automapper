using ProductPortal.Domain.Enums;
using ProductPortal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Models
{
    public class Product : IProduct
    {
        public Product() 
        {
            Name = string.Empty;
            Image = string.Empty;
            CreateDate = DateTime.Now;
            CreateUser = string.Empty;
            ModifiedUser = string.Empty;
            InternalNotes = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public ProductState State { get; set; }
        public string InternalNotes { get; set; }
    }
}
