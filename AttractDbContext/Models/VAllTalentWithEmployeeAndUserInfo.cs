using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTalentWithEmployeeAndUserInfo
{
    public string? UserId { get; set; }

    public int TalentId { get; set; }

    public int? EmployedByBranchId { get; set; }

    public int? EmployedByTenantId { get; set; }

    public string? BranchLegalName { get; set; }

    public int? EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Auth0UserKey { get; set; }

    public string? Roles { get; set; }

    public int IsUser { get; set; }

    public int IsEmployee { get; set; }

    public int IsUserAccountActive { get; set; }

    public int? EmployeeTypeId { get; set; }

    public string? EmployeeTypeValue { get; set; }

    public string? HomePhone { get; set; }

    public int? LanguageId { get; set; }

    public string? LanguageValue { get; set; }

    public string? UserStatus { get; set; }

    public string Token { get; set; } = null!;
}
