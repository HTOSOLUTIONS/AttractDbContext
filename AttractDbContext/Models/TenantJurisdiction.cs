using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantJurisdiction
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public string? StateId { get; set; }

    public string? OrganizationId { get; set; }

    public bool? IsActive { get; set; }

    public decimal? Wcmultiplier { get; set; }

    public DateOnly? BeginDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? SalesTaxId { get; set; }

    public string? UnemploymentTaxId { get; set; }
}
