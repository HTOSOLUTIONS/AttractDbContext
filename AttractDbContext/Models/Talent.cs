using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// All applicants/employees, etc/ 
/// </summary>
public partial class Talent
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? TaxpayerId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? ZipCode { get; set; }

    public string? MobilePhone { get; set; }

    public string? HomePhone { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? EmergencyContactName { get; set; }

    public string? EmergencyContactPhone { get; set; }

    public string? PreferredName { get; set; }

    public int? GenderId { get; set; }

    public bool? SendSmsupdates { get; set; }

    public bool? SendEmailUpdates { get; set; }

    public string? GeoCodeId { get; set; }

    public string? CreatedbyUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? Status { get; set; }

    public int? LanguageId { get; set; }

    public bool? IsActive { get; set; }

    public string? RecruitedByUserId { get; set; }

    public string? RecruiterId { get; set; }

    public string? MsgThreadId { get; set; }

    public string? MiddleName { get; set; }

    public string? DateOfBirth { get; set; }

    public bool? MethodOfTransportation { get; set; }

    public int? JobMaxDistance { get; set; }

    public virtual ICollection<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();

    public virtual VtStateList? State { get; set; }

    public virtual ICollection<TalentApplicationAddlQuestion> TalentApplicationAddlQuestions { get; set; } = new List<TalentApplicationAddlQuestion>();

    public virtual ICollection<TalentApplicationJobOrderShift> TalentApplicationJobOrderShifts { get; set; } = new List<TalentApplicationJobOrderShift>();

    public virtual ICollection<TalentApplicationStatement> TalentApplicationStatements { get; set; } = new List<TalentApplicationStatement>();

    public virtual ICollection<TalentAtworkHistory> TalentAtworkHistories { get; set; } = new List<TalentAtworkHistory>();

    public virtual ICollection<TalentAvailability> TalentAvailabilities { get; set; } = new List<TalentAvailability>();

    public virtual ICollection<TalentBankAccount> TalentBankAccounts { get; set; } = new List<TalentBankAccount>();

    public virtual ICollection<TalentBranch> TalentBranches { get; set; } = new List<TalentBranch>();

    public virtual ICollection<TalentCertification> TalentCertifications { get; set; } = new List<TalentCertification>();

    public virtual ICollection<TalentConditionalJobOffer> TalentConditionalJobOffers { get; set; } = new List<TalentConditionalJobOffer>();

    public virtual ICollection<TalentDocumentUpload> TalentDocumentUploads { get; set; } = new List<TalentDocumentUpload>();

    public virtual ICollection<TalentEmergencyContact> TalentEmergencyContacts { get; set; } = new List<TalentEmergencyContact>();

    public virtual ICollection<TalentEmploymentHistory> TalentEmploymentHistories { get; set; } = new List<TalentEmploymentHistory>();

    public virtual ICollection<TalentReference> TalentReferences { get; set; } = new List<TalentReference>();

    public virtual ICollection<TalentSkill> TalentSkills { get; set; } = new List<TalentSkill>();

    public virtual ICollection<TalentSupervisor> TalentSupervisors { get; set; } = new List<TalentSupervisor>();

    public virtual ICollection<TalentUser> TalentUsers { get; set; } = new List<TalentUser>();

    public virtual ICollection<TalentWorkPreference> TalentWorkPreferences { get; set; } = new List<TalentWorkPreference>();
}
