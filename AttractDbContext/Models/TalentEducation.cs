using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentEducation
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? InstitutionType { get; set; }

    public string? InstitutionName { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? YearsAttended { get; set; }

    public string? AreaOfStudy { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public bool? Graduated { get; set; }
}
