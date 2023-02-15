using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XZQ.MESIntelligence.Configuration;
using XZQ.MESIntelligence.EntityFrameworkCore;
using XZQ.MESIntelligence.Migrator.DependencyInjection;

namespace XZQ.MESIntelligence.Migrator
{
    [DependsOn(typeof(MESIntelligenceEntityFrameworkModule))]
    public class MESIntelligenceMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MESIntelligenceMigratorModule(MESIntelligenceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MESIntelligenceMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MESIntelligenceConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MESIntelligenceMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
