using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace XZQ.MESIntelligence.EntityFrameworkCore
{
    public static class MESIntelligenceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MESIntelligenceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MESIntelligenceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
