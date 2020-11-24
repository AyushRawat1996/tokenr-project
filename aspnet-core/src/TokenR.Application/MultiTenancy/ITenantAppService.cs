using Abp.Application.Services;
using TokenR.MultiTenancy.Dto;

namespace TokenR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

