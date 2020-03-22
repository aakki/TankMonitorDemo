using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TankMonitorDemo.Authorization.Roles;
using TankMonitorDemo.Authorization.Users;
using TankMonitorDemo.MultiTenancy;
using TankMonitorDemo.Products;

namespace TankMonitorDemo.EntityFrameworkCore
{
    public class TankMonitorDemoDbContext : AbpZeroDbContext<Tenant, Role, User, TankMonitorDemoDbContext>
    {
        public DbSet<Product> products { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public TankMonitorDemoDbContext(DbContextOptions<TankMonitorDemoDbContext> options)
            : base(options)
        {
        }
    }
}
