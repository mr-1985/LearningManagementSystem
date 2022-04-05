using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RoleTitle { get; set; }

        public bool IsDelete { get; set; }

        public virtual List<RolePermission> RolePermissions { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
