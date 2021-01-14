using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using STEP.Configuration.Dto;

namespace STEP.Forms
{
    public interface IFormAppService : IApplicationService
    {
        FormDto Get(int id);
    }
}