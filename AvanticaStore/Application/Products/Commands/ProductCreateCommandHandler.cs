using Domain.Entities;
using Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Commands
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

        public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- ProductCreateCommand started");

            await _context.AddAsync(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Stock = command.Stock
            });

            await _context.SaveChangesAsync();

            _logger.LogInformation($"--- Product {command.Name} was created");
            _logger.LogInformation("--- ProductCreateCommand ended");
        }

    }
}
