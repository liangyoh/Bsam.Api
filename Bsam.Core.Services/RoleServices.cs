using Bsam.Core.IServices;
using Bsam.Core.IServices.Base;
using Bsam.Core.Model.Models;
using Bsam.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsam.Core.Services
{
    public class RoleServices : BaseServices<Role>, IRoleServices
    {
        public async Task<string> GetRoleNameByRid(int rid)
        {
            return ((await base.QueryById(rid))?.Name);
        }

        public async Task<Role> SaveRole(string roleName)
        {
            Role role = new Role(roleName);
            Role model = new Role();

            var userList = await base.Query(a=>a.Name == role.Name && a.Enabled);
            if (userList != null && userList.Count > 0)
            {
                model = userList.FirstOrDefault();
            }
            else
            {
                var id = await base.Add(role);
                model = await base.QueryById(id);
            }

            return model;
        }
    }
}
