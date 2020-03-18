using Bsam.Core.IRepository;
using Bsam.Core.IRepository.UnitOfWork;
using Bsam.Core.Model.Models;
using Bsam.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Repository
{
    /// <summary>
    /// sysUserInfoRepository
    /// </summary>	
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

