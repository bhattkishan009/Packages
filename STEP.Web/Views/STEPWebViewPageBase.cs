using Abp.Web.Mvc.Views;

namespace STEP.Web.Views
{
    public abstract class STEPWebViewPageBase : STEPWebViewPageBase<dynamic>
    {

    }

    public abstract class STEPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected STEPWebViewPageBase()
        {
            LocalizationSourceName = STEPConsts.LocalizationSourceName;
        }
    }
}