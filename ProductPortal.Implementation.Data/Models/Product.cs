using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Implementation.Data.Models
{
    public class Product : ProductPortal.Data.Models.Product
    {
        private bool? _isBolProduct;
        private bool? _isTradeTrackerProduct;
        public bool? IsBolProduct { get { return _isBolProduct; } set { _isBolProduct = Convert.IsDBNull(value) ? null : value; } }
        public bool? IsTradeTrackerProduct { get { return _isTradeTrackerProduct; } set { _isTradeTrackerProduct = Convert.IsDBNull(value) ? null : value; } }
    }
}
