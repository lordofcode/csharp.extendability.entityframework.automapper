using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Implementation.Domain.Models
{
    public class Product : ProductPortal.Domain.Models.Product
    {
        public bool? IsBolProduct { get; set; }
        public bool? IsTradeTrackerProduct { get; set; }
    }
}
