using System.Threading.Tasks;
using Abp.Application.Services;
using STEP.Configuration.Dto;

namespace STEP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}