using Abp.Application.Services;
using Abp.Application.Services.Dto;
using STEP.MultiTenancy.Dto;

namespace STEP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
