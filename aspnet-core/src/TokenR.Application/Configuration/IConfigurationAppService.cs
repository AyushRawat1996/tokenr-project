using System.Threading.Tasks;
using TokenR.Configuration.Dto;

namespace TokenR.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
