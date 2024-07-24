using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Recruiters can submit an employee to a client for review &quot;do you want to have this person come to this job order?&quot; 
/// </summary>
public partial class BranchEmployeeClientSubmission
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? JobOrderId { get; set; }

    public bool? IsSubmitted { get; set; }

    public int? ApprovalStatus { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public DateTime? ApprovalStatusDate { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedbyUserId { get; set; }

    public int? BranchClientId { get; set; }

    public virtual BranchClient? BranchClient { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }
}
