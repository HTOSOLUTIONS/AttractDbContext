using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// All User account information, encrypted. 
/// </summary>
public partial class User
{
    public string Id { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? Auth0UserKey { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDt { get; set; }

    public string? ProfileImgUrl { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ActivationDt { get; set; }

    public virtual ICollection<PreUser> PreUsers { get; set; } = new List<PreUser>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
