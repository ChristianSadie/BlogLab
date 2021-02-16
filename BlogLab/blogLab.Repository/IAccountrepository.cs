using BlogLab.Models.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IAccountrepository
    {
        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user, CancellationToken cancellationToken);

        public Task<ApplicationUserIdentity> GetByUserNameAsync(string normalizedUsername, CancellationToken cancellationToken);
    }
}
