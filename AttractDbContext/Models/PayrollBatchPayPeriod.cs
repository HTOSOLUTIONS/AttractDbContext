using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PayrollBatchPayPeriod
{
    public int Id { get; set; }

    public int? BatchId { get; set; }

    public int? PayPeriodId { get; set; }
}
