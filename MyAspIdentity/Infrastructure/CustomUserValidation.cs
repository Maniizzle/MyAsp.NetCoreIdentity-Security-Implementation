using Microsoft.AspNetCore.Identity;
using MyAspIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspIdentity.Infrastructure
{
    public class CustomUserValidation : IUserValidator<MideUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<MideUser> manager, MideUser user)
        {
            if (user.Email.ToLower().EndsWith("@gmail.com"))
            {
                return Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only gmail address are allowed"
                }));
            }

        }
    }
}
