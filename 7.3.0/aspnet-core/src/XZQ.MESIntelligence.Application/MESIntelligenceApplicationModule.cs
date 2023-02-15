using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XZQ.MESIntelligence.Authorization;

namespace XZQ.MESIntelligence
{
    [DependsOn(
        typeof(MESIntelligenceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MESIntelligenceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MESIntelligenceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MESIntelligenceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
