using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllInvoice
{
    public int? BranchClientId { get; set; }

    public string? BranchClientIdent { get; set; }

    public int? BranchId { get; set; }

    public int? TenantId { get; set; }

    public int? JobSiteId { get; set; }

    public string? JobSiteName { get; set; }

    public int InvoiceId { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? OrderNumber { get; set; }

    public string? InvoiceStatus { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public int? Age { get; set; }

    public DateOnly? InvoiceDueDate { get; set; }

    public string? ContactName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactTaxNumber { get; set; }

    public string? ContactAddress1 { get; set; }

    public string? ContactAddress2 { get; set; }

    public string? ContactCity { get; set; }

    public string? ContactState { get; set; }

    public string? ContactZipCode { get; set; }

    public string? ContactPhone { get; set; }

    public decimal? RegHrs { get; set; }

    public decimal? Othrs { get; set; }

    public decimal? DoubleHrs { get; set; }

    public decimal? RegDue { get; set; }

    public decimal? Otdue { get; set; }

    public decimal? DoubleDue { get; set; }

    public int? TermsId { get; set; }

    public decimal? TotalDue { get; set; }

    public decimal? GrossDue { get; set; }

    public string? Memo { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public decimal? TotalTaxAmount { get; set; }

    public decimal? AmountPaidToDate { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? Adjustment { get; set; }

    public string? BranchName { get; set; }

    public string? Terms { get; set; }

    public string? BranchClientName { get; set; }

    public string? FullClientIdent { get; set; }

    public string? TenantName { get; set; }

    public bool? InvoiceIsActive { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidedDt { get; set; }

    public string? PurchaseOrderNumber { get; set; }
}
