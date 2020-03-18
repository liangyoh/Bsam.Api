using Bsam.Core.IServices.Base;
using Bsam.Core.Model.Models;
using System.Threading.Tasks;

namespace Bsam.Core.IServices
{	
	/// <summary>
	/// sysUserInfoServices
	/// </summary>	
    public interface ISysUserInfoServices :IBaseServices<sysUserInfo>
	{
        Task<sysUserInfo> SaveUserInfo(string loginName, string loginPwd);
        Task<string> GetUserRoleNameStr(string loginName, string loginPwd);
    }
}
