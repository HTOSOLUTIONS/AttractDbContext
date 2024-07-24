using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Employee preferences on pay method.  
/// </summary>
public partial class BranchEmployeePaycheckPreference
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public bool? IsAch { get; set; }

    public bool? IsPaperCheck { get; set; }

    public bool? IsPayCard { get; set; }

    public bool? IsActive { get; set; }

    public int? BankAccountId { get; set; }

    public int? PaystubHandlingId { get; set; }

    public virtual BranchEmployee? Employee { get; set; }
}
