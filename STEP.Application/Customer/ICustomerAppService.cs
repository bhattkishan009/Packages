using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using STEP.Configuration.Dto;

namespace STEP.Customer
{
    public interface ICustomerAppService: IApplicationService
    {
        List<CustomerDto> GetAll();
        CustomerDto Get(int id);
        CustomerDto Save(CustomerDto customer);
    }
}