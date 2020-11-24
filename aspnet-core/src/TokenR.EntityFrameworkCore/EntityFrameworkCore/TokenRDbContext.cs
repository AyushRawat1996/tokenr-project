using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TokenR.Authorization.Roles;
using TokenR.Authorization.Users;
using TokenR.MultiTenancy;

namespace TokenR.EntityFrameworkCore
{
    public class TokenRDbContext : AbpZeroDbContext<Tenant, Role, User, TokenRDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TokenRDbContext(DbContextOptions<TokenRDbContext> options)
            : base(options)
        {
        }
    }
}
