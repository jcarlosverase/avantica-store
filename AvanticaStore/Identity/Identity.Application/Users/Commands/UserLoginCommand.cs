using Identity.Application.Users.Responses;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Identity.Application.Users.Commands
{
    public class UserLoginCommand : IRequest<IdentityAccess>
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
