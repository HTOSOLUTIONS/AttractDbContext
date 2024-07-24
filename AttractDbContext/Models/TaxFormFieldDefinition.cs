using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Tax form fields nationwide, as provided by the payroll tax API 
/// </summary>
public partial class TaxFormFieldDefinition
{
    public int Id { get; set; }

    public string? FormFieldIdentifier { get; set; }

    public string? GeoCodeId { get; set; }

    public string? CountyGeoCodeId { get; set; }

    public string? StateGeoCodeId { get; set; }

    public string? FedGeoCodeId { get; set; }

    public string? SchoolDistrictId { get; set; }

    public DateOnly? StartDt { get; set; }

    public DateOnly? StopDt { get; set; }

    public string? TaxIdentifierId { get; set; }

    public string? TaxName { get; set; }

    public string? FormFieldDescriptiveName { get; set; }

    public string? FormDocumentation { get; set; }

    public string? ReciprocalJurisdictionGeoCodeId { get; set; }

    public string? TaxIdentifier { get; set; }

    public string? ParentFormId { get; set; }
}
