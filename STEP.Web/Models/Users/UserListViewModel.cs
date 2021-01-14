using System.Collections.Generic;
using STEP.Roles.Dto;
using STEP.Users.Dto;

namespace STEP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}