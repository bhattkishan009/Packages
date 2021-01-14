using System.Threading.Tasks;
using Abp.Application.Services;
using STEP.Sessions.Dto;

namespace STEP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
