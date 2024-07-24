using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates &apos;clients&apos; with branches.  
/// </summary>
public partial class BranchClient
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public bool? IsActive { get; set; }

    public string? PhysAddress1 { get; set; }

    public string? PhysAddress2 { get; set; }

    public string? PhysCity { get; set; }

    public string? PhysState { get; set; }

    public string? PhysZip { get; set; }

    public string? BillAddress1 { get; set; }

    public string? BillAddress2 { get; set; }

    public string? BillCity { get; set; }

    public string? BillState { get; set; }

    public string? BillZip { get; set; }

    public string? BillEmail { get; set; }

    public string? BillPhone { get; set; }

    public string? BillDepartment { get; set; }

    public string? BillPerson { get; set; }

    public string? PrimaryPoCname { get; set; }

    public decimal? CreditLimit { get; set; }

    public string? BranchClientIdent { get; set; }

    public string? BranchClientName { get; set; }

    public DateTime? BecameProspectDt { get; set; }

    public DateTime? ClientActivationDt { get; set; }

    public string? Website { get; set; }

    public string? PrimaryEmailAddress { get; set; }

    public int? WorkersCompCode { get; set; }

    public decimal? AcasurchargeRate { get; set; }

    public int? AcainvoiceFormat { get; set; }

    public bool? AcabillInsuredOnly { get; set; }

    public int? InvoiceFormat { get; set; }

    public int? InvoiceTerms { get; set; }

    public bool? MailInvoice { get; set; }

    public decimal? SalesTaxPct { get; set; }

    public decimal? DiscountPct { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? SalesPersonId { get; set; }

    public string? PrimaryPhone { get; set; }

    public string? WorkCompDetails { get; set; }

    public int? AcasurchargeMethodId { get; set; }

    public string? BillCountry { get; set; }

    public bool? IsActivationRequested { get; set; }

    public bool? IsActivationApproved { get; set; }

    public string? ClientActivatedByUserId { get; set; }

    public DateTime? ClientActivationRequestDt { get; set; }

    public string? ClientActivationRequestedBy { get; set; }

    public string? Ein { get; set; }

    public string? ClientDeactivatedByUserId { get; set; }

    public bool? IsInternal { get; set; }

    public bool? IsDeactivated { get; set; }

    public DateTime? ClientDeactivatedDt { get; set; }

    public int? ClientDeactivatedFutureStatus { get; set; }

    public string? ClientDeactivatedReason { get; set; }

    public string? Description { get; set; }

    public bool? IsActivationDenied { get; set; }

    public string? ExtCustomerId { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual ICollection<BranchClientContact> BranchClientContacts { get; set; } = new List<BranchClientContact>();

    public virtual ICollection<BranchClientCrm> BranchClientCrms { get; set; } = new List<BranchClientCrm>();

    public virtual ICollection<BranchClientCrmstatusHistory> BranchClientCrmstatusHistories { get; set; } = new List<BranchClientCrmstatusHistory>();

    public virtual ICollection<BranchClientPositionDefinition> BranchClientPositionDefinitions { get; set; } = new List<BranchClientPositionDefinition>();

    public virtual ICollection<BranchClientShiftDefinition> BranchClientShiftDefinitions { get; set; } = new List<BranchClientShiftDefinition>();

    public virtual ICollection<BranchClientsRoyaltyRate> BranchClientsRoyaltyRates { get; set; } = new List<BranchClientsRoyaltyRate>();

    public virtual ICollection<BranchClientsWccode> BranchClientsWccodes { get; set; } = new List<BranchClientsWccode>();

    public virtual ICollection<BranchEmployeeClientSubmission> BranchEmployeeClientSubmissions { get; set; } = new List<BranchEmployeeClientSubmission>();

    public virtual ICollection<BranchJobOrder> BranchJobOrders { get; set; } = new List<BranchJobOrder>();

    public virtual Client? Client { get; set; }

    public virtual ICollection<ClientJobSite> ClientJobSites { get; set; } = new List<ClientJobSite>();

    public virtual VtInvoiceTerm? InvoiceTermsNavigation { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
