using ProductPortal.Controller;
using ProductPortal.Domain;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace ProductPortal.Tests
{
    public class ProductPortalTests
    {
        private const string _connectionstring = "connectionstring to DB";


        [Fact]
        public void UserCanRetrieveBaseProducts()
        {
            var dataHandler = new DataHandler(_connectionstring);
            var products = dataHandler.GetProducts();
            var numberOfProducts = products.Count();
            Debug.Assert(numberOfProducts > 0);
        }

        [Fact]
        public void UserCanRetrieveImplementationProducts()
        {
            var controller = new ProductPortalController();
            var products = controller.GetProducts();
            var numberOfProducts = products.Count();
            Debug.Assert(numberOfProducts > 0);
        }

    }
}