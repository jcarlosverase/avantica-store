
using Catalog.Application.Products.Commands;
using Catalog.Infrastructure.Persistence;
using Catalog.Infrastructure.Tests.Persistence;
using Catalog.Infrastructure.Tests.ILogger;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System.Threading;

namespace Catalog.Application.Tests.Products.Commands
{
    public class ProductCreateCommandHandlerTest
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductCreateCommandHandler> _logger;

        public ProductCreateCommandHandlerTest()
        {
            _context = new ApplicationDbContextInMemory().Get();
            _logger = new Logger().Get;
        }

        [Test]
        public void TryToCreateProduct()
        {
            //Arrange
            var handler = new ProductCreateCommandHandler(_context, _logger);

            //Act
            handler.Handle(new ProductCreateCommand {
                Name = "New test product",
                Description = "Description for new test product",
                Price = 100.00M,
                Stock = 120
            }, new CancellationToken())
                .Wait();

            //Assert
            Assert.Pass();
        }
    }
}
