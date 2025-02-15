using SS.Model;
using SS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services
{
    public class PermissionsMenuManager : IPermissionsMenuManager
    {
        public PermissionsMenuManager()
        {
         
        }
        public List<Permission> GetPermissions(int userId)
        {
            var permissions = new List<Permission>();

            try
            {
                using (var context = new SSModelContainer())
                {
                    var user = context.Users.Find(userId);
                    permissions = context.Permissions.Where(x => x.Role.Id == user.Role.Id).ToList();

                }
                return permissions;
            }
            catch (Exception ex)
            {
                return permissions;
            }



        }

    }
}
