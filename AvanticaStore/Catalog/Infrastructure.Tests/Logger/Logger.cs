using Catalog.Application.Products.Commands;
using Microsoft.Extensions.Logging;
using Moq;

namespace Catalog.Infrastructure.Tests.ILogger
{
    public class Logger
    {
        public ILogger<ProductCreateCommandHandler> Get
        {
            get
            {
                return new Mock<ILogger<ProductCreateCommandHandler>>()
                    .Object;
            }
        }
    }
}
