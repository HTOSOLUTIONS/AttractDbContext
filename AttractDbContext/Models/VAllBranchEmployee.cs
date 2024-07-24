using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllBranchEmployee
{
    public int? TalentId { get; set; }

    public int? TenantBranchId { get; set; }

    public int EmployeeId { get; set; }

    public int? TenantId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MobilePhone { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? StateName { get; set; }

    public string? ZipCode { get; set; }

    public bool? SendSmsupdates { get; set; }

    public bool? SendEmailUpdates { get; set; }

    public DateOnly? LastDatePaid { get; set; }

    public string? Gender { get; set; }

    public string? Language { get; set; }

    public string? HomePhone { get; set; }

    public string EmploymentStatus { get; set; } = null!;

    public int IsAssignable { get; set; }

    public string SubmittedStatus { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? TerminationReasonId { get; set; }

    public string? TerminationReasonValue { get; set; }

    public DateTime? TerminationDate { get; set; }

    public bool? EligibleForRehire { get; set; }

    public string? RehireEligibilityNote { get; set; }

    public DateTime? HireDate { get; set; }

    public int EmploymentTypeId { get; set; }

    public string? EmploymentTypeName { get; set; }
}
