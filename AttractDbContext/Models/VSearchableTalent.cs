using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableTalent
{
    public int TalentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int TalentBranchId { get; set; }

    public string? FirstnameRev { get; set; }

    public string? LastNameRev { get; set; }

    public string? EmailRev { get; set; }
}
