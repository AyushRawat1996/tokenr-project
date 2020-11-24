using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TokenR.Authorization;

namespace TokenR
{
    [DependsOn(
        typeof(TokenRCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TokenRApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TokenRAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TokenRApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
