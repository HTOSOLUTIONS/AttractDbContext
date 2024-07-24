using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS 
/// </summary>
public partial class TaxTaxis
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? PayPeriodId { get; set; }

    public int? PayCheckId { get; set; }

    public string? TaxIdentifierId { get; set; }

    public string? GeocodeId { get; set; }

    public string? TaxName { get; set; }

    public string? TaxType { get; set; }

    public string? CalculationStatus { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? SupplementalPayTaxAmount { get; set; }

    public decimal? AdjustedGross { get; set; }

    public decimal? AdjustedSupplementalGross { get; set; }

    public decimal? AnnualizedAdjustedCurrentGross { get; set; }

    public decimal? AnnualizedAdjustedSupplementalGross { get; set; }

    public decimal? AnnualizedRegularTax { get; set; }

    public decimal? AnnualizedSupplementalTax { get; set; }

    public decimal? SubjectGrossAmount { get; set; }

    public decimal? TaxableGross { get; set; }

    public decimal? TaxableTips { get; set; }

    public string? UtilizedAlternativeCalculationCode { get; set; }

    public decimal? UtilizedBaseAmount { get; set; }

    public string? CalculationMethod { get; set; }

    public decimal? UtilizedExemptAmount { get; set; }

    public string? FilingStatusId { get; set; }

    public decimal? UtilizedRate { get; set; }

    public decimal? UtilizedSupplementalRate { get; set; }

    public string? Recalculation { get; set; }

    public string? UtilizedSupplementalPayTypeTreatment { get; set; }

    public decimal? UtilizedMaximumDeductionAmount { get; set; }

    public string? UtilizedSchoolDistrictId { get; set; }

    public string? UtilizedJurisdictionTreatmentInteraction { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual BranchPayPeriod? PayPeriod { get; set; }
}
