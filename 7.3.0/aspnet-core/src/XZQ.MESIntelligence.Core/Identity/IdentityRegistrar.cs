using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using XZQ.MESIntelligence.Authorization;
using XZQ.MESIntelligence.Authorization.Roles;
using XZQ.MESIntelligence.Authorization.Users;
using XZQ.MESIntelligence.Editions;
using XZQ.MESIntelligence.MultiTenancy;

namespace XZQ.MESIntelligence.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
