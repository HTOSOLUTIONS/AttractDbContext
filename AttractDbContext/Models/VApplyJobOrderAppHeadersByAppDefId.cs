using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VApplyJobOrderAppHeadersByAppDefId
{
    public int AppId { get; set; }

    public int ApplicationDefInstanceId { get; set; }

    public int? JobOrderId { get; set; }

    public int? TalentId { get; set; }

    public DateTime? AppModifiedDate { get; set; }

    public bool? AppComplete { get; set; }

    public int? JobSiteId { get; set; }

    public string? JobTitle { get; set; }

    public int? JobranchId { get; set; }

    public decimal? BaseWage { get; set; }

    public int? BranchClientId { get; set; }

    public DateTime? JobOrderCreationDate { get; set; }

    public string? SalespersonId { get; set; }

    public string? RecruiterId { get; set; }

    public string? JobSiteName { get; set; }

    public string? BranchClientName { get; set; }

    public string? TalentName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? PreferredName { get; set; }

    public int? LanguageId { get; set; }

    public string? MobilePhone { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? ZipCode { get; set; }

    public string? TaxpayerId { get; set; }

    public string? Dob { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? EmployingBranchId { get; set; }

    public string? Employer { get; set; }

    public int SubmittedToClient { get; set; }

    public bool? IsDirectHire { get; set; }
}
