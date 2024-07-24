using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VPayflowPayAmountsVsBillAmount
{
    public int PaycheckId { get; set; }

    public int? BranchEmployeeId { get; set; }

    public string? TalentName { get; set; }

    public int? BranchClientIdHidden { get; set; }

    public string? BranchClientName { get; set; }

    public decimal? GrossPay { get; set; }

    public decimal? Taxes { get; set; }

    public decimal? Deductions { get; set; }

    public decimal? NetPay { get; set; }

    public decimal? BillAmt { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Hours { get; set; }

    public int? PayPeriodId { get; set; }

    public int? BranchId { get; set; }

    public decimal DiscountPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? Ertaxes { get; set; }

    public int? InvoiceCreated { get; set; }
}
