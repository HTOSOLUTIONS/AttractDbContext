using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VJobOrderShiftSchedule
{
    public int? JobOrderId { get; set; }

    public int ShiftDefId { get; set; }

    public bool? ShiftDefIsActive { get; set; }

    public int BranchJobOrderShiftId { get; set; }

    public int ScheduleId { get; set; }

    public bool? WorkShiftSun { get; set; }

    public bool? WorkShiftMon { get; set; }

    public bool? WorkShiftTue { get; set; }

    public bool? WorkShiftWed { get; set; }

    public bool? WorkShiftThu { get; set; }

    public bool? WorkShiftFri { get; set; }

    public bool? WorkShiftSat { get; set; }

    public string? DaysWorked { get; set; }

    public DateOnly? JobOrderStartDate { get; set; }

    public bool? JoisActive { get; set; }

    public int? QuantityNeeded { get; set; }

    public bool? ScheduleIsActive { get; set; }

    public string? ShiftName { get; set; }

    public TimeOnly? ShiftStartTime { get; set; }

    public decimal? ShiftDurationHrs { get; set; }

    public decimal? WageAdjustmentAmount { get; set; }

    public decimal? BillAdjustmentAmount { get; set; }

    public decimal? OtbillAdjustmentAmount { get; set; }

    public decimal? DtbillAdjustmentAmount { get; set; }

    public int? ShiftPriority { get; set; }

    public int? ShiftSupervisorContactId { get; set; }

    public string? SupervisorLastName { get; set; }

    public string? SupervisorFirstName { get; set; }

    public decimal? BaseWage { get; set; }

    public decimal? BaseBillable { get; set; }

    public decimal? Otbillable { get; set; }

    public decimal? Dtbillable { get; set; }

    public decimal? EffectiveWage { get; set; }

    public decimal? EffectiveBaseBillable { get; set; }

    public decimal? EffectiveOtbillable { get; set; }

    public decimal? EffectiveDtbillable { get; set; }

    public decimal? EffectiveMargin { get; set; }

    public int? QtyFilled { get; set; }

    public bool? IsInternalClient { get; set; }

    public int? BranchId { get; set; }

    public int TenantId { get; set; }

    public int BranchClientid { get; set; }
}
