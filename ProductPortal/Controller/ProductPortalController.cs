using ProductPortal.Implementation.Domain;
using ProductPortal.Implementation.Domain.Models;
using ProductPortal.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product = ProductPortal.Implementation.Domain.Models.Product;

namespace ProductPortal.Controller
{
    public class ProductPortalController
    {
        public List<Product> GetProducts()
        {
            var dataHandler = new DataHandler(DatabaseHelper.GetConnectionString());
            return dataHandler.GetProducts<Implementation.Data.Models.Product, Product>();
        }

    }
}
