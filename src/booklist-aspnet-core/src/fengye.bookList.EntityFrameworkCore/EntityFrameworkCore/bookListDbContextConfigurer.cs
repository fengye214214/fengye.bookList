using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace fengye.bookList.EntityFrameworkCore
{
    public static class bookListDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<bookListDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<bookListDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}