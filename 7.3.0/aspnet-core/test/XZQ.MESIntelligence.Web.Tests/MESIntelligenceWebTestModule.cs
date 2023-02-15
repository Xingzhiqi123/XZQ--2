using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XZQ.MESIntelligence.EntityFrameworkCore;
using XZQ.MESIntelligence.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace XZQ.MESIntelligence.Web.Tests
{
    [DependsOn(
        typeof(MESIntelligenceWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MESIntelligenceWebTestModule : AbpModule
    {
        public MESIntelligenceWebTestModule(MESIntelligenceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MESIntelligenceWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MESIntelligenceWebMvcModule).Assembly);
        }
    }
}