using System.Threading.Tasks;
using Abp.Application.Services;
using TokenR.Authorization.Accounts.Dto;

namespace TokenR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
