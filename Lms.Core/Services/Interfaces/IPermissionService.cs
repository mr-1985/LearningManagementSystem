using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;

namespace Lms.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Role

        List<Role> GetRoles();
        List<Role> GetFilterRoles(int roleId);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        List<string> GetUserRoles(int userId);
        void RemoveRolesUser(int userId);

        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);

        #endregion

        #region Permission

       List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permissions);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);
        bool CheckPermission(int permissionId, string userName);
        bool CheckUserIsRole(string userName);
        bool CheckIsAdmin(int userId);

        #endregion
    }
}
