using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// itemizes any garnishment orders. i.e., more than one child support order.  
/// </summary>
public partial class BranchEmployeeDeductionInstanceItem
{
    public int Id { get; set; }

    public int? DeductionInstanceId { get; set; }

    public string? CaseId { get; set; }

    public DateTime? CaseDate { get; set; }

    public string? ItemDescrip { get; set; }

    public string? StateId { get; set; }

    public decimal? CasePct { get; set; }

    public decimal? Maximum { get; set; }

    public string? CaseIssuer { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public virtual BranchEmployeeDeductionInstance? DeductionInstance { get; set; }
}
