using Bsam.Core.IServices.Base;
using Bsam.Core.Model.Models;
using System.Threading.Tasks;

namespace Bsam.Core.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

