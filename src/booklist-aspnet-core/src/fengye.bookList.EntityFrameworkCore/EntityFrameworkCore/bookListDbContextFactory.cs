using fengye.bookList.Configuration;
using fengye.bookList.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace fengye.bookList.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */

    public class bookListDbContextFactory : IDesignTimeDbContextFactory<bookListDbContext>
    {
        public bookListDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<bookListDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            bookListDbContextConfigurer.Configure(builder, configuration.GetConnectionString(bookListConsts.ConnectionStringName));

            return new bookListDbContext(builder.Options);
        }
    }
}