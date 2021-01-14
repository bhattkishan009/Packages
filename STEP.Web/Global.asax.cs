using System;
using System.Data.Entity;
using System.Threading;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Abp.WebApi.Validation;
using Castle.Facilities.Logging;
using STEP.EntityFramework;

namespace STEP.Web
{
    public class MvcApplication : AbpWebApplication<STEPWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer<STEPDbContext>(new DropCreateDatabaseIfModelChanges<STEPDbContext>());

            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            
            base.Application_Start(sender, e);
        }
    }
}
