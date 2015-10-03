using Abp.Web.Mvc.Views;

namespace InvoiceSample.Web.Views
{
    public abstract class InvoiceSampleWebViewPageBase : InvoiceSampleWebViewPageBase<dynamic>
    {

    }

    public abstract class InvoiceSampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected InvoiceSampleWebViewPageBase()
        {
            LocalizationSourceName = InvoiceSampleConsts.LocalizationSourceName;
        }
    }
}