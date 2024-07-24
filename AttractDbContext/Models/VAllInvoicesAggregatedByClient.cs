using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllInvoicesAggregatedByClient
{
    public int? BranchClientId { get; set; }

    public string? BranchClientIdent { get; set; }

    public int? BranchId { get; set; }

    public int? TenantId { get; set; }

    public string? BranchName { get; set; }

    public string? Terms { get; set; }

    public string? BranchClientName { get; set; }

    public string? InvoiceStatus { get; set; }

    public int? Age { get; set; }

    public int? TermsId { get; set; }

    public string? FullClientIdent { get; set; }

    public int? Cnt { get; set; }

    public decimal? RegDue { get; set; }

    public decimal? Otdue { get; set; }

    public decimal? DoubleDue { get; set; }

    public decimal? TotalDue { get; set; }

    public decimal? TotalTaxAmount { get; set; }

    public decimal? AmountPaidToDate { get; set; }

    public decimal? TotalAdjustment { get; set; }

    public decimal? DiscountAmount { get; set; }
}
