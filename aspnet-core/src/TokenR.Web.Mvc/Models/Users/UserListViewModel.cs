using System.Collections.Generic;
using TokenR.Roles.Dto;

namespace TokenR.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
