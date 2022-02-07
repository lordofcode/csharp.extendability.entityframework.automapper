using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Data.Models
{
    public class Category
    {
        public Category() 
        {
            Name = string.Empty;
            CreateDate = DateTime.Now;
            CreateUser = string.Empty;
            ModifiedUser = string.Empty;
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public string CreateUser { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedUser { get; set; }

        [Required]
        public int State { get; set; }
    }
}
