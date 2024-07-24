using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentDrugScreen
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public string? SpecimenIdent { get; set; }

    public int? ScreeningReasonId { get; set; }

    public int? ScreeningTypeId { get; set; }

    public DateOnly? CollectionDate { get; set; }

    public TimeOnly? CollectionTime { get; set; }

    public int? ResultTemp { get; set; }

    public string? ResultLotNum { get; set; }

    public string? Remarks { get; set; }

    public string? CollectedByName { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public int? JobOrderId { get; set; }

    public string? TesterId { get; set; }

    public int? ProviderId { get; set; }
}
