using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Job Orders associates client job site, branch, and creates an order for positions to be filled 
/// </summary>
public partial class BranchJobOrder
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? ServiceBeginDate { get; set; }

    public DateOnly? ServiceEndDate { get; set; }

    public string? SupervisorName { get; set; }

    public string? DepartmentName { get; set; }

    public string? RecruiterId { get; set; }

    public string? SalespersonId { get; set; }

    public string? JobTitle { get; set; }

    public string? ContractNumber { get; set; }

    public string? PointofContactName { get; set; }

    public string? JobOrderDescription { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public decimal? LimitDollars { get; set; }

    public decimal? LimitHours { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? JobSiteId { get; set; }

    public int? PositionId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDirectHire { get; set; }

    public int? WccodeId { get; set; }

    public int? ApplicationDefInstanceId { get; set; }

    public int? JobOrderTypeId { get; set; }

    public string? JobCategory { get; set; }

    public string? JobApplyUrl { get; set; }

    public int? PointOfContactId { get; set; }

    public DateOnly? PublishDate { get; set; }

    public DateOnly? UnpublishDate { get; set; }

    public virtual ICollection<AccountInvite> AccountInvites { get; set; } = new List<AccountInvite>();

    public virtual BranchClient? BranchClient { get; set; }

    public virtual ICollection<BranchEmployeeAssignment> BranchEmployeeAssignments { get; set; } = new List<BranchEmployeeAssignment>();

    public virtual ICollection<BranchJobOrderDirectHireDetail> BranchJobOrderDirectHireDetails { get; set; } = new List<BranchJobOrderDirectHireDetail>();

    public virtual ICollection<BranchJobOrderTalentVerifyConfig> BranchJobOrderTalentVerifyConfigs { get; set; } = new List<BranchJobOrderTalentVerifyConfig>();

    public virtual ICollection<JobOrderSkillsNeeded> JobOrderSkillsNeededs { get; set; } = new List<JobOrderSkillsNeeded>();

    public virtual VtJobOrderType? JobOrderType { get; set; }

    public virtual ClientJobSite? JobSite { get; set; }

    public virtual ICollection<TalentApplicationJobOrderShift> TalentApplicationJobOrderShifts { get; set; } = new List<TalentApplicationJobOrderShift>();
}
