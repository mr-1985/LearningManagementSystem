﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private LmsContext _context;

        public PermissionService(LmsContext context)
        {
            _context = context;
        }
        public List<Role> GetFilterRoles(int roleId)
        {
            var query = _context.Roles;
            return query.ToList();
        }
        public List<Role> GetRoles()
        {
            return _context.Roles.Where(R => R.IsDelete == false).ToList();

        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (int roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });

            }

            _context.SaveChanges();
        }

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //-------Delete All Roles User ---------//
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));

            //-----Add New Roles To User ------------//

            AddRolesToUser(rolesId, userId);

        }

        public List<string> GetUserRoles(int userId)
        {
            return _context.UserRoles.Include(r => r.Role).Where(r => r.UserId == userId)
                .Select(r => r.Role.RoleTitle).ToList();
        }

        public void RemoveRolesUser(int userId)
        {
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));
            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;

        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permissions.ToList();
        }

        public void AddPermissionsToRole(int roleId, List<int> permissions)
        {
            foreach (var item in permissions)
            {
                _context.RolePermissions.Add(new RolePermission()
                {
                    RoleId = roleId,
                    PermissionId = item,

                });
            }
            _context.SaveChanges();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermissions.Where(r => r.RoleId == roleId).Select(r => r.PermissionId).ToList();

        }

        public void UpdatePermissionsRole(int roleId, List<int> permissions)
        {
            _context.RolePermissions.Where(p => p.RoleId == roleId).ToList()
                 .ForEach(p => _context.RolePermissions.Remove(p));

            AddPermissionsToRole(roleId, permissions);
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;
            List<int> UserRoles = _context.UserRoles
                .Where(u => u.UserId == userId).Select(u => u.RoleId).ToList();
            if (!UserRoles.Any())
                return false;

            List<int> RolesPermission = _context.RolePermissions
                .Where(p => p.PermissionId == permissionId).Select(p => p.RoleId).ToList();

            return RolesPermission.Any(p => UserRoles.Contains(p));
        }

        public bool CheckUserIsRole(string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;
            bool userRoles = _context.UserRoles.Any(u => u.UserId == userId && (u.RoleId == 1));


            if (userRoles)
                return true;
            else
                return false;
        }
        public bool CheckIsAdmin(int userId)
        {

            bool userRoles = _context.UserRoles.Any(u => u.UserId == userId && (u.RoleId == 1));


            if (userRoles)
                return true;
            else
                return false;
        }
    }
}
