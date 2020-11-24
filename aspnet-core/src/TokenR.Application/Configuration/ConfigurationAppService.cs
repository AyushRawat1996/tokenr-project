using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TokenR.Configuration.Dto;

namespace TokenR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TokenRAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
