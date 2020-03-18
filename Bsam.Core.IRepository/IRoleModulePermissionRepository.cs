using Bsam.Core.IRepository.Base;
using Bsam.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bsam.Core.IRepository
{
    /// <summary>
    /// IRoleModulePermissionRepository
    /// </summary>	
    public interface IRoleModulePermissionRepository : IBaseRepository<RoleModulePermission>//类名
    {
        Task<List<RoleModulePermission>> WithChildrenModel();
        Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
    }
}
