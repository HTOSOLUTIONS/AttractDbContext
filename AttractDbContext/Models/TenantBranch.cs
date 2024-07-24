using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Branches for any tenant.  
/// </summary>
public partial class TenantBranch
{
    public int Id { get; set; }

    public string? BranchName { get; set; }

    public string? BranchIdent { get; set; }

    public int? TenantId { get; set; }

    public string? BranchAddress1 { get; set; }

    public string? BranchAddress2 { get; set; }

    public string? BranchCity { get; set; }

    public string? BranchZipCode { get; set; }

    public string? Phone { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? BranchState { get; set; }

    public string? Ein { get; set; }

    public string? StartingCheckNumber { get; set; }

    public string? GeoCodeId { get; set; }

    public bool? IsMasterBranch { get; set; }

    public string? BranchLegalName { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public virtual ICollection<BranchApplicationAddlQuestion> BranchApplicationAddlQuestions { get; set; } = new List<BranchApplicationAddlQuestion>();

    public virtual ICollection<BranchApplicationStatement> BranchApplicationStatements { get; set; } = new List<BranchApplicationStatement>();

    public virtual ICollection<BranchClient> BranchClients { get; set; } = new List<BranchClient>();

    public virtual ICollection<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();

    public virtual ICollection<ChartOfAccountsDefinition> ChartOfAccountsDefinitions { get; set; } = new List<ChartOfAccountsDefinition>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<TalentBranch> TalentBranches { get; set; } = new List<TalentBranch>();

    public virtual ICollection<TalentConditionalJobOffer> TalentConditionalJobOffers { get; set; } = new List<TalentConditionalJobOffer>();

    public virtual Tenant? Tenant { get; set; }

    public virtual ICollection<TenantBranchesRoyaltyRate> TenantBranchesRoyaltyRates { get; set; } = new List<TenantBranchesRoyaltyRate>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<VtPayrollDeductionTypesBranchAssoc> VtPayrollDeductionTypesBranchAssocs { get; set; } = new List<VtPayrollDeductionTypesBranchAssoc>();

    public virtual ICollection<VtPayrollPayTypesBranchAssoc> VtPayrollPayTypesBranchAssocs { get; set; } = new List<VtPayrollPayTypesBranchAssoc>();
}
