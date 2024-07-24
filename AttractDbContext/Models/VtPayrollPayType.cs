using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtPayrollPayType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsTaxable { get; set; }

    public bool? IsActive { get; set; }

    public string? W2box { get; set; }

    public bool? ForInvoiceOnly { get; set; }

    public string? InventoryName { get; set; }

    public string? InvoiceLabel { get; set; }

    public virtual ICollection<PayChecksPay> PayChecksPays { get; set; } = new List<PayChecksPay>();

    public virtual ICollection<VtPayrollPayTypesBranchAssoc> VtPayrollPayTypesBranchAssocs { get; set; } = new List<VtPayrollPayTypesBranchAssoc>();
}
