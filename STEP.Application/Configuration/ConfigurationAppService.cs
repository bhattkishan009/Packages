using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using STEP.Configuration.Dto;

namespace STEP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : STEPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
