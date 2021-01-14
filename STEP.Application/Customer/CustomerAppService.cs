using System.Threading.Tasks;
using System.Linq;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System.Collections.Generic;
using STEP.Configuration.Dto;

namespace STEP.Customer
{
    public class CustomerAppService : STEPAppServiceBase, ICustomerAppService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerAppService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<CustomerDto> GetAll()
        {
            return ObjectMapper.Map<List<CustomerDto>>(_customerRepository.GetAll().ToList());
        }

        public CustomerDto Get(int id)
        {
            return ObjectMapper.Map<CustomerDto>(_customerRepository.Get(id));
        }

        public CustomerDto Save(CustomerDto customer)
        {
            Customer updateCustomer;

            if (customer.Id > 0)
                updateCustomer = _customerRepository.Update(ObjectMapper.Map<Customer>(customer));
            else
                updateCustomer = _customerRepository.Insert(ObjectMapper.Map<Customer>(customer));

            return ObjectMapper.Map<CustomerDto>(updateCustomer);
        }
    }
}
