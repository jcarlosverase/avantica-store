using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Users.Queries
{
    public interface IUserQuery
    {
        Task<UserDto> GetAsync(string id);
    }
}
