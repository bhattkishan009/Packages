using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace STEP.Forms
{
    [AutoMapFrom(typeof(Form))]
    public class FormDto : EntityDto
    {
        public string Json { get; set; }
    }
}
