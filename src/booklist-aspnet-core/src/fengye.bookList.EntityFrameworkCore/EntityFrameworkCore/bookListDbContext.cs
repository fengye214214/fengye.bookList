using Abp.Zero.EntityFrameworkCore;
using fengye.bookList.Authorization.Roles;
using fengye.bookList.Authorization.Users;
using fengye.bookList.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace fengye.bookList.EntityFrameworkCore
{
    public class bookListDbContext : AbpZeroDbContext<Tenant, Role, User, bookListDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public bookListDbContext(DbContextOptions<bookListDbContext> options)
            : base(options)
        {
        }
    }
}