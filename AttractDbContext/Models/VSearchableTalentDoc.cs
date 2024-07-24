using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableTalentDoc
{
    public int TalentDocId { get; set; }

    public int TalentId { get; set; }

    public int DocumentId { get; set; }

    public string? DocFriendlyName { get; set; }

    public string? DocDescription { get; set; }

    public string? DocType { get; set; }

    public int DocTypeId { get; set; }

    public string DocumentDescrip { get; set; } = null!;

    public bool TalentDocIsActive { get; set; }

    public string? DocumentIdent { get; set; }
}
