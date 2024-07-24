using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class AppRolesCreationPermission
{
    public int AppRoleId { get; set; }

    public int AppRoleIdcanCreate { get; set; }
}
