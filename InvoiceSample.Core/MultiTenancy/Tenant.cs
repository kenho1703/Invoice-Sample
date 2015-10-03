using Abp.MultiTenancy;
using InvoiceSample.Users;

namespace InvoiceSample.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}