using System.Collections.Generic;
using TokenR.Roles.Dto;

namespace TokenR.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
