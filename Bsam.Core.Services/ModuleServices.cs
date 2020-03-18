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
    /// ModuleServices
    /// </summary>	
    public class ModuleServices : BaseServices<Module>, IModuleServices
    {

        IModuleRepository _dal;
        public ModuleServices(IModuleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
