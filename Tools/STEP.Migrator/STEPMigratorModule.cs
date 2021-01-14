using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using STEP.EntityFramework;

namespace STEP.Migrator
{
    [DependsOn(typeof(STEPDataModule))]
    public class STEPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<STEPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}