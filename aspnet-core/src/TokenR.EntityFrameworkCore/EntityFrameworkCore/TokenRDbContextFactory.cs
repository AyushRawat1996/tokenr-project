using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TokenR.Configuration;
using TokenR.Web;

namespace TokenR.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TokenRDbContextFactory : IDesignTimeDbContextFactory<TokenRDbContext>
    {
        public TokenRDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TokenRDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TokenRDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TokenRConsts.ConnectionStringName));

            return new TokenRDbContext(builder.Options);
        }
    }
}
