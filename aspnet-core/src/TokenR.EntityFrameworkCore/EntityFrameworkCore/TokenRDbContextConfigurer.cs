using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TokenR.EntityFrameworkCore
{
    public static class TokenRDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TokenRDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TokenRDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
