using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS --  
/// </summary>
public partial class BranchEmployeeTaxSetupPoc
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public string? FormFieldIdentifier { get; set; }

    public string? FormFieldValue { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }
}
