using Abp.Authorization.Roles;
using InvoiceSample.MultiTenancy;
using InvoiceSample.Users;

namespace InvoiceSample.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}