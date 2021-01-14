using Abp.Domain.Repositories;

namespace STEP.Forms
{
    public class FormAppService : STEPAppServiceBase, IFormAppService
    {
        private readonly IRepository<Form> _formRepository;

        public FormAppService(IRepository<Form> formRepository)
        {
            _formRepository = formRepository;
        }

        public FormDto Get(int id)
        {
            return ObjectMapper.Map<FormDto>(_formRepository.Get(id));
        }
    }
}
