using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
