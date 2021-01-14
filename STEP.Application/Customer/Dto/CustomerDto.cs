using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEP.Customer
{
    [AutoMapFrom(typeof(Customer))]
    public class CustomerDto : EntityDto
    {
        private ICustomerAppService _customerAppService;

        public CustomerDto()
        {

        }
        public CustomerDto(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public CustomerDto SaveData()
        {
            return _customerAppService.Save(this);
        }
        public CustomerDto GetData(int id)
        {
            return _customerAppService.Get(id);
        }
    }
}
