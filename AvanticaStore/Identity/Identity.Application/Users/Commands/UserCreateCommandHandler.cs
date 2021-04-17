using Identity.Application.Users.Commands;
using Identity.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.EventHandlers
{
    public class UserCreateCommandHandler :
        IRequestHandler<UserCreateCommand, IdentityResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserCreateCommandHandler(
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UserCreateCommand notification, CancellationToken cancellationToken)
        {
            var entry = new ApplicationUser
            {
                FirstName = notification.FirstName,
                LastName = notification.LastName,
                Email = notification.Email,
                UserName = notification.Email
            };

            return await _userManager.CreateAsync(entry, notification.Password);
        }
    }
}
