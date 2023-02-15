using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XZQ.MESIntelligence.Configuration;

namespace XZQ.MESIntelligence.Web.Host.Startup
{
    [DependsOn(
       typeof(MESIntelligenceWebCoreModule))]
    public class MESIntelligenceWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MESIntelligenceWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MESIntelligenceWebHostModule).GetAssembly());
        }
    }
}
