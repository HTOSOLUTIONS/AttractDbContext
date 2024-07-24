using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Invoice high level - Not fully normalized because we want an invoice&apos;s content to be locked at the point that we create it, and edited independently of any dimensional data. 
/// </summary>
public partial class Invoice
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public int? BranchId { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? OrderNumber { get; set; }

    public string? InvoiceStatus { get; set; }

    public DateOnly? InvoiceDate { get; set; }

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

    public int? JobSiteId { get; set; }

    public decimal? RegHrs { get; set; }

    public decimal? Othrs { get; set; }

    public decimal? DoubleHrs { get; set; }

    public decimal? RegDue { get; set; }

    public decimal? Otdue { get; set; }

    public decimal? DoubleDue { get; set; }

    public int? TermsId { get; set; }

    public string? Memo { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? TotalTaxAmount { get; set; }

    public decimal? AmountPaidToDate { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? Adjustment { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? OtherDue { get; set; }

    public decimal? GrossDue { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidedDt { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public decimal? Acapercent { get; set; }

    public decimal? Acaamount { get; set; }

    public decimal? TotalDue { get; set; }

    public int? DocumentId { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual BranchClient? Client { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public virtual ClientJobSite? JobSite { get; set; }

    public virtual VtInvoiceTerm? Terms { get; set; }
}
