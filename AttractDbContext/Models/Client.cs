using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// High level definition of a Client - depending on business rules, we could allow tenants to access data on clients that are not theirs.  
/// </summary>
public partial class Client
{
    public int Id { get; set; }

    public string? ClientName { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public int? ParentClientId { get; set; }

    public virtual ICollection<BranchClient> BranchClients { get; set; } = new List<BranchClient>();
}
