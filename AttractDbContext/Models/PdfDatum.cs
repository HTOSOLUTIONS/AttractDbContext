using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PdfDatum
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? PdfData { get; set; }

    public DateTime? CreatedDtutc { get; set; }
}
