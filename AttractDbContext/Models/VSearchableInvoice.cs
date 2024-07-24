using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableInvoice
{
    public int InvoiceId { get; set; }

    public string? InvoiceNumber { get; set; }

    public int? BranchClientId { get; set; }

    public string? BranchName { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? BranchNameRev { get; set; }

    public string? TheYear { get; set; }

    public string? TheMonthName { get; set; }

    public int? TenantId { get; set; }

    public string? Mmyyyy { get; set; }

    public string? Style101 { get; set; }

    public string? Style112 { get; set; }

    public string? Style120 { get; set; }

    public string? BranchClientName { get; set; }

    public string? BranchClientNameRev { get; set; }
}
