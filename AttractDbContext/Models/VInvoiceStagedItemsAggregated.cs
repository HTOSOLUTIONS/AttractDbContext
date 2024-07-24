using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VInvoiceStagedItemsAggregated
{
    public int? PayPeriodId { get; set; }

    public int? PayCheckId { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeFirstName { get; set; }

    public string? EmployeeLastName { get; set; }

    public int? ItemTypeId { get; set; }

    public string? ItemTypeName { get; set; }

    public int? JobSiteId { get; set; }

    public string? JobSiteName { get; set; }

    public string? DepartmentName { get; set; }

    public int? BranchClientId { get; set; }

    public string? BranchClientName { get; set; }

    public decimal? Discount { get; set; }

    public int? BranchId { get; set; }

    public int? ShiftDefinitionId { get; set; }

    public string? ShiftName { get; set; }

    public bool? IsSubmitted { get; set; }

    public bool? IsApproved { get; set; }

    public int? InvoiceId { get; set; }

    public int? TimeCardId { get; set; }

    public int InvoiceCreated { get; set; }

    public int? BillToEmployeeAssignmentId { get; set; }

    public int JobOrderId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? BillRate { get; set; }

    public decimal? SubtotalBillable { get; set; }

    public decimal? PayRate { get; set; }

    public decimal? TotalPayable { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? Descrip { get; set; }

    public int ItemId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public decimal? SalesTaxPct { get; set; }

    public decimal? SalesTaxAmt { get; set; }

    public decimal? AcasurchargeRate { get; set; }

    public decimal? AcasurchargeTotal { get; set; }

    public decimal? NetTotal { get; set; }
}
