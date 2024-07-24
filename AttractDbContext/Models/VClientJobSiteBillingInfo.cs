using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VClientJobSiteBillingInfo
{
    public int ClientJobSiteId { get; set; }

    public int? BranchClientId { get; set; }

    public string? BranchClientName { get; set; }

    public string? JobSiteIdent { get; set; }

    public string? BranchClientIdent { get; set; }

    public int? InvoiceTerms { get; set; }

    public string? InvoiceTermsValue { get; set; }

    public string? JobSiteName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateName { get; set; }

    public string? ZipCode { get; set; }

    public decimal? GeoLat { get; set; }

    public decimal? GeoLon { get; set; }

    public string? JobSiteContactEmail { get; set; }

    public string? EntryDescription { get; set; }

    public bool? JobSiteIsActive { get; set; }

    public string? BillAddress1 { get; set; }

    public string? BillAddress2 { get; set; }

    public string? BillCity { get; set; }

    public string? BillState { get; set; }

    public string? BillZip { get; set; }

    public string? BillEmail { get; set; }

    public string? BillPhone { get; set; }

    public string? BillDepartment { get; set; }

    public string? BillPerson { get; set; }

    public int? WorkersCompCode { get; set; }

    public decimal? AcasurchargeRate { get; set; }

    public decimal? SiteDiscountPct { get; set; }

    public decimal? SiteSalesTaxPct { get; set; }

    public int? AcainvoiceFormat { get; set; }

    public bool? AcabillInsuredOnly { get; set; }

    public bool? MailInvoice { get; set; }

    public string? PrimaryPhone { get; set; }

    public string? EmailAddress { get; set; }

    public string? Country { get; set; }

    public string? RecruiterId { get; set; }

    public bool? UseParentBillingInfo { get; set; }

    public decimal? BranchDiscountPct { get; set; }

    public decimal? BranchSalesTax { get; set; }

    public string? BranchIdent { get; set; }

    public string? BranchName { get; set; }

    public int BranchId { get; set; }
}
