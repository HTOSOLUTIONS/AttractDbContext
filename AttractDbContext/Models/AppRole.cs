using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// All roles in use in the application. This is dimensional data. 
/// </summary>
public partial class AppRole
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public string? RoleActions { get; set; }

    public bool? IsParentalRole { get; set; }

    public bool? IsChildRole { get; set; }

    public virtual ICollection<PreUser> PreUsers { get; set; } = new List<PreUser>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
