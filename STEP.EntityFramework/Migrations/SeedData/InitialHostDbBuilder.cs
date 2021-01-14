using STEP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace STEP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly STEPDbContext _context;

        public InitialHostDbBuilder(STEPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
