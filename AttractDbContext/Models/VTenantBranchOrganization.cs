using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VTenantBranchOrganization
{
    public int BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchIdent { get; set; }

    public string? BranchAddress1 { get; set; }

    public string? BranchAddress2 { get; set; }

    public string? BranchCity { get; set; }

    public string? BranchZipCode { get; set; }

    public string? BranchState { get; set; }

    public string? BranchPhone { get; set; }

    public string? BranchGeoCode { get; set; }

    public bool? BranchIsActive { get; set; }

    public bool? IsMasterBranch { get; set; }

    public string? BranchEmail { get; set; }

    public string? BranchWebsite { get; set; }

    public int TenantId { get; set; }

    public string? TenantName { get; set; }

    public string? TenantEin { get; set; }

    public int? TenantRegionId { get; set; }

    public string? Description { get; set; }

    public int ParentTenantId { get; set; }

    public string? ParentTenantName { get; set; }

    public string? ParentTenantEin { get; set; }

    public int? ParentTenantRegionId { get; set; }

    public string? BranchLegalName { get; set; }

    public int? MasterBranchId { get; set; }

    public DateOnly? TenantOpenDate { get; set; }

    public DateOnly? TenantCloseDate { get; set; }

    public string? BranchIdentPrefix { get; set; }

    public string? FullBranchIdent { get; set; }

    public string? AchcompanyId { get; set; }
}
