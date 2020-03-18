using Bsam.Core.IServices.Base;
using Bsam.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bsam.Core.IServices
{

    /// <summary>
    /// RoleModulePermissionServices
    /// </summary>	
    public interface IRoleModulePermissionServices : IBaseServices<RoleModulePermission>
    {

        Task<List<RoleModulePermission>> GetRoleModule();
        Task<List<RoleModulePermission>> TestModelWithChildren();
        Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
    }
}
