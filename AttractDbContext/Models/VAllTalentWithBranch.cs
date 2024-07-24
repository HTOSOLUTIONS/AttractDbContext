using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTalentWithBranch
{
    public int TalentId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? TaxpayerId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? ZipCode { get; set; }

    public string? MobilePhone { get; set; }

    public string? HomePhone { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? EmergencyContactName { get; set; }

    public string? EmergencyContactPhone { get; set; }

    public string? PreferredName { get; set; }

    public int? GenderId { get; set; }

    public bool? SendSmsupdates { get; set; }

    public bool? SendEmailUpdates { get; set; }

    public string? GeoCodeId { get; set; }

    public string? Status { get; set; }

    public int? LanguageId { get; set; }

    public bool? IsActive { get; set; }

    public int? BranchId { get; set; }

    public DateTime? CreatedDtutc { get; set; }
}
