using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VDirectHireJobOrder
{
    public int JobOrderId { get; set; }

    public int? BranchClientId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? SupervisorName { get; set; }

    public string? DepartmentName { get; set; }

    public string? RecruiterId { get; set; }

    public string? SalespersonId { get; set; }

    public string? JobTitle { get; set; }

    public string? ContractNumber { get; set; }

    public string? PointofContactName { get; set; }

    public string? JobOrderDescription { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? JobSiteId { get; set; }

    public int? PositionId { get; set; }

    public bool? IsActive { get; set; }

    public string? JobSiteName { get; set; }

    public string? JobSiteIdent { get; set; }

    public string? BillAddress1 { get; set; }

    public string? BillAddress2 { get; set; }

    public string? BillCity { get; set; }

    public string? BillDepartment { get; set; }

    public string? BillEmail { get; set; }

    public string? BillPerson { get; set; }

    public string? BillPhone { get; set; }

    public string? BillState { get; set; }

    public string? BillZip { get; set; }

    public string? DirectHirePositionName { get; set; }

    public int? WagePeriod { get; set; }

    public decimal? WageAmountPerPeriod { get; set; }

    public int? BillingMethod { get; set; }

    public decimal? FlatFeeAmount { get; set; }

    public decimal? PercentageAmount { get; set; }

    public int? QuantityNeeded { get; set; }

    public int? BranchId { get; set; }

    public string? BranchClientName { get; set; }

    public string? BranchName { get; set; }
}
