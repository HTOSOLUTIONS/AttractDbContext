using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS 
/// </summary>
public partial class PayCheckFinalPayDetail
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public bool? IsPaperCheck { get; set; }

    public bool? IsAch { get; set; }

    public bool? IsPayCard { get; set; }

    public decimal? NetPay { get; set; }

    public bool? IsVoid { get; set; }

    public string? CheckNum { get; set; }

    public int? PayAllocationId { get; set; }

    public int? PayCheckId { get; set; }

    public string? RoutingNumEncrypted { get; set; }

    public string? AccountNumEncrypted { get; set; }

    public string? FromAcctNumEncrypted { get; set; }

    public string? FromRoutNumEncrypted { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpLastName { get; set; }

    public string? TaxPayerIdencrypted { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? ZipCode { get; set; }

    public string? EmployeeType { get; set; }

    public string? BankCode { get; set; }

    public string? OfficeCode { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual BranchEmployeePayAllocation? PayAllocation { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual VtStateList? State { get; set; }
}
