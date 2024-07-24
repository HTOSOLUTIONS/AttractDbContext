using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TempInvoiceDate
{
    public int Id { get; set; }

    public int? Jobsiteid { get; set; }

    public string? Ponumber { get; set; }

    public DateOnly? Invoicedate { get; set; }
}
