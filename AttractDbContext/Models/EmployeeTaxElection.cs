using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class EmployeeTaxElection
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? Federalfilingstatus { get; set; }

    public int? Dependents { get; set; }

    public string? Ficaexempt { get; set; }

    public string? Psdcode { get; set; }

    public string? Dualstate { get; set; }

    public string? Multiplejobs { get; set; }

    public string? Federaldependents { get; set; }

    public string? Federalotherincome { get; set; }

    public string? Federaldeductionsamount { get; set; }

    public string? Federalextrawitholding { get; set; }

    public string? Statefilingstatus { get; set; }

    public string? Stateaddlwitholding { get; set; }

    public string? Stateallowances { get; set; }

    public string? Localfilingstatus { get; set; }

    public string? Localallowance { get; set; }

    public string? Localaddlwithholding { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? FederalDependentCredits { get; set; }
}
