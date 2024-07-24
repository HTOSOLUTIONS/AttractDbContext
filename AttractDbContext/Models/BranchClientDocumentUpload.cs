using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchClientDocumentUpload
{
    public int Id { get; set; }

    public int BranchClientId { get; set; }

    public int DocumentId { get; set; }

    public string? DocFriendlyName { get; set; }

    public string? DocDescription { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? SignDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool IsActive { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime CreatedDtutc { get; set; }

    public string Modifiedbyuserid { get; set; } = null!;

    public DateTime ModifiedDtutc { get; set; }
}
