using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// These are the paying TS entities -- high-level defined as an EIN. Self-referencing parentage to maintain parent-child franchise relationship.  
/// </summary>
public partial class Tenant
{
    public int Id { get; set; }

    public string? ClientName { get; set; }

    public string? Ein { get; set; }

    public int? MaxLicenses { get; set; }

    public int? RegionId { get; set; }

    public int? ParentTenantId { get; set; }

    public bool? ParentCanViewFinancials { get; set; }

    public bool? ParentCanViewEmployees { get; set; }

    public bool? ParentCanEditEmployees { get; set; }

    public bool? ParentCanViewCustomers { get; set; }

    public bool? ParentCanEditCustomers { get; set; }

    public int? StartingCheckNumber { get; set; }

    public bool? UseParentCheckNumbers { get; set; }

    public string? BankRoutingNumberEncrypted { get; set; }

    public string? BankAccountNumberEncrypted { get; set; }

    public int? StartingAchnumber { get; set; }

    public string? BranchIdentPrefix { get; set; }

    public DateOnly? TenantOpenDate { get; set; }

    public DateOnly? TenantCloseDate { get; set; }

    public string? Description { get; set; }

    public string? AchcompanyId { get; set; }

    public virtual ICollection<TalentApplicationStatement> TalentApplicationStatements { get; set; } = new List<TalentApplicationStatement>();

    public virtual ICollection<TenantBankAccount> TenantBankAccounts { get; set; } = new List<TenantBankAccount>();

    public virtual ICollection<TenantBranch> TenantBranches { get; set; } = new List<TenantBranch>();

    public virtual ICollection<TenantConfig> TenantConfigs { get; set; } = new List<TenantConfig>();

    public virtual ICollection<TenantRegion> TenantRegions { get; set; } = new List<TenantRegion>();

    public virtual ICollection<TenantsRoyaltyRate> TenantsRoyaltyRates { get; set; } = new List<TenantsRoyaltyRate>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
