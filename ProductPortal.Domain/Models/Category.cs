using ProductPortal.Domain.Enums;
using ProductPortal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Models
{
    public class Category : ICategory
    {
        public Category() 
        {
            Name = string.Empty;
            CreateDate = DateTime.Now;
            CreateUser = string.Empty;
            ModifiedUser = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public CategoryState State { get; set; }
    }
}
