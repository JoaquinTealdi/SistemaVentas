using SS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Interfaces
{
    public interface IPermissionsMenuManager
    {
        List<Permission> GetPermissions(int userId);
    }
}
