using Abp.Authorization;
using InvoiceSample.Authorization.Roles;
using InvoiceSample.MultiTenancy;
using InvoiceSample.Users;

namespace InvoiceSample.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
