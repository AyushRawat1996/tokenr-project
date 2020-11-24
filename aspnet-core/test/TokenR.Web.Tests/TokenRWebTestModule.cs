using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TokenR.EntityFrameworkCore;
using TokenR.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TokenR.Web.Tests
{
    [DependsOn(
        typeof(TokenRWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TokenRWebTestModule : AbpModule
    {
        public TokenRWebTestModule(TokenREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TokenRWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TokenRWebMvcModule).Assembly);
        }
    }
}