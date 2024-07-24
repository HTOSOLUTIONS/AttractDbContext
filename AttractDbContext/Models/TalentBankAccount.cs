using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Encrypted bank account information for talent EFT payments.  
/// </summary>
public partial class TalentBankAccount
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? AccountTypeId { get; set; }

    public string? RoutingNumEncrypted { get; set; }

    public string? AccountNumEncrypted { get; set; }

    public bool? IsVerified { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Address { get; set; }

    public string? BankName { get; set; }

    public string? RoutingNumber { get; set; }

    public virtual VtBankAccountType? AccountType { get; set; }

    public virtual ICollection<BranchEmployeePayAllocation> BranchEmployeePayAllocations { get; set; } = new List<BranchEmployeePayAllocation>();

    public virtual Talent? Talent { get; set; }
}
