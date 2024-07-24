using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtInvoiceTerm
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public int? DaysUntilDue { get; set; }

    public string? ExternalId { get; set; }

    public virtual ICollection<BranchClient> BranchClients { get; set; } = new List<BranchClient>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
