using AutoMapper;
using AutoMapper.QueryableExtensions;
using Identity.Infrastructure.Persistence;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Application.Users.Queries
{
    public class UserQuery : IUserQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserQuery(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string id)
        {
            var user = _context.Users
                                .Where(x => x.Id == id)
                                .ProjectTo<UserDto>(_mapper.ConfigurationProvider)
                                .Single();

            return user;
        }
    }
}
