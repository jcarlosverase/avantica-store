using Catalog.Domain.Entities;
using Catalog.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Application.Products.Commands
{
    public class ProductCreateCommandHandler : INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductCreateCommandHandler> _logger;
        public ProductCreateCommandHandler(
            ApplicationDbContext context,
            ILogger<ProductCreateCommandHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(ProductCreateCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- ProductCreateCommand started");

            await _context.AddAsync(new Product
            {
                Name = notification.Name,
                Description = notification.Description,
                Price = notification.Price,
                Stock = notification.Stock
            });

            await _context.SaveChangesAsync();

            _logger.LogInformation($"--- Product {notification.Name} was created");
            _logger.LogInformation("--- ProductCreateCommand ended");
        }

    }
}
