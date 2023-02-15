using Abp.MultiTenancy;
using XZQ.MESIntelligence.Authorization.Users;

namespace XZQ.MESIntelligence.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
