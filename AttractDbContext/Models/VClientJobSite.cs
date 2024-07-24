using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VClientJobSite
{
    public int ClientJobSiteId { get; set; }

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

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public bool? IsActive { get; set; }

    public int? BranchClientId { get; set; }

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

    public int? AcainvoiceFormat { get; set; }

    public bool? AcabillInsuredOnly { get; set; }

    public int? InvoiceFormat { get; set; }

    public int? InvoiceTerms { get; set; }

    public bool? MailInvoice { get; set; }

    public decimal? SalesTaxPct { get; set; }

    public decimal? DiscountPct { get; set; }

    public string? JobSiteIdent { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedbyUserId { get; set; }

    public string? PrimaryPhone { get; set; }

    public string? Country { get; set; }

    public string? RecruiterId { get; set; }

    public string? GeoCodeId { get; set; }

    public bool? UseParentBillingInfo { get; set; }

    public int? AcasurchargeMethodId { get; set; }

    public string? Website { get; set; }

    public string? SiteDescription { get; set; }

    public bool? IsPrimary { get; set; }

    public string? TransportationAccessDetails { get; set; }

    public string? ParkingDetails { get; set; }
}
