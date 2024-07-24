using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllAssignments2
{
    public int TalentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int BranchEmployeeId { get; set; }

    public int AssignmentId { get; set; }

    public DateOnly? JobOrderDate { get; set; }

    public DateOnly? AssignmentDate { get; set; }

    public string? TalentStatus { get; set; }

    public int? AssignmentClientId { get; set; }

    public int AssignmentBranchClientId { get; set; }

    public string? AssignmentClientName { get; set; }

    public int JobOrderId { get; set; }

    public int AssignmentJobSiteId { get; set; }

    public string? AssignmentJobSiteName { get; set; }

    public string? AssignmentAddress1 { get; set; }

    public string? AssignmentAddress2 { get; set; }

    public string? AssignmentCity { get; set; }

    public string? AssignmentStateName { get; set; }

    public string? AssignmentZipCode { get; set; }

    public string? AssignmentContactEmail { get; set; }

    public string? AssignmentDescription { get; set; }

    public bool? AssignmentIsActive { get; set; }

    public DateOnly? JobOrderServiceBeginDate { get; set; }

    public DateOnly? JobOrderServiceEndDate { get; set; }

    public string? JobOrderSupervisorName { get; set; }

    public string? JobOrderDepartmentName { get; set; }

    public string? JobOrderRecruiterId { get; set; }

    public string? JobOrderSalespersonId { get; set; }

    public string? JobOrderJobTitle { get; set; }

    public string? JobOrderContractNumber { get; set; }

    public string? JobOrderPointofContactName { get; set; }

    public string? JobOrderPurchaseOrderNumber { get; set; }

    public decimal? JobOrderLimitDollars { get; set; }

    public decimal? JobOrderLimitHours { get; set; }

    public DateOnly? AssignmentServiceBeginDate { get; set; }

    public DateOnly? AssignmentServiceEndDate { get; set; }

    public string? AssignmentSupervisorName { get; set; }

    public string? AssignmentDepartmentName { get; set; }

    public string? AssignmentRecruiterId { get; set; }

    public string? AssignmentSalespersonId { get; set; }

    public string? AssignmentJobTitle { get; set; }

    public string? AssignmentContractNumber { get; set; }

    public string? AssignmentPointofContactName { get; set; }

    public string? AssignmentPurchaseOrderNumber { get; set; }

    public decimal? AssignmentLimitDollars { get; set; }

    public decimal? AssignmentLimitHours { get; set; }

    public decimal? AssignmentPayRateReg { get; set; }

    public decimal? AssignmentPayRateOt { get; set; }

    public decimal? AssignmentPayRateDouble { get; set; }

    public decimal? AssignmentPayRatePerDiem { get; set; }

    public decimal? AssignmentPayRateHealth { get; set; }

    public decimal? AssignmentBillRateReg { get; set; }

    public decimal? AssignmentBillRateOt { get; set; }

    public decimal? AssignmentBillRateDouble { get; set; }

    public decimal? AssignmentBillRatePerDiem { get; set; }

    public decimal? AssignmentBillRateHealth { get; set; }

    public DateOnly? AssignmentRatesStartDt { get; set; }

    public DateOnly? AssignmentRatesEndDt { get; set; }

    public bool? AssignmentRatesIsActive { get; set; }

    public bool? AssignmentWorkShiftSun { get; set; }

    public bool? AssignmentWorkShiftMon { get; set; }

    public bool? AssignmentWorkShiftTue { get; set; }

    public bool? AssignmentWorkShiftWed { get; set; }

    public bool? AssignmentWorkShiftThu { get; set; }

    public bool? AssignmentWorkShiftFri { get; set; }

    public bool? AssignmentWorkShiftSat { get; set; }

    public string? DaysWorked { get; set; }

    public int? AssignmentShiftScheduleId { get; set; }

    public string? AssignmentName { get; set; }

    public decimal? EmpAnnualWage { get; set; }

    public decimal? EmpHrlyWage { get; set; }

    public decimal? EmpOtwage { get; set; }

    public decimal? EmpDtwage { get; set; }

    public DateTime? EmpWageStartDt { get; set; }

    public DateTime? EmpWageEndDt { get; set; }

    public bool? EmpWageIsActive { get; set; }

    public bool? IsInternalClient { get; set; }

    public int? TenantBranchId { get; set; }

    public DateTime? AssignmentTerminationDt { get; set; }
}
