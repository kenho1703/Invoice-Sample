using System.Threading.Tasks;
using Abp.Application.Services;
using InvoiceSample.Roles.Dto;

namespace InvoiceSample.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
