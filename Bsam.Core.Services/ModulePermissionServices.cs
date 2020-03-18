using Bsam.Core.IRepository;
using Bsam.Core.IServices;
using Bsam.Core.Model.Models;
using Bsam.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Services
{
    /// <summary>
    /// ModulePermissionServices
    /// </summary>	
    public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {

        IModulePermissionRepository _dal;
        public ModulePermissionServices(IModulePermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
