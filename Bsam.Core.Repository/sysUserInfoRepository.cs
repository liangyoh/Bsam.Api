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
    public class sysUserInfoRepository : BaseRepository<sysUserInfo>, IsysUserInfoRepository
    {
        public sysUserInfoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
