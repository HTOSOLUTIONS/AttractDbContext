using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class UserSignatureDef
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? SignaturePath { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }
}
