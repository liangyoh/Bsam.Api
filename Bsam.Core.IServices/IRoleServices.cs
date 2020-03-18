using Bsam.Core.IServices.Base;
using Bsam.Core.Model.Models;
using System.Threading.Tasks;

namespace Bsam.Core.IServices
{
    /// <summary>
    /// RoleServices
    /// </summary>	
    public interface IRoleServices :IBaseServices<Role>
	{
        Task<Role> SaveRole(string roleName);
        Task<string> GetRoleNameByRid(int rid);

    }
}
