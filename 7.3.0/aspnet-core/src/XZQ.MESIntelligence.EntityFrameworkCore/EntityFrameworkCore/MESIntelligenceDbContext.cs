using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using XZQ.MESIntelligence.Authorization.Roles;
using XZQ.MESIntelligence.Authorization.Users;
using XZQ.MESIntelligence.MultiTenancy;
using XZQ.MESIntelligence.Department;

namespace XZQ.MESIntelligence.EntityFrameworkCore
{
    public class MESIntelligenceDbContext : AbpZeroDbContext<Tenant, Role, User, MESIntelligenceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MESIntelligenceDbContext(DbContextOptions<MESIntelligenceDbContext> options)
            : base(options)
        {

        }
        
        public DbSet<APJUser> APJUsers { get; set; }
        

        public DbSet<DepartmentMessage> DepartmentMessage { get; set; }
        public DbSet<Teamorgroup> Teamorgroup { get; set; }
    }
}
