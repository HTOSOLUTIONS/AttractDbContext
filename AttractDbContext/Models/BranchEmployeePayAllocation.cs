using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Employee can allocate their paycheck to direct amounts to different bank accounts.  
/// </summary>
public partial class BranchEmployeePayAllocation
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? TalentBankAccountId { get; set; }

    public int? PaycheckAllocationTypeId { get; set; }

    public decimal? AllocationPct { get; set; }

    public decimal? AllocationAmt { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual ICollection<PayCheckFinalPayDetail> PayCheckFinalPayDetails { get; set; } = new List<PayCheckFinalPayDetail>();

    public virtual VtPaycheckAllocationType? PaycheckAllocationType { get; set; }

    public virtual TalentBankAccount? TalentBankAccount { get; set; }
}
