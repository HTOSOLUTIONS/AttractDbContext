using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllPayChecksPaysNormalized
{
    public int PayCheckId { get; set; }

    public int? PayTypeId { get; set; }

    public int PayCheckPaysId { get; set; }

    public string? PayType { get; set; }

    public decimal? UnitAmount { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsTaxable { get; set; }

    public bool? IsActive { get; set; }

    public string? W2box { get; set; }

    public int? BillableToBranchAssignmentId { get; set; }

    public int? BillableToBranchClientId { get; set; }

    public string? ClientName { get; set; }

    public string? CreatedByUserId { get; set; }

    public int? BranchPayPeriodId { get; set; }

    public decimal? BillTotal { get; set; }
}
