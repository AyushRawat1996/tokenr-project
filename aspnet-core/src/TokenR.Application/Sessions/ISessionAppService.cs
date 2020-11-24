using System.Threading.Tasks;
using Abp.Application.Services;
using TokenR.Sessions.Dto;

namespace TokenR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
