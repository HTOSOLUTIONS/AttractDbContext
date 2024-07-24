using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTransaction
{
    public string? AccountNumber { get; set; }

    public string? AccountName { get; set; }

    public int? AccountTypeId { get; set; }

    public int? AccountCategoryId { get; set; }

    public int? AccountClassification { get; set; }

    public bool? AccountIsActive { get; set; }

    public string? ParentAccountNumber { get; set; }

    public string? ParentAccountName { get; set; }

    public int? ParentAccountTypeId { get; set; }

    public int? ParentAccountCategoryId { get; set; }

    public int? ParentAccountClassification { get; set; }

    public bool? ParentAccountIsActive { get; set; }

    public string? BranchName { get; set; }

    public string? BranchIdent { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionDescrip { get; set; }

    public int? TransactionStatus { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public string? TransactionType { get; set; }

    public int TransactionId { get; set; }

    public long LedgerEntryId { get; set; }

    public int AccountId { get; set; }

    public int? ParentAccountId { get; set; }

    public int? BranchId { get; set; }

    public int? DocumentId { get; set; }
}
