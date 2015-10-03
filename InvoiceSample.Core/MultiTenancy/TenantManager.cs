using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using InvoiceSample.Authorization.Roles;
using InvoiceSample.Users;

namespace InvoiceSample.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(IRepository<Tenant> tenantRepository)
            : base(tenantRepository)
        {

        }
    }
}