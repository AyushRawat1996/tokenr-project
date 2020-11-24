using System.Collections.Generic;
using TokenR.Roles.Dto;

namespace TokenR.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}