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
    /// UserRoleRepository
    /// </summary>	
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
