
using Catalog.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Tests.Persistence
{
    public class ApplicationDbContextInMemory
    {
        public ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                    .UseInMemoryDatabase(databaseName: $"Catalog.Db")
                                    .Options;

            return new ApplicationDbContext(options);
        }
    }
}
