using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PositivePayManifest
{
    public int Id { get; set; }

    public int? PaycheckId { get; set; }

    public int? CheckNumber { get; set; }

    public decimal? Amount { get; set; }

    public string? FromAccountEncrypted { get; set; }

    public DateOnly? CheckDate { get; set; }

    public bool? IsSentToBank { get; set; }

    public DateTime? SentToBankDt { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsVoid { get; set; }
}
