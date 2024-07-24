using System;
using System.Collections.Generic;
using AttractDbContext.Models;
using Microsoft.EntityFrameworkCore;

namespace AttractDbContext.Data;

public partial class AttractDbContext : DbContext
{
    public AttractDbContext()
    {
    }

    public AttractDbContext(DbContextOptions<AttractDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ALog> ALogs { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountInvite> AccountInvites { get; set; }

    public virtual DbSet<AppRole> AppRoles { get; set; }

    public virtual DbSet<AppRolesCreationPermission> AppRolesCreationPermissions { get; set; }

    public virtual DbSet<ApplicationDefInstance> ApplicationDefInstances { get; set; }

    public virtual DbSet<ApplicationDefInstanceContent> ApplicationDefInstanceContents { get; set; }

    public virtual DbSet<ApplicationDefInstanceInterviewQuestionConfig> ApplicationDefInstanceInterviewQuestionConfigs { get; set; }

    public virtual DbSet<ApplicationDefInstanceStep> ApplicationDefInstanceSteps { get; set; }

    public virtual DbSet<ApplicationDefInstanceSubStep> ApplicationDefInstanceSubSteps { get; set; }

    public virtual DbSet<ApplicationTenantInterviewQuestion> ApplicationTenantInterviewQuestions { get; set; }

    public virtual DbSet<ApprolePolicy> ApprolePolicies { get; set; }

    public virtual DbSet<AssignCache> AssignCaches { get; set; }

    public virtual DbSet<AuditLogDetail> AuditLogDetails { get; set; }

    public virtual DbSet<AuditLogHeader> AuditLogHeaders { get; set; }

    public virtual DbSet<AuditLogTablePrimaryKey> AuditLogTablePrimaryKeys { get; set; }

    public virtual DbSet<BranchApplicationAddlQuestion> BranchApplicationAddlQuestions { get; set; }

    public virtual DbSet<BranchApplicationStatement> BranchApplicationStatements { get; set; }

    public virtual DbSet<BranchClient> BranchClients { get; set; }

    public virtual DbSet<BranchClientConfig> BranchClientConfigs { get; set; }

    public virtual DbSet<BranchClientContact> BranchClientContacts { get; set; }

    public virtual DbSet<BranchClientCrm> BranchClientCrms { get; set; }

    public virtual DbSet<BranchClientCrmstatusHistory> BranchClientCrmstatusHistories { get; set; }

    public virtual DbSet<BranchClientDocumentUpload> BranchClientDocumentUploads { get; set; }

    public virtual DbSet<BranchClientPositionDefSkill> BranchClientPositionDefSkills { get; set; }

    public virtual DbSet<BranchClientPositionDefinition> BranchClientPositionDefinitions { get; set; }

    public virtual DbSet<BranchClientShiftDefinition> BranchClientShiftDefinitions { get; set; }

    public virtual DbSet<BranchClientSkill> BranchClientSkills { get; set; }

    public virtual DbSet<BranchClientsRoyaltyRate> BranchClientsRoyaltyRates { get; set; }

    public virtual DbSet<BranchClientsWccode> BranchClientsWccodes { get; set; }

    public virtual DbSet<BranchEmployee> BranchEmployees { get; set; }

    public virtual DbSet<BranchEmployeeAssignment> BranchEmployeeAssignments { get; set; }

    public virtual DbSet<BranchEmployeeAssignmentRate> BranchEmployeeAssignmentRates { get; set; }

    public virtual DbSet<BranchEmployeeAssignmentWorkSchedule> BranchEmployeeAssignmentWorkSchedules { get; set; }

    public virtual DbSet<BranchEmployeeClientSubmission> BranchEmployeeClientSubmissions { get; set; }

    public virtual DbSet<BranchEmployeeDeductionInstance> BranchEmployeeDeductionInstances { get; set; }

    public virtual DbSet<BranchEmployeeDeductionInstanceItem> BranchEmployeeDeductionInstanceItems { get; set; }

    public virtual DbSet<BranchEmployeePayAllocation> BranchEmployeePayAllocations { get; set; }

    public virtual DbSet<BranchEmployeePaycheckPreference> BranchEmployeePaycheckPreferences { get; set; }

    public virtual DbSet<BranchEmployeeTaxSetupPoc> BranchEmployeeTaxSetupPocs { get; set; }

    public virtual DbSet<BranchEmployeeTimeOffAccrual> BranchEmployeeTimeOffAccruals { get; set; }

    public virtual DbSet<BranchEmployeeTimeOffPlan> BranchEmployeeTimeOffPlans { get; set; }

    public virtual DbSet<BranchEmployeeTimeOffRequest> BranchEmployeeTimeOffRequests { get; set; }

    public virtual DbSet<BranchEmployeeWage> BranchEmployeeWages { get; set; }

    public virtual DbSet<BranchJobOrder> BranchJobOrders { get; set; }

    public virtual DbSet<BranchJobOrderAddlQuestionConfig> BranchJobOrderAddlQuestionConfigs { get; set; }

    public virtual DbSet<BranchJobOrderClientPaperwork> BranchJobOrderClientPaperworks { get; set; }

    public virtual DbSet<BranchJobOrderDirectHireDetail> BranchJobOrderDirectHireDetails { get; set; }

    public virtual DbSet<BranchJobOrderShiftSchedule> BranchJobOrderShiftSchedules { get; set; }

    public virtual DbSet<BranchJobOrderSkill> BranchJobOrderSkills { get; set; }

    public virtual DbSet<BranchJobOrderStatementsConfig> BranchJobOrderStatementsConfigs { get; set; }

    public virtual DbSet<BranchJobOrderTalentVerifyConfig> BranchJobOrderTalentVerifyConfigs { get; set; }

    public virtual DbSet<BranchJobOrdersShift> BranchJobOrdersShifts { get; set; }

    public virtual DbSet<BranchPayPeriod> BranchPayPeriods { get; set; }

    public virtual DbSet<BranchPayPeriodTemplate> BranchPayPeriodTemplates { get; set; }

    public virtual DbSet<BranchTimeOffPlan> BranchTimeOffPlans { get; set; }

    public virtual DbSet<BranchTimeOffType> BranchTimeOffTypes { get; set; }

    public virtual DbSet<BranchWorkersCompCode> BranchWorkersCompCodes { get; set; }

    public virtual DbSet<ChartOfAccountsDefinition> ChartOfAccountsDefinitions { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientJobSite> ClientJobSites { get; set; }

    public virtual DbSet<ClientJobSiteWorkersCompCode> ClientJobSiteWorkersCompCodes { get; set; }

    public virtual DbSet<ClientJobsiteContact> ClientJobsiteContacts { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<EmployeeTaxElection> EmployeeTaxElections { get; set; }

    public virtual DbSet<EmployeeTimeCard> EmployeeTimeCards { get; set; }

    public virtual DbSet<EmployeeTimeCardAggregateTime> EmployeeTimeCardAggregateTimes { get; set; }

    public virtual DbSet<EmployeeTimeWorkedDetail> EmployeeTimeWorkedDetails { get; set; }

    public virtual DbSet<EmployeeTimeWorkedDetailsAudit> EmployeeTimeWorkedDetailsAudits { get; set; }

    public virtual DbSet<EmployeeTimeWorkedShift> EmployeeTimeWorkedShifts { get; set; }

    public virtual DbSet<GeoCode> GeoCodes { get; set; }

    public virtual DbSet<InvoicableItem> InvoicableItems { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }

    public virtual DbSet<InvoiceRoyalty> InvoiceRoyalties { get; set; }

    public virtual DbSet<JobOrderSkillsNeeded> JobOrderSkillsNeededs { get; set; }

    public virtual DbSet<Jobordercache> Jobordercaches { get; set; }

    public virtual DbSet<LedgerEntry> LedgerEntries { get; set; }

    public virtual DbSet<PayCheck> PayChecks { get; set; }

    public virtual DbSet<PayCheckFinalPayDetail> PayCheckFinalPayDetails { get; set; }

    public virtual DbSet<PayChecksDeduction> PayChecksDeductions { get; set; }

    public virtual DbSet<PayChecksPay> PayChecksPays { get; set; }

    public virtual DbSet<PayChecksTimeDetailsAssoc> PayChecksTimeDetailsAssocs { get; set; }

    public virtual DbSet<PayrollBatch> PayrollBatches { get; set; }

    public virtual DbSet<PayrollBatchPayPeriod> PayrollBatchPayPeriods { get; set; }

    public virtual DbSet<PayrollCheckSummary> PayrollCheckSummaries { get; set; }

    public virtual DbSet<PayrollCheckSummaryLog> PayrollCheckSummaryLogs { get; set; }

    public virtual DbSet<PdfDatum> PdfData { get; set; }

    public virtual DbSet<PositivePayManifest> PositivePayManifests { get; set; }

    public virtual DbSet<PreUser> PreUsers { get; set; }

    public virtual DbSet<QueryWorstTsql> QueryWorstTsqls { get; set; }

    public virtual DbSet<ReportInstance> ReportInstances { get; set; }

    public virtual DbSet<SkillGroup> SkillGroups { get; set; }

    public virtual DbSet<Talent> Talents { get; set; }

    public virtual DbSet<TalentApplicationAddlQuestion> TalentApplicationAddlQuestions { get; set; }

    public virtual DbSet<TalentApplicationJobOrderShift> TalentApplicationJobOrderShifts { get; set; }

    public virtual DbSet<TalentApplicationStatement> TalentApplicationStatements { get; set; }

    public virtual DbSet<TalentAtworkHistory> TalentAtworkHistories { get; set; }

    public virtual DbSet<TalentAvailability> TalentAvailabilities { get; set; }

    public virtual DbSet<TalentBankAccount> TalentBankAccounts { get; set; }

    public virtual DbSet<TalentBranch> TalentBranches { get; set; }

    public virtual DbSet<TalentCertification> TalentCertifications { get; set; }

    public virtual DbSet<TalentConditionalJobOffer> TalentConditionalJobOffers { get; set; }

    public virtual DbSet<TalentDnr> TalentDnrs { get; set; }

    public virtual DbSet<TalentDocumentUpload> TalentDocumentUploads { get; set; }

    public virtual DbSet<TalentDrugScreen> TalentDrugScreens { get; set; }

    public virtual DbSet<TalentDrugScreensResult> TalentDrugScreensResults { get; set; }

    public virtual DbSet<TalentEducation> TalentEducations { get; set; }

    public virtual DbSet<TalentEmergencyContact> TalentEmergencyContacts { get; set; }

    public virtual DbSet<TalentEmploymentHistory> TalentEmploymentHistories { get; set; }

    public virtual DbSet<TalentJobOrderApplicationInstance> TalentJobOrderApplicationInstances { get; set; }

    public virtual DbSet<TalentJobOrderApplicationInstanceStep> TalentJobOrderApplicationInstanceSteps { get; set; }

    public virtual DbSet<TalentJobOrderApplicationInstanceSubStep> TalentJobOrderApplicationInstanceSubSteps { get; set; }

    public virtual DbSet<TalentJobOrderApplicationInterviewQuestion> TalentJobOrderApplicationInterviewQuestions { get; set; }

    public virtual DbSet<TalentJobOrderDirectHire> TalentJobOrderDirectHires { get; set; }

    public virtual DbSet<TalentProfileVerifySectionConfig> TalentProfileVerifySectionConfigs { get; set; }

    public virtual DbSet<TalentProfileVerifySectionDef> TalentProfileVerifySectionDefs { get; set; }

    public virtual DbSet<TalentReference> TalentReferences { get; set; }

    public virtual DbSet<TalentSkill> TalentSkills { get; set; }

    public virtual DbSet<TalentSupervisor> TalentSupervisors { get; set; }

    public virtual DbSet<TalentUser> TalentUsers { get; set; }

    public virtual DbSet<TalentWorkPreference> TalentWorkPreferences { get; set; }

    public virtual DbSet<TaxCompensation> TaxCompensations { get; set; }

    public virtual DbSet<TaxFormDatum> TaxFormData { get; set; }

    public virtual DbSet<TaxFormFieldDefinition> TaxFormFieldDefinitions { get; set; }

    public virtual DbSet<TaxTaxis> TaxTaxes { get; set; }

    public virtual DbSet<TaxVersion> TaxVersions { get; set; }

    public virtual DbSet<TbIxMissing> TbIxMissings { get; set; }

    public virtual DbSet<TempInvoiceDate> TempInvoiceDates { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TenantApplicationTemplate> TenantApplicationTemplates { get; set; }

    public virtual DbSet<TenantApplicationTemplateStep> TenantApplicationTemplateSteps { get; set; }

    public virtual DbSet<TenantApplicationTemplateSubStep> TenantApplicationTemplateSubSteps { get; set; }

    public virtual DbSet<TenantBankAccount> TenantBankAccounts { get; set; }

    public virtual DbSet<TenantBranch> TenantBranches { get; set; }

    public virtual DbSet<TenantBranchesRoyaltyRate> TenantBranchesRoyaltyRates { get; set; }

    public virtual DbSet<TenantConfig> TenantConfigs { get; set; }

    public virtual DbSet<TenantJurisdiction> TenantJurisdictions { get; set; }

    public virtual DbSet<TenantRegion> TenantRegions { get; set; }

    public virtual DbSet<TenantRoyaltyRatesDiscount> TenantRoyaltyRatesDiscounts { get; set; }

    public virtual DbSet<TenantWorkCompCode> TenantWorkCompCodes { get; set; }

    public virtual DbSet<TenantWorkCompCodesBak> TenantWorkCompCodesBaks { get; set; }

    public virtual DbSet<TenantWorkCompCodesState> TenantWorkCompCodesStates { get; set; }

    public virtual DbSet<TenantsRoyaltyRate> TenantsRoyaltyRates { get; set; }

    public virtual DbSet<TenantworkcompcodesStatesBak> TenantworkcompcodesStatesBaks { get; set; }

    public virtual DbSet<TestingFormSubmitsPto> TestingFormSubmitsPtos { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccountInvite> UserAccountInvites { get; set; }

    public virtual DbSet<UserNotificationPreference> UserNotificationPreferences { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSignatureDef> UserSignatureDefs { get; set; }

    public virtual DbSet<UsersAccountInvite> UsersAccountInvites { get; set; }

    public virtual DbSet<VAllApplicationDefinitionConfig> VAllApplicationDefinitionConfigs { get; set; }

    public virtual DbSet<VAllAssignment> VAllAssignments { get; set; }

    public virtual DbSet<VAllAssignments2> VAllAssignments2s { get; set; }

    public virtual DbSet<VAllBranchEmployee> VAllBranchEmployees { get; set; }

    public virtual DbSet<VAllInvoice> VAllInvoices { get; set; }

    public virtual DbSet<VAllInvoicesAggregatedByClient> VAllInvoicesAggregatedByClients { get; set; }

    public virtual DbSet<VAllPayCheck> VAllPayChecks { get; set; }

    public virtual DbSet<VAllPayChecksPayOutput> VAllPayChecksPayOutputs { get; set; }

    public virtual DbSet<VAllPayChecksPaysNormalized> VAllPayChecksPaysNormalizeds { get; set; }

    public virtual DbSet<VAllSkill> VAllSkills { get; set; }

    public virtual DbSet<VAllSkillsWithSynonym> VAllSkillsWithSynonyms { get; set; }

    public virtual DbSet<VAllTalentApplicationInstance> VAllTalentApplicationInstances { get; set; }

    public virtual DbSet<VAllTalentWithBranch> VAllTalentWithBranches { get; set; }

    public virtual DbSet<VAllTalentWithEmployeeAndUserInfo> VAllTalentWithEmployeeAndUserInfos { get; set; }

    public virtual DbSet<VAllTimeWorkedEntriesComputed> VAllTimeWorkedEntriesComputeds { get; set; }

    public virtual DbSet<VAllTimeWorkedEntry> VAllTimeWorkedEntries { get; set; }

    public virtual DbSet<VAllTimecardAggregateMaster> VAllTimecardAggregateMasters { get; set; }

    public virtual DbSet<VAllTimecardAggregateMasterVertical> VAllTimecardAggregateMasterVerticals { get; set; }

    public virtual DbSet<VAllTransaction> VAllTransactions { get; set; }

    public virtual DbSet<VAllUserComponentClaim> VAllUserComponentClaims { get; set; }

    public virtual DbSet<VAllUsersWithRole> VAllUsersWithRoles { get; set; }

    public virtual DbSet<VAllUsersWithRolesFlat> VAllUsersWithRolesFlats { get; set; }

    public virtual DbSet<VApplyJobOrderAppHeadersByAppDefId> VApplyJobOrderAppHeadersByAppDefIds { get; set; }

    public virtual DbSet<VBranchEmployeeWorkSchedule> VBranchEmployeeWorkSchedules { get; set; }

    public virtual DbSet<VBranchTimeOffConfig> VBranchTimeOffConfigs { get; set; }

    public virtual DbSet<VClientJobSite> VClientJobSites { get; set; }

    public virtual DbSet<VClientJobSiteBillingInfo> VClientJobSiteBillingInfos { get; set; }

    public virtual DbSet<VCustomer> VCustomers { get; set; }

    public virtual DbSet<VDirectHireJobOrder> VDirectHireJobOrders { get; set; }

    public virtual DbSet<VInvoiceStagedItem> VInvoiceStagedItems { get; set; }

    public virtual DbSet<VInvoiceStagedItemsAggregated> VInvoiceStagedItemsAggregateds { get; set; }

    public virtual DbSet<VJobOrderShiftSchedule> VJobOrderShiftSchedules { get; set; }

    public virtual DbSet<VParentPayrollAggregate> VParentPayrollAggregates { get; set; }

    public virtual DbSet<VParentPayrollAggregateByPayMethod> VParentPayrollAggregateByPayMethods { get; set; }

    public virtual DbSet<VPayflowPayAmountsVsBillAmount> VPayflowPayAmountsVsBillAmounts { get; set; }

    public virtual DbSet<VSearchBranchClientsAll> VSearchBranchClientsAlls { get; set; }

    public virtual DbSet<VSearchableBranchPayroll> VSearchableBranchPayrolls { get; set; }

    public virtual DbSet<VSearchableInvoice> VSearchableInvoices { get; set; }

    public virtual DbSet<VSearchableJobOrdersAll> VSearchableJobOrdersAlls { get; set; }

    public virtual DbSet<VSearchableTalent> VSearchableTalents { get; set; }

    public virtual DbSet<VSearchableTalentDoc> VSearchableTalentDocs { get; set; }

    public virtual DbSet<VSearchableTalentSkill> VSearchableTalentSkills { get; set; }

    public virtual DbSet<VSearchableTenant> VSearchableTenants { get; set; }

    public virtual DbSet<VTalentProfileVerifyDefaultConfig> VTalentProfileVerifyDefaultConfigs { get; set; }

    public virtual DbSet<VTenantBranchOrganization> VTenantBranchOrganizations { get; set; }

    public virtual DbSet<VTenantWccall> VTenantWccalls { get; set; }

    public virtual DbSet<VTimeCardsDaily> VTimeCardsDailies { get; set; }

    public virtual DbSet<VWorkCompCodesParentTenant> VWorkCompCodesParentTenants { get; set; }

    public virtual DbSet<VertexForm> VertexForms { get; set; }

    public virtual DbSet<VtAcainvoiceFormat> VtAcainvoiceFormats { get; set; }

    public virtual DbSet<VtAcasurchargeMethod> VtAcasurchargeMethods { get; set; }

    public virtual DbSet<VtAcceptedDeclinedOffer> VtAcceptedDeclinedOffers { get; set; }

    public virtual DbSet<VtAccountCategory> VtAccountCategories { get; set; }

    public virtual DbSet<VtAccountClassification> VtAccountClassifications { get; set; }

    public virtual DbSet<VtAccountNormalBalance> VtAccountNormalBalances { get; set; }

    public virtual DbSet<VtAccountReportType> VtAccountReportTypes { get; set; }

    public virtual DbSet<VtAccountType> VtAccountTypes { get; set; }

    public virtual DbSet<VtActiveInactive> VtActiveInactives { get; set; }

    public virtual DbSet<VtApprovalStatus> VtApprovalStatuses { get; set; }

    public virtual DbSet<VtAssignmentTerminationReason> VtAssignmentTerminationReasons { get; set; }

    public virtual DbSet<VtBankAccountType> VtBankAccountTypes { get; set; }

    public virtual DbSet<VtCheckVoidReason> VtCheckVoidReasons { get; set; }

    public virtual DbSet<VtClientDeactivationType> VtClientDeactivationTypes { get; set; }

    public virtual DbSet<VtClientOppValue> VtClientOppValues { get; set; }

    public virtual DbSet<VtDate> VtDates { get; set; }

    public virtual DbSet<VtDirectHireBillingMethod> VtDirectHireBillingMethods { get; set; }

    public virtual DbSet<VtDocumentType> VtDocumentTypes { get; set; }

    public virtual DbSet<VtDocumentTypeTemplate> VtDocumentTypeTemplates { get; set; }

    public virtual DbSet<VtDrugScreenProvider> VtDrugScreenProviders { get; set; }

    public virtual DbSet<VtDrugScreenReason> VtDrugScreenReasons { get; set; }

    public virtual DbSet<VtDrugScreenResult> VtDrugScreenResults { get; set; }

    public virtual DbSet<VtDrugScreenSpecimenType> VtDrugScreenSpecimenTypes { get; set; }

    public virtual DbSet<VtEduInstitutionType> VtEduInstitutionTypes { get; set; }

    public virtual DbSet<VtEmployeeTerminationReason> VtEmployeeTerminationReasons { get; set; }

    public virtual DbSet<VtEmploymentType> VtEmploymentTypes { get; set; }

    public virtual DbSet<VtGender> VtGenders { get; set; }

    public virtual DbSet<VtInterviewLocation> VtInterviewLocations { get; set; }

    public virtual DbSet<VtInviteType> VtInviteTypes { get; set; }

    public virtual DbSet<VtInvoiceDeliveryFormat> VtInvoiceDeliveryFormats { get; set; }

    public virtual DbSet<VtInvoiceTerm> VtInvoiceTerms { get; set; }

    public virtual DbSet<VtInvoiceType> VtInvoiceTypes { get; set; }

    public virtual DbSet<VtJobOrderApplicationStep> VtJobOrderApplicationSteps { get; set; }

    public virtual DbSet<VtJobOrderApplicationSubStep> VtJobOrderApplicationSubSteps { get; set; }

    public virtual DbSet<VtJobOrderCategory> VtJobOrderCategories { get; set; }

    public virtual DbSet<VtJobOrderStatus> VtJobOrderStatuses { get; set; }

    public virtual DbSet<VtJobOrderType> VtJobOrderTypes { get; set; }

    public virtual DbSet<VtLanguage> VtLanguages { get; set; }

    public virtual DbSet<VtNum1to5> VtNum1to5s { get; set; }

    public virtual DbSet<VtOptInOut> VtOptInOuts { get; set; }

    public virtual DbSet<VtPayCyclePeriod> VtPayCyclePeriods { get; set; }

    public virtual DbSet<VtPayMethod> VtPayMethods { get; set; }

    public virtual DbSet<VtPayTypeAccountCrosswalk> VtPayTypeAccountCrosswalks { get; set; }

    public virtual DbSet<VtPaycheckAllocationType> VtPaycheckAllocationTypes { get; set; }

    public virtual DbSet<VtPayrollDeductionGroup> VtPayrollDeductionGroups { get; set; }

    public virtual DbSet<VtPayrollDeductionMethod> VtPayrollDeductionMethods { get; set; }

    public virtual DbSet<VtPayrollDeductionPayer> VtPayrollDeductionPayers { get; set; }

    public virtual DbSet<VtPayrollDeductionType> VtPayrollDeductionTypes { get; set; }

    public virtual DbSet<VtPayrollDeductionTypesBranchAssoc> VtPayrollDeductionTypesBranchAssocs { get; set; }

    public virtual DbSet<VtPayrollPayType> VtPayrollPayTypes { get; set; }

    public virtual DbSet<VtPayrollPayTypesBranchAssoc> VtPayrollPayTypesBranchAssocs { get; set; }

    public virtual DbSet<VtPaystubHandling> VtPaystubHandlings { get; set; }

    public virtual DbSet<VtPrePost> VtPrePosts { get; set; }

    public virtual DbSet<VtPriorityLevel> VtPriorityLevels { get; set; }

    public virtual DbSet<VtProspectStatus> VtProspectStatuses { get; set; }

    public virtual DbSet<VtReportType> VtReportTypes { get; set; }

    public virtual DbSet<VtSkill> VtSkills { get; set; }

    public virtual DbSet<VtSkillSynonym> VtSkillSynonyms { get; set; }

    public virtual DbSet<VtSkillsGroupDefinition> VtSkillsGroupDefinitions { get; set; }

    public virtual DbSet<VtStateList> VtStateLists { get; set; }

    public virtual DbSet<VtStateOvertimeRule> VtStateOvertimeRules { get; set; }

    public virtual DbSet<VtTalentScheduleAvailability> VtTalentScheduleAvailabilities { get; set; }

    public virtual DbSet<VtTaxExtraWithholdingType> VtTaxExtraWithholdingTypes { get; set; }

    public virtual DbSet<VtTaxFederalFilingStatus> VtTaxFederalFilingStatuses { get; set; }

    public virtual DbSet<VtTaxLocalFilingStatus> VtTaxLocalFilingStatuses { get; set; }

    public virtual DbSet<VtTaxStateFilingStatus> VtTaxStateFilingStatuses { get; set; }

    public virtual DbSet<VtTimeBy15Minute> VtTimeBy15Minutes { get; set; }

    public virtual DbSet<VtTimeOffAccrualFrequency> VtTimeOffAccrualFrequencies { get; set; }

    public virtual DbSet<VtTransactionStatus> VtTransactionStatuses { get; set; }

    public virtual DbSet<VtUiLanguage> VtUiLanguages { get; set; }

    public virtual DbSet<VtWagePeriod> VtWagePeriods { get; set; }

    public virtual DbSet<VtWcfootnoteId> VtWcfootnoteIds { get; set; }

    public virtual DbSet<VtWchazardGroup> VtWchazardGroups { get; set; }

    public virtual DbSet<VtWcindustryGroup> VtWcindustryGroups { get; set; }

    public virtual DbSet<VtWorkShift> VtWorkShifts { get; set; }

    public virtual DbSet<VtYesNo> VtYesNos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS22;Initial Catalog=greenfield_dvt_loaded_20240703184206;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ALog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("a_log");

            entity.Property(e => e.Jsondata).HasColumnName("jsondata");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChartOfA__3213E83FE1263C0F");

            entity.ToTable("Accounts", "acc", tb => tb.HasComment("Row by row detail on chart of accounts - FK to ChartofAccountsDefintion"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");
            entity.Property(e => e.AccountDefinition).HasMaxLength(1000);
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            entity.Property(e => e.CoAdefId).HasColumnName("CoADefID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ParentAccountId).HasColumnName("ParentAccountID");
            entity.Property(e => e.StatementName).HasMaxLength(100);

            entity.HasOne(d => d.AccountCategory).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountCategoryId)
                .HasConstraintName("FK__ChartOfAc__Accou__0A338187");

            entity.HasOne(d => d.AccountClassificationNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountClassification)
                .HasConstraintName("FK__ChartOfAc__Accou__0B27A5C0");

            entity.HasOne(d => d.AccountType).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountTypeId)
                .HasConstraintName("FK__ChartOfAc__Accou__0E04126B");

            entity.HasOne(d => d.CoAdef).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CoAdefId)
                .HasConstraintName("FK__ChartOfAc__CoADe__093F5D4E");
        });

        modelBuilder.Entity<AccountInvite>(entity =>
        {
            entity.ToTable("AccountInvite");

            entity.Property(e => e.Id)
                .HasMaxLength(500)
                .HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(100)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.InviteType).HasMaxLength(100);
            entity.Property(e => e.InvitedByUserId)
                .HasMaxLength(100)
                .HasColumnName("InvitedByUserID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(100)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");

            entity.HasOne(d => d.JobOrder).WithMany(p => p.AccountInvites)
                .HasForeignKey(d => d.JobOrderId)
                .HasConstraintName("FK_AccountInvite_JobOrder");
        });

        modelBuilder.Entity<AppRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppRoles__3213E83F07346B6B");

            entity.ToTable(tb => tb.HasComment("All roles in use in the application. This is dimensional data. "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsChildRole)
                .HasDefaultValue(false)
                .HasColumnName("isChildRole");
            entity.Property(e => e.IsParentalRole)
                .HasDefaultValue(false)
                .HasColumnName("isParentalRole");
            entity.Property(e => e.RoleActions).HasColumnName("role_actions");
            entity.Property(e => e.RoleDescription)
                .HasMaxLength(500)
                .HasColumnName("role_description");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<AppRolesCreationPermission>(entity =>
        {
            entity.HasKey(e => new { e.AppRoleId, e.AppRoleIdcanCreate }).HasName("PK_approlescreationpermission");

            entity.ToTable("AppRolesCreationPermission");

            entity.Property(e => e.AppRoleId).HasColumnName("AppRoleID");
            entity.Property(e => e.AppRoleIdcanCreate).HasColumnName("appRoleIDCanCreate");
        });

        modelBuilder.Entity<ApplicationDefInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3213E83F37A9AE07");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedForUseByUserId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedForUseByUserID");
            entity.Property(e => e.ApprovedForUseDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedForUseDTUTC");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsApprovedForUse).HasColumnName("isApprovedForUse");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<ApplicationDefInstanceContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3213E83F47BC3AE5");

            entity.ToTable("ApplicationDefInstanceContent");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentKey).HasMaxLength(500);
            entity.Property(e => e.ContentValue).HasMaxLength(1024);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.InstanceId).HasColumnName("InstanceID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
        });

        modelBuilder.Entity<ApplicationDefInstanceInterviewQuestionConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3213E83F22F9E9F7");

            entity.ToTable("ApplicationDefInstanceInterviewQuestionConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.InstanceId).HasColumnName("InstanceID");
            entity.Property(e => e.IsIncluded)
                .HasDefaultValue(true)
                .HasColumnName("isIncluded");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
        });

        modelBuilder.Entity<ApplicationDefInstanceStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3213E83FAB5D76FE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.InstanceId).HasColumnName("InstanceID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StepOrder).HasDefaultValue(0);
            entity.Property(e => e.TemplateStepId).HasColumnName("TemplateStepID");
        });

        modelBuilder.Entity<ApplicationDefInstanceSubStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3213E83F4F05F651");

            entity.HasIndex(e => e.StepId, "ix_dbo_ApplicationDefInstanceSubSteps_StepID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DaysToStale).HasDefaultValue(0);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StepId).HasColumnName("StepID");
            entity.Property(e => e.TemplateSubStepId).HasColumnName("TemplateSubStepID");
        });

        modelBuilder.Entity<ApplicationTenantInterviewQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ApplicationDefInstanceInterviewQuestions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionText).HasMaxLength(2048);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<ApprolePolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ApproleP__3213E83F7B6FE544");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppRoleId).HasColumnName("appRoleID");
            entity.Property(e => e.Descrip)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PolicyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("policyName");
            entity.Property(e => e.PolicyValPriority).HasColumnName("policyValPriority");
            entity.Property(e => e.PolicyValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("policyValue");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<AssignCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("assignCache");

            entity.Property(e => e.Assignid).HasColumnName("assignid");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Joborderid).HasColumnName("joborderid");
            entity.Property(e => e.Shiftschedid).HasColumnName("shiftschedid");
            entity.Property(e => e.Startdt)
                .HasColumnType("datetime")
                .HasColumnName("startdt");
        });

        modelBuilder.Entity<AuditLogDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AUDIT_LOG_DETAIL_ID");

            entity.ToTable("AUDIT_LOG_DETAIL", tb => tb.HasComment("Stores details about any update to data being audited.  "));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(128)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.ColumnNewValue).HasColumnName("COLUMN_NEW_VALUE");
            entity.Property(e => e.ColumnOldValue).HasColumnName("COLUMN_OLD_VALUE");
            entity.Property(e => e.Headerid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HEADERID");

            entity.HasOne(d => d.Header).WithMany(p => p.AuditLogDetails)
                .HasForeignKey(d => d.Headerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AUDIT_LOG_DETAIL_HEADERID");
        });

        modelBuilder.Entity<AuditLogHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AUDIT_LOG_HEADER_ID");

            entity.ToTable("AUDIT_LOG_HEADER", tb => tb.HasComment("Stores information about updates to data - specifying who changed data and when. "));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.AppName)
                .HasMaxLength(100)
                .HasColumnName("APP_NAME");
            entity.Property(e => e.AuditAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUDIT_ACTION");
            entity.Property(e => e.AuditDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AUDIT_DATETIME");
            entity.Property(e => e.AuditUserid)
                .HasMaxLength(50)
                .HasColumnName("AUDIT_USERID");
            entity.Property(e => e.HostName)
                .HasMaxLength(100)
                .HasColumnName("HOST_NAME");
            entity.Property(e => e.PrimaryKeyColumnName)
                .HasMaxLength(128)
                .HasColumnName("PRIMARY_KEY_COLUMN_NAME");
            entity.Property(e => e.PrimaryKeyColumnValue).HasColumnName("PRIMARY_KEY_COLUMN_VALUE");
            entity.Property(e => e.TableName)
                .HasMaxLength(128)
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<AuditLogTablePrimaryKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AUDIT_LOG_TABLE_PRIMARY_KEY_ID");

            entity.ToTable("AUDIT_LOG_TABLE_PRIMARY_KEY", tb => tb.HasComment("Stores references back to the original source data being updated/inserted/deleted.  "));

            entity.HasIndex(e => new { e.TableSchema, e.TableName }, "UQ_AUDIT_LOG_TABLE_PRIMARY_KEY_TABLE_SCHEMA_TABLE_NAME").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.PrimaryKeyColumnName)
                .HasMaxLength(128)
                .HasColumnName("PRIMARY_KEY_COLUMN_NAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(128)
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(128)
                .HasColumnName("TABLE_SCHEMA");
        });

        modelBuilder.Entity<BranchApplicationAddlQuestion>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionText).HasMaxLength(2048);

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchApplicationAddlQuestions)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchApplicationAddlQuestions_Talent");
        });

        modelBuilder.Entity<BranchApplicationStatement>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StatementText).HasMaxLength(2048);

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchApplicationStatements)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentApplicationStatements_branch");
        });

        modelBuilder.Entity<BranchClient>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("Associates 'clients' with branches.  "));

            entity.HasIndex(e => e.BranchId, "ix_dbo_BranchClients_BranchID2");

            entity.HasIndex(e => new { e.BranchId, e.IsInternal }, "ix_dbo_BranchClients_BranchID_isInternal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcabillInsuredOnly).HasColumnName("ACABillInsuredOnly");
            entity.Property(e => e.AcainvoiceFormat).HasColumnName("ACAInvoiceFormat");
            entity.Property(e => e.AcasurchargeMethodId).HasColumnName("ACASurchargeMethodID");
            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.BecameProspectDt)
                .HasColumnType("datetime")
                .HasColumnName("BecameProspectDT");
            entity.Property(e => e.BillAddress1).HasMaxLength(500);
            entity.Property(e => e.BillAddress2).HasMaxLength(500);
            entity.Property(e => e.BillCity).HasMaxLength(100);
            entity.Property(e => e.BillCountry).HasMaxLength(100);
            entity.Property(e => e.BillDepartment).HasMaxLength(100);
            entity.Property(e => e.BillEmail).HasMaxLength(100);
            entity.Property(e => e.BillPerson).HasMaxLength(500);
            entity.Property(e => e.BillPhone).HasMaxLength(100);
            entity.Property(e => e.BillState).HasMaxLength(100);
            entity.Property(e => e.BillZip).HasMaxLength(20);
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ClientActivatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ClientActivatedByUserID");
            entity.Property(e => e.ClientActivationDt)
                .HasColumnType("datetime")
                .HasColumnName("ClientActivationDT");
            entity.Property(e => e.ClientActivationRequestDt)
                .HasColumnType("datetime")
                .HasColumnName("ClientActivationRequestDT");
            entity.Property(e => e.ClientActivationRequestedBy).HasMaxLength(50);
            entity.Property(e => e.ClientDeactivatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ClientDeactivatedByUserID");
            entity.Property(e => e.ClientDeactivatedDt)
                .HasColumnType("datetime")
                .HasColumnName("ClientDeactivatedDT");
            entity.Property(e => e.ClientDeactivatedReason).HasMaxLength(4000);
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.DiscountPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Ein)
                .HasMaxLength(20)
                .HasColumnName("EIN");
            entity.Property(e => e.ExtCustomerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ExtCustomerID");
            entity.Property(e => e.IsActivationApproved)
                .HasDefaultValue(false)
                .HasColumnName("isActivationApproved");
            entity.Property(e => e.IsActivationDenied).HasColumnName("isActivationDenied");
            entity.Property(e => e.IsActivationRequested)
                .HasDefaultValue(false)
                .HasColumnName("isActivationRequested");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeactivated)
                .HasDefaultValue(false)
                .HasColumnName("isDeactivated");
            entity.Property(e => e.IsInternal)
                .HasDefaultValue(false)
                .HasColumnName("isInternal");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PhysAddress1).HasMaxLength(500);
            entity.Property(e => e.PhysAddress2).HasMaxLength(500);
            entity.Property(e => e.PhysCity).HasMaxLength(100);
            entity.Property(e => e.PhysState).HasMaxLength(100);
            entity.Property(e => e.PhysZip).HasMaxLength(20);
            entity.Property(e => e.PrimaryEmailAddress).HasMaxLength(200);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(100);
            entity.Property(e => e.PrimaryPoCname)
                .HasMaxLength(500)
                .HasColumnName("PrimaryPoCName");
            entity.Property(e => e.SalesPersonId)
                .HasMaxLength(50)
                .HasColumnName("SalesPersonID");
            entity.Property(e => e.SalesTaxPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.Website).HasMaxLength(500);
            entity.Property(e => e.WorkCompDetails).HasMaxLength(2000);

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchClients)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__BranchCli__Branc__55F4C372");

            entity.HasOne(d => d.Client).WithMany(p => p.BranchClients)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__BranchCli__Clien__56E8E7AB");

            entity.HasOne(d => d.InvoiceTermsNavigation).WithMany(p => p.BranchClients)
                .HasForeignKey(d => d.InvoiceTerms)
                .HasConstraintName("FK__BranchCli__Invoi__77E09279");
        });

        modelBuilder.Entity<BranchClientConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83F9BEE6E27");

            entity.ToTable("BranchClientConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.ConfigOption).HasMaxLength(100);
            entity.Property(e => e.ConfigValue).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
        });

        modelBuilder.Entity<BranchClientContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83F6BF49FDD");

            entity.ToTable(tb => tb.HasComment("Contacts for each client.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(200)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDtUTC");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsInvoiceable).HasColumnName("isInvoiceable");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(200)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDtUTC");
            entity.Property(e => e.Role).HasMaxLength(100);

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientContacts)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__5B4453CB");

            entity.HasOne(d => d.Contact).WithMany(p => p.BranchClientContacts)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__BranchCli__Conta__5A502F92");
        });

        modelBuilder.Entity<BranchClientCrm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83F00A98B44");

            entity.ToTable("BranchClientCRM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PotentialCloseValue).HasColumnType("money");
            entity.Property(e => e.PotentialOpportunityTierId).HasColumnName("PotentialOpportunityTierID");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientCrms)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__0E0FCABA");

            entity.HasOne(d => d.PotentialOpportunityTier).WithMany(p => p.BranchClientCrms)
                .HasForeignKey(d => d.PotentialOpportunityTierId)
                .HasConstraintName("FK__BranchCli__Poten__0F03EEF3");
        });

        modelBuilder.Entity<BranchClientCrmstatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83FC25C80FF");

            entity.ToTable("BranchClientCRMStatusHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ProspectStatusId).HasColumnName("ProspectStatusID");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientCrmstatusHistories)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__14BCC849");

            entity.HasOne(d => d.ProspectStatus).WithMany(p => p.BranchClientCrmstatusHistories)
                .HasForeignKey(d => d.ProspectStatusId)
                .HasConstraintName("FK__BranchCli__Prosp__15B0EC82");
        });

        modelBuilder.Entity<BranchClientDocumentUpload>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ClientDocumentUploads");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("createdByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("createdDTUTC");
            entity.Property(e => e.DocDescription).HasMaxLength(2048);
            entity.Property(e => e.DocFriendlyName).HasMaxLength(100);
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDTUTC");
            entity.Property(e => e.Modifiedbyuserid).HasMaxLength(50);
            entity.Property(e => e.SignDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BranchClientPositionDefSkill>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("For each Position, the skills needed for the position. This is used for matching talent to positions. "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");

            entity.HasOne(d => d.Position).WithMany(p => p.BranchClientPositionDefSkills)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK__BranchCli__Posit__7EB7AD3A");
        });

        modelBuilder.Entity<BranchClientPositionDefinition>(entity =>
        {
            entity.ToTable("BranchClientPositionDefinition", tb => tb.HasComment("Positions, as defined for a client, from which base wages and other information flows.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseBillable).HasColumnType("money");
            entity.Property(e => e.BaseWage).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DoubleTimeBillable).HasColumnType("money");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OvertimeBillable).HasColumnType("money");
            entity.Property(e => e.PositionName).HasMaxLength(100);

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientPositionDefinitions)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__780AAFAB");
        });

        modelBuilder.Entity<BranchClientShiftDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83F9DB156EC");

            entity.ToTable("BranchClientShiftDefinition", tb => tb.HasComment("Defines the working shifts and wage/rate adjustments for those shifts, specific to each client.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillAdjustmentAmount).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DtbillAdjustmentAmount)
                .HasColumnType("money")
                .HasColumnName("DTBillAdjustmentAmount");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OtbillAdjustmentAmount)
                .HasColumnType("money")
                .HasColumnName("OTBillAdjustmentAmount");
            entity.Property(e => e.ShiftDurationHrs).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftName).HasMaxLength(100);
            entity.Property(e => e.ShiftSupervisorContactId).HasColumnName("ShiftSupervisorContactID");
            entity.Property(e => e.WageAdjustmentAmount).HasColumnType("money");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientShiftDefinitions)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK_BranchClientShiftDefinition_BranchClients");
        });

        modelBuilder.Entity<BranchClientSkill>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("DEPRECATED "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
        });

        modelBuilder.Entity<BranchClientsRoyaltyRate>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RateDiscount).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.RateDiscountEndDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountEndDT");
            entity.Property(e => e.RateDiscountStartDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountStartDT");
            entity.Property(e => e.TenantRateId).HasColumnName("TenantRateID");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientsRoyaltyRates)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__3786E199");
        });

        modelBuilder.Entity<BranchClientsWccode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchCl__3213E83FFC2E305E");

            entity.ToTable("BranchClientsWCCodes", tb => tb.HasComment("DEPRECATED "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Wccode).HasColumnName("WCCode");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchClientsWccodes)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchCli__Branc__5EFFD616");
        });

        modelBuilder.Entity<BranchEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F5E57974C");

            entity.ToTable("BranchEmployees", "emp", tb => tb.HasComment("Associates a branch with talent upon employment "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");
            entity.Property(e => e.ExternalEmployeeId)
                .HasMaxLength(50)
                .HasColumnName("ExternalEmployeeID");
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StaffJobTitle).HasMaxLength(100);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationReasonId).HasColumnName("TerminationReasonID");

            entity.HasOne(d => d.Talent).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK__BranchEmp__Talen__1F2E9E6D");

            entity.HasOne(d => d.TenantBranch).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.TenantBranchId)
                .HasConstraintName("FK__BranchEmp__Tenan__2022C2A6");
        });

        modelBuilder.Entity<BranchEmployeeAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83FF4BF0D8F");

            entity.ToTable("BranchEmployeeAssignment", "emp", tb =>
                {
                    tb.HasComment("Assigns an employee to the job order and jobsite - note: The data is independent of the job order. Will handle population of this upon create with an SP. ");
                    tb.HasTrigger("TR_Audit_Log_BranchEmployeeAssignment");
                });

            entity.HasIndex(e => e.JobSiteId, "ix_BranchEmployeeAssignment_JobSiteID");

            entity.HasIndex(e => e.BranchEmployeeId, "ix_emp_BranchEmployeeAssignment_BranchEmployeeID");

            entity.HasIndex(e => e.IsActive, "ix_emp_BranchEmployeeAssignment_isActive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignmentDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.AssignmentTerminationDt)
                .HasColumnType("datetime")
                .HasColumnName("AssignmentTerminationDT");
            entity.Property(e => e.AssignmentTerminationReasonId).HasColumnName("AssignmentTerminationReasonID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobOrderShiftScheduleId).HasColumnName("JobOrderShiftScheduleID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LimitDollars).HasColumnType("money");
            entity.Property(e => e.LimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");
            entity.Property(e => e.PointofContactName).HasMaxLength(100);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(50)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalespersonId)
                .HasMaxLength(50)
                .HasColumnName("SalespersonID");
            entity.Property(e => e.SupervisorName).HasMaxLength(100);
            entity.Property(e => e.WorkShiftFri).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftMon).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftSat).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftSun).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftThu).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftTue).HasDefaultValue(true);
            entity.Property(e => e.WorkShiftWed).HasDefaultValue(true);

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeeAssignments)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK__BranchEmp__Branc__7ABC33CD");

            entity.HasOne(d => d.JobOrder).WithMany(p => p.BranchEmployeeAssignments)
                .HasForeignKey(d => d.JobOrderId)
                .HasConstraintName("FK__BranchEmp__JobOr__79C80F94");

            entity.HasOne(d => d.JobSite).WithMany(p => p.BranchEmployeeAssignments)
                .HasForeignKey(d => d.JobSiteId)
                .HasConstraintName("FK__BranchEmp__JobSi__0539C240");
        });

        modelBuilder.Entity<BranchEmployeeAssignmentRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83FF22A3034");

            entity.ToTable("BranchEmployeeAssignmentRates", "emp");

            entity.HasIndex(e => e.AssignmentId, "ix_emp_BranchEmployeeAssignmentRates_AssignmentID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EffectiveEndDt).HasColumnName("EffectiveEndDT");
            entity.Property(e => e.EffectiveStartDt).HasColumnName("EffectiveStartDT");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");

            entity.HasOne(d => d.Assignment).WithMany(p => p.BranchEmployeeAssignmentRates)
                .HasForeignKey(d => d.AssignmentId)
                .HasConstraintName("FK_BranchEmployeeAssignmentRates_BranchEmployeeAssignment");
        });

        modelBuilder.Entity<BranchEmployeeAssignmentWorkSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F4186115C");

            entity.ToTable("BranchEmployeeAssignmentWorkSchedule", "emp");

            entity.HasIndex(e => e.AssignmentId, "ix_emp_BranchEmployeeAssignmentWorkSchedule_AssignmentID");

            entity.HasIndex(e => new { e.AssignmentId, e.WorkDate }, "ix_emp_BranchEmployeeAssignmentWorkSchedule_AssignmentID_WorkDate");

            entity.HasIndex(e => e.BranchEmployeeId, "ix_emp_BranchEmployeeAssignmentWorkSchedule_BranchEmployeeID");

            entity.HasIndex(e => new { e.BranchEmployeeId, e.BranchId, e.WorkDate }, "ix_emp_BranchEmployeeAssignmentWorkSchedule_BranchEmployeeID_BranchID_WorkDate");

            entity.HasIndex(e => new { e.WorkDate, e.Duration }, "ix_emp_BranchEmployeeAssignmentWorkSchedule_WorkDate_Duration");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Duration).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftScheduleId).HasColumnName("ShiftScheduleID");
        });

        modelBuilder.Entity<BranchEmployeeClientSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F919D211D");

            entity.ToTable("BranchEmployeeClientSubmissions", "emp", tb => tb.HasComment("Recruiters can submit an employee to a client for review \"do you want to have this person come to this job order?\" "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalStatus).HasDefaultValue(1);
            entity.Property(e => e.ApprovalStatusDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.IsSubmitted)
                .HasDefaultValue(true)
                .HasColumnName("isSubmitted");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedbyUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedbyUserID");
            entity.Property(e => e.SubmittedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchEmployeeClientSubmissions)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK_BranchEmployeeClientSubmissions_BranchClients");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeeClientSubmissions)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_BranchEmployeeClientSubmissions_BranchEmployees");
        });

        modelBuilder.Entity<BranchEmployeeDeductionInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F92666315");

            entity.ToTable("BranchEmployeeDeductionInstance", "emp", tb => tb.HasComment("Sets up a garnishment or deduction method and type for employee paychecks.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DeductAllExcept).HasColumnType("money");
            entity.Property(e => e.DeductionAmountAbs).HasColumnType("money");
            entity.Property(e => e.DeductionInstanceLabel).HasMaxLength(100);
            entity.Property(e => e.DeductionMethodId).HasColumnName("DeductionMethodID");
            entity.Property(e => e.DeductionPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.DeductionTypeId).HasColumnName("DeductionTypeID");
            entity.Property(e => e.DeductionbyPctLimit).HasColumnType("money");
            entity.Property(e => e.EmployerContributionPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.EmployerMedicalMatch).HasColumnType("money");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsReadyForUse)
                .HasDefaultValue(false)
                .HasColumnName("isReadyForUse");
            entity.Property(e => e.MaxDisposableIncome).HasColumnType("money");
            entity.Property(e => e.Maximum).HasColumnType("money");
            entity.Property(e => e.MaximumExceptWages).HasColumnType("money");
            entity.Property(e => e.Minimum).HasColumnType("money");
            entity.Property(e => e.MinimumExceptWages).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OriginalBalance).HasColumnType("money");
            entity.Property(e => e.OverrideAmount).HasColumnType("money");
            entity.Property(e => e.PctofDisposalWages).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.PctofGrossWages).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.StandardAmount).HasColumnType("money");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeeDeductionInstances)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_BranchEmployeeDeductionInstance_BranchEmployees");

            entity.HasOne(d => d.DeductionType).WithMany(p => p.BranchEmployeeDeductionInstances)
                .HasForeignKey(d => d.DeductionTypeId)
                .HasConstraintName("FK_BranchEmployeeDeductionInstance_vt_PayrollDeductionTypesBranchAssoc");
        });

        modelBuilder.Entity<BranchEmployeeDeductionInstanceItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83FC8C5F1CB");

            entity.ToTable("BranchEmployeeDeductionInstanceItems", "emp", tb => tb.HasComment("itemizes any garnishment orders. i.e., more than one child support order.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1).HasMaxLength(100);
            entity.Property(e => e.Address2).HasMaxLength(100);
            entity.Property(e => e.CaseDate).HasColumnType("datetime");
            entity.Property(e => e.CaseId)
                .HasMaxLength(50)
                .HasColumnName("CaseID");
            entity.Property(e => e.CaseIssuer).HasMaxLength(500);
            entity.Property(e => e.CasePct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DeductionInstanceId).HasColumnName("DeductionInstanceID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ItemDescrip).HasMaxLength(500);
            entity.Property(e => e.Maximum).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StateId)
                .HasMaxLength(10)
                .HasColumnName("StateID");
            entity.Property(e => e.ZipCode).HasMaxLength(50);

            entity.HasOne(d => d.DeductionInstance).WithMany(p => p.BranchEmployeeDeductionInstanceItems)
                .HasForeignKey(d => d.DeductionInstanceId)
                .HasConstraintName("FK_BranchEmployeeDeductionInstanceItems_BranchEmployeeDeductionInstance");
        });

        modelBuilder.Entity<BranchEmployeePayAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F99F8A3F5");

            entity.ToTable("BranchEmployeePayAllocation", "emp", tb => tb.HasComment("Employee can allocate their paycheck to direct amounts to different bank accounts.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllocationAmt).HasColumnType("money");
            entity.Property(e => e.AllocationPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(100)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(100)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PaycheckAllocationTypeId).HasColumnName("PaycheckAllocationTypeID");
            entity.Property(e => e.TalentBankAccountId).HasColumnName("TalentBankAccountID");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeePayAllocations)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK__BranchEmp__Branc__1DDB52D8");

            entity.HasOne(d => d.PaycheckAllocationType).WithMany(p => p.BranchEmployeePayAllocations)
                .HasForeignKey(d => d.PaycheckAllocationTypeId)
                .HasConstraintName("FK__BranchEmp__Paych__1FC39B4A");

            entity.HasOne(d => d.TalentBankAccount).WithMany(p => p.BranchEmployeePayAllocations)
                .HasForeignKey(d => d.TalentBankAccountId)
                .HasConstraintName("FK__BranchEmp__Talen__1ECF7711");
        });

        modelBuilder.Entity<BranchEmployeePaycheckPreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F570B310C");

            entity.ToTable("BranchEmployeePaycheckPreference", "emp", tb => tb.HasComment("Employee preferences on pay method.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankAccountId).HasColumnName("bankAccountID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsAch).HasColumnName("isACH");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsPaperCheck).HasColumnName("isPaperCheck");
            entity.Property(e => e.IsPayCard).HasColumnName("isPayCard");
            entity.Property(e => e.PaystubHandlingId).HasColumnName("PaystubHandlingID");

            entity.HasOne(d => d.Employee).WithMany(p => p.BranchEmployeePaycheckPreferences)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__BranchEmp__Emplo__430CD787");
        });

        modelBuilder.Entity<BranchEmployeeTaxSetupPoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F0CA4601A");

            entity.ToTable("BranchEmployeeTaxSetupPOC", "emp", tb => tb.HasComment("IN PROGRESS --  "));

            entity.HasIndex(e => e.BranchEmployeeId, "ix_emp_BranchEmployeeTaxSetupPOC_BranchEmployeeID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.FormFieldIdentifier).HasMaxLength(500);
            entity.Property(e => e.FormFieldValue).HasMaxLength(500);

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeeTaxSetupPocs)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_BranchEmployeeTaxSetupPOC_BranchEmployees");
        });

        modelBuilder.Entity<BranchEmployeeTimeOffAccrual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F363DC037");

            entity.ToTable("BranchEmployeeTimeOffAccruals", "emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsAnnualReset).HasColumnName("isAnnualReset");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.NewTotalAccrued).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TimeOffPlanId).HasColumnName("TimeOffPlanID");
        });

        modelBuilder.Entity<BranchEmployeeTimeOffPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F03378BC7");

            entity.ToTable("BranchEmployeeTimeOffPlans", "emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TimeOffPlanId).HasColumnName("TimeOffPlanID");
        });

        modelBuilder.Entity<BranchEmployeeTimeOffRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83F7B575615");

            entity.ToTable("BranchEmployeeTimeOffRequests", "emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByUserID");
            entity.Property(e => e.ApprovedOnDt)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedOnDT");
            entity.Property(e => e.BilltoAssignentId).HasColumnName("BilltoAssignentID");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.HoursRequested).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsBillable)
                .HasDefaultValue(false)
                .HasColumnName("isBillable");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RequestedOnDt)
                .HasColumnType("datetime")
                .HasColumnName("RequestedOnDT");
            entity.Property(e => e.TimeOffPlanId).HasColumnName("TimeOffPlanID");
        });

        modelBuilder.Entity<BranchEmployeeWage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchEm__3213E83FAE2554E7");

            entity.ToTable("BranchEmployeeWages", "emp", tb => tb.HasComment("Gives a BranchEmployee a salary "));

            entity.HasIndex(e => e.BranchEmployeeId, "ix_emp_BranchEmployeeWages_BranchEmployeeID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnnualWageAmount).HasColumnType("money");
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.HrlyDoubleWageAmount).HasColumnType("money");
            entity.Property(e => e.HrlyOtwageAmount)
                .HasColumnType("money")
                .HasColumnName("HrlyOTWageAmount");
            entity.Property(e => e.HrlyRegWageAmount).HasColumnType("money");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.WageEndDt)
                .HasColumnType("datetime")
                .HasColumnName("WageEndDT");
            entity.Property(e => e.WagePeriodId).HasColumnName("WagePeriodID");
            entity.Property(e => e.WageStartDt)
                .HasColumnType("datetime")
                .HasColumnName("WageStartDT");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.BranchEmployeeWages)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK__BranchEmp__Branc__22FF2F51");

            entity.HasOne(d => d.WagePeriod).WithMany(p => p.BranchEmployeeWages)
                .HasForeignKey(d => d.WagePeriodId)
                .HasConstraintName("FK__BranchEmp__WageP__24E777C3");
        });

        modelBuilder.Entity<BranchJobOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83F7320B75C");

            entity.ToTable(tb =>
                {
                    tb.HasComment("Job Orders associates client job site, branch, and creates an order for positions to be filled ");
                    tb.HasTrigger("TR_Audit_Log_BranchJobOrders");
                });

            entity.HasIndex(e => new { e.BranchClientId, e.IsActive, e.CreatedDtutc }, "ix_dbo_BranchJobOrders_BranchClientID_isActive_CreatedDTUTC");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationDefInstanceId).HasColumnName("ApplicationDefInstanceID");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsDirectHire)
                .HasDefaultValue(false)
                .HasColumnName("isDirectHire");
            entity.Property(e => e.JobApplyUrl)
                .HasMaxLength(500)
                .HasColumnName("JobApplyURL");
            entity.Property(e => e.JobCategory).HasMaxLength(200);
            entity.Property(e => e.JobOrderTypeId).HasColumnName("JobOrderTypeID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LimitDollars).HasColumnType("money");
            entity.Property(e => e.LimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PointOfContactId).HasColumnName("PointOfContactID");
            entity.Property(e => e.PointofContactName).HasMaxLength(100);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(50)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalespersonId)
                .HasMaxLength(50)
                .HasColumnName("SalespersonID");
            entity.Property(e => e.SupervisorName).HasMaxLength(100);
            entity.Property(e => e.WccodeId).HasColumnName("WCCodeID");

            entity.HasOne(d => d.BranchClient).WithMany(p => p.BranchJobOrders)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__BranchJob__Branc__740F363E");

            entity.HasOne(d => d.JobOrderType).WithMany(p => p.BranchJobOrders)
                .HasForeignKey(d => d.JobOrderTypeId)
                .HasConstraintName("FK_BranchJobOrder_JobOrderType");

            entity.HasOne(d => d.JobSite).WithMany(p => p.BranchJobOrders)
                .HasForeignKey(d => d.JobSiteId)
                .HasConstraintName("FK__BranchJob__JobSi__75F77EB0");
        });

        modelBuilder.Entity<BranchJobOrderAddlQuestionConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83F4033E62D");

            entity.ToTable("BranchJobOrderAddlQuestionConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsIncluded)
                .HasDefaultValue(true)
                .HasColumnName("isIncluded");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
        });

        modelBuilder.Entity<BranchJobOrderClientPaperwork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83FF20CD880");

            entity.ToTable("BranchJobOrderClientPaperwork");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsRequired).HasColumnName("isRequired");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<BranchJobOrderDirectHireDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83FA4EE1765");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FlatFeeAmount).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PercentageAmount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PositionName).HasMaxLength(200);
            entity.Property(e => e.ShiftName).HasMaxLength(200);
            entity.Property(e => e.WageAmountPerPeriod).HasColumnType("money");

            entity.HasOne(d => d.BranchJobOrder).WithMany(p => p.BranchJobOrderDirectHireDetails)
                .HasForeignKey(d => d.BranchJobOrderId)
                .HasConstraintName("FK__BranchJob__Branc__77368703");

            entity.HasOne(d => d.WagePeriodNavigation).WithMany(p => p.BranchJobOrderDirectHireDetails)
                .HasForeignKey(d => d.WagePeriod)
                .HasConstraintName("FK__BranchJob__WageP__782AAB3C");
        });

        modelBuilder.Entity<BranchJobOrderShiftSchedule>(entity =>
        {
            entity.ToTable("BranchJobOrderShiftSchedule", tb => tb.HasComment("Associates a Job Order with the BranchJobOrderShift, and specifies workdays. Can be many schedules per job order and shift, depending on the work days.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchJobOrderShiftsId).HasColumnName("BranchJobOrderShiftsID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");

            entity.HasOne(d => d.BranchJobOrderShifts).WithMany(p => p.BranchJobOrderShiftSchedules)
                .HasForeignKey(d => d.BranchJobOrderShiftsId)
                .HasConstraintName("FK__BranchJob__Branc__743A1EC7");
        });

        modelBuilder.Entity<BranchJobOrderSkill>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("Contains skills needed for a job order, initially seeded with the skills associated with the PositionID, and allows the user to add additional needed skills.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");

            entity.HasOne(d => d.Skill).WithMany(p => p.BranchJobOrderSkills)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK_BranchJobOrderSkills_vt_Skills");
        });

        modelBuilder.Entity<BranchJobOrderStatementsConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83F96F5DDE2");

            entity.ToTable("BranchJobOrderStatementsConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsIncluded)
                .HasDefaultValue(true)
                .HasColumnName("isIncluded");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StatementId).HasColumnName("StatementID");
        });

        modelBuilder.Entity<BranchJobOrderTalentVerifyConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83F34C33DEE");

            entity.ToTable("BranchJobOrderTalentVerifyConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsIncluded)
                .HasDefaultValue(true)
                .HasColumnName("isIncluded");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.SectionDefId).HasColumnName("SectionDefID");

            entity.HasOne(d => d.JobOrder).WithMany(p => p.BranchJobOrderTalentVerifyConfigs)
                .HasForeignKey(d => d.JobOrderId)
                .HasConstraintName("FK__BranchJob__JobOr__47D257FB");

            entity.HasOne(d => d.SectionDef).WithMany(p => p.BranchJobOrderTalentVerifyConfigs)
                .HasForeignKey(d => d.SectionDefId)
                .HasConstraintName("FK__BranchJob__Secti__48C67C34");
        });

        modelBuilder.Entity<BranchJobOrdersShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchJo__3213E83FBE711493");

            entity.ToTable(tb => tb.HasComment("Associates Job Order to Shift.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ShiftDefinitionId).HasColumnName("ShiftDefinitionID");
        });

        modelBuilder.Entity<BranchPayPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchPa__3213E83FC4511608");

            entity.ToTable(tb => tb.HasComment("Pay Periods - pay date, start/end, etc. for a given branch.  "));

            entity.HasIndex(e => e.IsActive, "ix_BranchPayPeriods_ChildAggregate");

            entity.HasIndex(e => new { e.BranchId, e.Id }, "ix_BranchPayPeriods_TenantBranchID");

            entity.HasIndex(e => new { e.BranchId, e.PeriodStartDt, e.PeriodEndDt, e.IsManual }, "ix_dbo_BranchPayPeriods_BranchID_PeriodStartDT_PeriodEndDT_isManual");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Achsubmitted)
                .HasDefaultValue(false)
                .HasColumnName("ACHSubmitted");
            entity.Property(e => e.ApprovedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByUserID");
            entity.Property(e => e.ApprovedDt)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedDT");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CheckPrintStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedOnUTCDt");
            entity.Property(e => e.FullCheckDocumentId).HasColumnName("FullCheckDocumentID");
            entity.Property(e => e.FullCheckPreviewDocId).HasColumnName("FullCheckPreviewDocID");
            entity.Property(e => e.InitiatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("InitiatedByUserID");
            entity.Property(e => e.InitiatedDt)
                .HasColumnType("datetime")
                .HasColumnName("InitiatedDT");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsAdHoc)
                .HasDefaultValue(false)
                .HasColumnName("isAdHoc");
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(false)
                .HasColumnName("isApproved");
            entity.Property(e => e.IsInitiated)
                .HasDefaultValue(false)
                .HasColumnName("isInitiated");
            entity.Property(e => e.IsManual)
                .HasDefaultValue(false)
                .HasColumnName("isManual");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.IsRejected)
                .HasDefaultValue(false)
                .HasColumnName("isRejected");
            entity.Property(e => e.IsSubmitted)
                .HasDefaultValue(false)
                .HasColumnName("isSubmitted");
            entity.Property(e => e.LimitPayeesToTimecards).HasDefaultValue(false);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedUTCDt");
            entity.Property(e => e.PaycardSubmitted).HasDefaultValue(false);
            entity.Property(e => e.PaychecksDrafted).HasDefaultValue(false);
            entity.Property(e => e.PaychecksDraftedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PaychecksDraftedByUserID");
            entity.Property(e => e.PaychecksDraftedDt).HasColumnName("PaychecksDraftedDT");
            entity.Property(e => e.PaychecksFinalized).HasDefaultValue(false);
            entity.Property(e => e.PaychecksFinalizedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PaychecksFinalizedByUserID");
            entity.Property(e => e.PaychecksFinalizedDt).HasColumnName("PaychecksFinalizedDT");
            entity.Property(e => e.PaystubsGenerated).HasDefaultValue(false);
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.PositivePayFinalized).HasDefaultValue(false);
            entity.Property(e => e.RejectedByUserId)
                .HasMaxLength(50)
                .HasColumnName("RejectedByUserID");
            entity.Property(e => e.RejectedDt)
                .HasColumnType("datetime")
                .HasColumnName("RejectedDT");
            entity.Property(e => e.SubmittedByUserId)
                .HasMaxLength(50)
                .HasColumnName("SubmittedByUserID");
            entity.Property(e => e.SubmittedDt)
                .HasColumnType("datetime")
                .HasColumnName("SubmittedDT");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

            entity.HasOne(d => d.Template).WithMany(p => p.BranchPayPeriods)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK__BranchPay__Templ__35E7E693");
        });

        modelBuilder.Entity<BranchPayPeriodTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchPa__3213E83F2E2F991D");

            entity.ToTable(tb => tb.HasComment("Provides templates for pay periods, from which we seed the payperiod specifics -- e.g., Every two weeks, with the first pay date  being xx/xx/xx and the first pay period start and end dates being xx/xx/xx and yy/yy/yy"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedOnUTCDt");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedUTCDt");
            entity.Property(e => e.PayCyclePeriodId).HasColumnName("PayCyclePeriodID");
            entity.Property(e => e.PayrollDueDaysPrior).HasDefaultValue(3);
            entity.Property(e => e.PeriodDefinitionName).HasMaxLength(100);
        });

        modelBuilder.Entity<BranchTimeOffPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchTi__3213E83F6A13C815");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccruePerHoursWorked).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.AllowCarryover).HasDefaultValue(false);
            entity.Property(e => e.AllowNegativeRequests).HasDefaultValue(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchTimeOffTypeId).HasColumnName("BranchTimeOffTypeID");
            entity.Property(e => e.CapAccrualHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DefaultAllEmployees).HasDefaultValue(false);
            entity.Property(e => e.HoursAccrued).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsUnlimited)
                .HasDefaultValue(false)
                .HasColumnName("isUnlimited");
            entity.Property(e => e.MaxCarryoverHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.MaxNegativeCarryover).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.NegativeBalanceCarryover).HasDefaultValue(false);
            entity.Property(e => e.PlanDescription).HasMaxLength(2000);
            entity.Property(e => e.PlanName).HasMaxLength(100);
            entity.Property(e => e.ProbationaryPeriodMonths).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ProrateTimeOff).HasDefaultValue(false);
        });

        modelBuilder.Entity<BranchTimeOffType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchTi__3213E83FCC33F6E8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TimeOffTypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<BranchWorkersCompCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchWo__3213E83FDCD3F27B");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId)
                .HasMaxLength(10)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LossCost).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Premium).HasColumnType("money");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.TenantWorkcompCodeId).HasColumnName("TenantWorkcompCodeID");
        });

        modelBuilder.Entity<ChartOfAccountsDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChartOfA__3213E83F6560A5D6");

            entity.ToTable("ChartOfAccountsDefinition", "acc", tb => tb.HasComment("Chart of Accounts definition - associates a branch with a chart, and includes a parent chart if applicable"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DerivedFromCoAdefId).HasColumnName("DerivedFromCoADefID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ParentGlcoAdefId)
                .HasDefaultValue(-1)
                .HasColumnName("ParentGLCoADefID");

            entity.HasOne(d => d.Branch).WithMany(p => p.ChartOfAccountsDefinitions)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__ChartOfAc__Branc__056ECC6A");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3213E83FA264D25F");

            entity.ToTable(tb => tb.HasComment("High level definition of a Client - depending on business rules, we could allow tenants to access data on clients that are not theirs.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientName).HasMaxLength(500);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ParentClientId).HasColumnName("ParentClientID");
        });

        modelBuilder.Entity<ClientJobSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClientJo__3213E83FFD2C257F");

            entity.ToTable("ClientJobSite", tb => tb.HasComment("Jobsites at which assigned talent will work.  "));

            entity.HasIndex(e => new { e.BranchClientId, e.JobSiteIdent }, "ix_dbo_ClientJobSite_BranchClientID_JobSiteIdent");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcabillInsuredOnly).HasColumnName("ACABillInsuredOnly");
            entity.Property(e => e.AcainvoiceFormat).HasColumnName("ACAInvoiceFormat");
            entity.Property(e => e.AcasurchargeMethodId).HasColumnName("ACASurchargeMethodID");
            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.Address1).HasMaxLength(500);
            entity.Property(e => e.Address2).HasMaxLength(500);
            entity.Property(e => e.BillAddress1).HasMaxLength(500);
            entity.Property(e => e.BillAddress2).HasMaxLength(500);
            entity.Property(e => e.BillCity).HasMaxLength(100);
            entity.Property(e => e.BillDepartment).HasMaxLength(100);
            entity.Property(e => e.BillEmail).HasMaxLength(100);
            entity.Property(e => e.BillPerson).HasMaxLength(500);
            entity.Property(e => e.BillPhone).HasMaxLength(100);
            entity.Property(e => e.BillState).HasMaxLength(100);
            entity.Property(e => e.BillZip).HasMaxLength(20);
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.City).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DiscountPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmailAddress).HasMaxLength(200);
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("geoCodeID");
            entity.Property(e => e.GeoLat).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.GeoLon).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsPrimary)
                .HasDefaultValue(false)
                .HasColumnName("isPrimary");
            entity.Property(e => e.JobSiteContactEmail).HasMaxLength(500);
            entity.Property(e => e.JobSiteIdent).HasMaxLength(10);
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ModifiedbyUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedbyUserID");
            entity.Property(e => e.PrimaryPhone).HasMaxLength(100);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(100)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalesTaxPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.StateName).HasMaxLength(500);
            entity.Property(e => e.UseParentBillingInfo).HasDefaultValue(true);
            entity.Property(e => e.Website).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(500);

            entity.HasOne(d => d.BranchClient).WithMany(p => p.ClientJobSites)
                .HasForeignKey(d => d.BranchClientId)
                .HasConstraintName("FK__ClientJob__Branc__5E1FF51F");
        });

        modelBuilder.Entity<ClientJobSiteWorkersCompCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClientJo__3213E83FCD60D159");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientJobSiteId)
                .HasMaxLength(10)
                .HasColumnName("ClientJobSiteID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TenantWorkcompCodeId).HasColumnName("TenantWorkcompCodeID");
        });

        modelBuilder.Entity<ClientJobsiteContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClientJo__3213E83FC9113070");

            entity.ToTable(tb => tb.HasComment("Contacts who are specifically assigned to job sites.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.ClientJobSiteId).HasColumnName("ClientJobSiteID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(200)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDtUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(200)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDtUTC");
            entity.Property(e => e.SendInvoices).HasDefaultValue(false);

            entity.HasOne(d => d.ClientJobSite).WithMany(p => p.ClientJobsiteContacts)
                .HasForeignKey(d => d.ClientJobSiteId)
                .HasConstraintName("FK__ClientJob__Clien__61F1515A");

            entity.HasOne(d => d.Contact).WithMany(p => p.ClientJobsiteContacts)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__ClientJob__Conta__60FD2D21");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacts__3213E83F1DEE38ED");

            entity.ToTable(tb => tb.HasComment("Superset of all contacts -- for analytical purposes. not exposed to application.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(200)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDtUTC");
            entity.Property(e => e.EmailAddress).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(200)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDtUTC");
            entity.Property(e => e.Phone).HasMaxLength(200);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Website).HasMaxLength(200);
        });

        modelBuilder.Entity<EmployeeTaxElection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F3839AAD7");

            entity.ToTable("EmployeeTaxElections", "emp", tb => tb.HasTrigger("t_TaxManager"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Dependents).HasColumnName("dependents");
            entity.Property(e => e.Dualstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dualstate");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.FederalDependentCredits).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Federaldeductionsamount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("federaldeductionsamount");
            entity.Property(e => e.Federaldependents)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("federaldependents");
            entity.Property(e => e.Federalextrawitholding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("federalextrawitholding");
            entity.Property(e => e.Federalfilingstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("federalfilingstatus");
            entity.Property(e => e.Federalotherincome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("federalotherincome");
            entity.Property(e => e.Ficaexempt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ficaexempt");
            entity.Property(e => e.Localaddlwithholding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localaddlwithholding");
            entity.Property(e => e.Localallowance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localallowance");
            entity.Property(e => e.Localfilingstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localfilingstatus");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Multiplejobs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("multiplejobs");
            entity.Property(e => e.Psdcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("psdcode");
            entity.Property(e => e.Stateaddlwitholding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stateaddlwitholding");
            entity.Property(e => e.Stateallowances)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stateallowances");
            entity.Property(e => e.Statefilingstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statefilingstatus");
        });

        modelBuilder.Entity<EmployeeTimeCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F08AECD5F");

            entity.ToTable("EmployeeTimeCards", "emp", tb => tb.HasComment("Connects employee work to pay periods, and subsequently to a paycheck.  "));

            entity.HasIndex(e => e.BranchEmployeeId, "ix_emp_EmployeeTimeCards_BranchEmployeeID22");

            entity.HasIndex(e => e.IsVerified, "ix_emp_EmployeeTimeCards_isVerified");

            entity.HasIndex(e => e.PayCheckId, "ix_emp_EmployeeTimeCards_payCheckID");

            entity.HasIndex(e => new { e.PayPeriodId, e.IsVerified }, "ix_emp_EmployeeTimeCards_payPeriodID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.IsLocked)
                .HasDefaultValue(false)
                .HasColumnName("isLocked");
            entity.Property(e => e.IsVerified)
                .HasDefaultValue(false)
                .HasColumnName("isVerified");
            entity.Property(e => e.LockedByUserId)
                .HasMaxLength(50)
                .HasColumnName("LockedByUserID");
            entity.Property(e => e.LockedDt)
                .HasColumnType("datetime")
                .HasColumnName("LockedDT");
            entity.Property(e => e.PayCheckId).HasColumnName("payCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("payPeriodID");
            entity.Property(e => e.VerifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("VerifiedByUserID");
            entity.Property(e => e.VerifiedDt)
                .HasColumnType("datetime")
                .HasColumnName("VerifiedDT");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.EmployeeTimeCards)
                .HasForeignKey(d => d.BranchEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTimeCards_BranchEmployees");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.EmployeeTimeCards)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK_EmployeeTimeCards_PayChecks");

            entity.HasOne(d => d.PayPeriod).WithMany(p => p.EmployeeTimeCards)
                .HasForeignKey(d => d.PayPeriodId)
                .HasConstraintName("FK_EmployeeTimeCards_BranchPayPeriods");
        });

        modelBuilder.Entity<EmployeeTimeCardAggregateTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FDE59F1B8");

            entity.ToTable("EmployeeTimeCardAggregateTime", "emp");

            entity.HasIndex(e => e.AssignmentId, "ix_emp_EmployeeTimeCardAggregateTime_AssignmentID");

            entity.HasIndex(e => e.HoursDt, "ix_emp_EmployeeTimeCardAggregateTime_HoursDT");

            entity.HasIndex(e => e.TimecardId, "ix_emp_EmployeeTimeCardAggregateTime_TimecardID");

            entity.HasIndex(e => new { e.TimecardId, e.AssignmentId }, "ix_emp_EmployeeTimeCardAggregateTime_TimecardID_AssignmentID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DataSource).HasMaxLength(50);
            entity.Property(e => e.HoursDt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursDT");
            entity.Property(e => e.HoursOt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursOT");
            entity.Property(e => e.HoursReg).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");
            entity.Property(e => e.RateId).HasColumnName("RateID");
            entity.Property(e => e.TimecardId).HasColumnName("TimecardID");
        });

        modelBuilder.Entity<EmployeeTimeWorkedDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F1A9787BD");

            entity.ToTable("EmployeeTimeWorkedDetails", "emp", tb =>
                {
                    tb.HasComment("Start/end information for each clockin/out event.  ");
                    tb.HasTrigger("t_EmployeeTimeAudit");
                });

            entity.HasIndex(e => e.TimeWorkedShiftId, "ix_EmployeeTimeWorked_ShiftID");

            entity.HasIndex(e => e.DetailEndTime, "ix_emp_EmployeeTimeWorkedDetails_DetailEndTime");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DetailEndTime).HasColumnType("datetime");
            entity.Property(e => e.DetailStartTime).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsBreak).HasColumnName("isBreak");
            entity.Property(e => e.IsDoubleRate).HasColumnName("isDoubleRate");
            entity.Property(e => e.IsOtrate).HasColumnName("isOTRate");
            entity.Property(e => e.IsRegRate).HasColumnName("isRegRate");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TimeWorkedShiftId).HasColumnName("TimeWorkedShiftID");

            entity.HasOne(d => d.TimeWorkedShift).WithMany(p => p.EmployeeTimeWorkedDetails)
                .HasForeignKey(d => d.TimeWorkedShiftId)
                .HasConstraintName("FK__EmployeeT__TimeW__1EF99443");
        });

        modelBuilder.Entity<EmployeeTimeWorkedDetailsAudit>(entity =>
        {
            entity.ToTable("EmployeeTimeWorkedDetails_Audit", "emp", tb => tb.HasComment("audit trail of updates and movements, specific to timeworkeddetail "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DetailEndTime).HasColumnType("datetime");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.DetailStartTime).HasColumnType("datetime");
            entity.Property(e => e.Dmltype)
                .HasMaxLength(50)
                .HasColumnName("DMLType");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsBreak).HasColumnName("isBreak");
            entity.Property(e => e.IsDoubleRate).HasColumnName("isDoubleRate");
            entity.Property(e => e.IsOtrate).HasColumnName("isOTRate");
            entity.Property(e => e.IsRegRate).HasColumnName("isRegRate");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TimeWorkedShiftId).HasColumnName("TimeWorkedShiftID");
        });

        modelBuilder.Entity<EmployeeTimeWorkedShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F99279A0E");

            entity.ToTable("EmployeeTimeWorkedShifts", "emp", tb => tb.HasComment("Shift information, including pay/bill rates, as existing at the time of beginning a shift.  "));

            entity.HasIndex(e => e.BranchEmployeeAssignmentId, "ix_emp_EmployeeTimeWorkedShifts_BranchEmployeeAssignmentID");

            entity.HasIndex(e => e.BranchEmployeeAssignmentId, "ix_emp_EmployeeTimeWorkedShifts_BranchEmployeeAssignmentID1");

            entity.HasIndex(e => e.BranchEmployeeAssignmentId, "ix_emp_EmployeeTimeWorkedShifts_BranchEmployeeAssignmentID2");

            entity.HasIndex(e => e.BranchEmployeeAssignmentId, "ix_emp_EmployeeTimeWorkedShifts_BranchEmployeeAssignmentID22");

            entity.HasIndex(e => e.EmployeeTimeCardId, "ix_emp_EmployeeTimeWorkedShifts_EmployeeTimeCardID");

            entity.HasIndex(e => e.ShiftEndDate, "ix_emp_EmployeeTimeWorkedShifts_ShiftEndDate");

            entity.HasIndex(e => e.IsApproved, "ix_emp_EmployeeTimeWorkedShifts_isApproved");

            entity.HasIndex(e => e.IsApproved, "ix_emp_EmployeeTimeWorkedShifts_isApproved3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedById)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.BranchEmployeeAssignmentId).HasColumnName("BranchEmployeeAssignmentID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmployeeTimeCardId).HasColumnName("EmployeeTimeCardID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");

            entity.HasOne(d => d.BranchEmployeeAssignment).WithMany(p => p.EmployeeTimeWorkedShifts)
                .HasForeignKey(d => d.BranchEmployeeAssignmentId)
                .HasConstraintName("FK__EmployeeT__Branc__1940BAED");

            entity.HasOne(d => d.EmployeeTimeCard).WithMany(p => p.EmployeeTimeWorkedShifts)
                .HasForeignKey(d => d.EmployeeTimeCardId)
                .HasConstraintName("FK__EmployeeT__Emplo__4F3DA442");
        });

        modelBuilder.Entity<GeoCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasComment("DEPRECATED/REPLACED "));

            entity.Property(e => e.GeoCode1)
                .HasMaxLength(50)
                .HasColumnName("GeoCode");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoicableItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Invoicab__3213E83FBD737287");

            entity.ToTable("InvoicableItems", "acc");

            entity.HasIndex(e => e.PayPeriodId, "ix_acc_InvoicableItems_PayPeriodID");

            entity.HasIndex(e => new { e.PayPeriodId, e.JobSiteId, e.InvoiceId }, "ix_acc_InvoicableItems_PayPeriodID_JobSiteID_InvoiceID");

            entity.HasIndex(e => new { e.PaycheckId, e.BillToEmployeeAssignmentId, e.JobSiteId, e.ShiftDefinitionId, e.BillRate }, "ix_acc_InvoicableItems_PaycheckID_BillToEmployeeAssignmentID_JobSiteID_ShiftDefinitionID_BillRate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acaamount)
                .HasColumnType("money")
                .HasColumnName("ACAAmount");
            entity.Property(e => e.Acapercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ACAPercent");
            entity.Property(e => e.ApprovedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedByUserID");
            entity.Property(e => e.ApprovedDt)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedDT");
            entity.Property(e => e.BillRate).HasColumnType("money");
            entity.Property(e => e.BillToBranchClientId).HasColumnName("BillToBranchClientID");
            entity.Property(e => e.BillToEmployeeAssignmentId).HasColumnName("BillToEmployeeAssignmentID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DateSubmitted).HasColumnType("datetime");
            entity.Property(e => e.Descrip).HasMaxLength(500);
            entity.Property(e => e.EmployeeFirstName).HasMaxLength(500);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeLastName).HasMaxLength(500);
            entity.Property(e => e.InvoiceCreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceCreatedByUserID");
            entity.Property(e => e.InvoiceCreatedDt)
                .HasColumnType("datetime")
                .HasColumnName("InvoiceCreatedDT");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(false)
                .HasColumnName("isApproved");
            entity.Property(e => e.IsSubmitted)
                .HasDefaultValue(false)
                .HasColumnName("isSubmitted");
            entity.Property(e => e.ItemTotalBilled).HasColumnType("money");
            entity.Property(e => e.ItemTotalPaid).HasColumnType("money");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OtherDescription).HasMaxLength(500);
            entity.Property(e => e.PayCheckPaysId).HasColumnName("PayCheckPaysID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PayPeriodStartDt).HasColumnName("PayPeriodStartDT");
            entity.Property(e => e.PayRate).HasColumnType("money");
            entity.Property(e => e.PaycheckId).HasColumnName("PaycheckID");
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.PositionName).HasMaxLength(500);
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ShiftDefinitionId).HasColumnName("ShiftDefinitionID");
            entity.Property(e => e.ShiftName).HasMaxLength(500);
            entity.Property(e => e.SubmittedByUserId)
                .HasMaxLength(50)
                .HasColumnName("SubmittedByUserID");
            entity.Property(e => e.SupervisorName).HasMaxLength(500);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TimeCardId).HasColumnName("TimeCardID");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Invoices__3213E83FD05D1FD1");

            entity.ToTable("Invoices", "acc", tb => tb.HasComment("Invoice high level - Not fully normalized because we want an invoice's content to be locked at the point that we create it, and edited independently of any dimensional data. "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acaamount)
                .HasColumnType("money")
                .HasColumnName("ACAAmount");
            entity.Property(e => e.Acapercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ACAPercent");
            entity.Property(e => e.Adjustment).HasColumnType("money");
            entity.Property(e => e.AmountPaidToDate).HasColumnType("money");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ContactAddress1).HasMaxLength(500);
            entity.Property(e => e.ContactAddress2).HasMaxLength(500);
            entity.Property(e => e.ContactCity).HasMaxLength(500);
            entity.Property(e => e.ContactEmail).HasMaxLength(500);
            entity.Property(e => e.ContactName).HasMaxLength(500);
            entity.Property(e => e.ContactPhone).HasMaxLength(500);
            entity.Property(e => e.ContactState).HasMaxLength(500);
            entity.Property(e => e.ContactTaxNumber).HasMaxLength(500);
            entity.Property(e => e.ContactZipCode).HasMaxLength(500);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DoubleDue).HasColumnType("money");
            entity.Property(e => e.DoubleHrs).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.GrossDue).HasColumnType("money");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsVoid)
                .HasDefaultValue(false)
                .HasColumnName("isVoid");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OrderNumber).HasMaxLength(100);
            entity.Property(e => e.Otdue)
                .HasColumnType("money")
                .HasColumnName("OTDue");
            entity.Property(e => e.OtherDue).HasColumnType("money");
            entity.Property(e => e.Othrs)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OTHrs");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDue).HasColumnType("money");
            entity.Property(e => e.RegHrs).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TermsId).HasColumnName("TermsID");
            entity.Property(e => e.TotalDue)
                .HasComputedColumnSql("(((((isnull([grossdue],(0))+isnull([TotalTaxAmount],(0)))+isnull([Adjustment],(0)))+isnull([ACAAmount],(0)))-isnull([DiscountAmount],(0)))-isnull([AmountPaidToDate],(0)))", false)
                .HasColumnType("money");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("money");
            entity.Property(e => e.VoidedDt).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__Invoices__Branch__13F1F5EB");

            entity.HasOne(d => d.Client).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__Invoices__Client__76B698BF");

            entity.HasOne(d => d.JobSite).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.JobSiteId)
                .HasConstraintName("FK__Invoices__JobSit__14E61A24");

            entity.HasOne(d => d.Terms).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.TermsId)
                .HasConstraintName("FK__Invoices__TermsI__15DA3E5D");
        });

        modelBuilder.Entity<InvoiceItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceI__3213E83FD65FA817");

            entity.ToTable("InvoiceItems", "acc", tb => tb.HasComment("Line items for invoices"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acaamount)
                .HasColumnType("money")
                .HasColumnName("ACAAmount");
            entity.Property(e => e.Acapercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ACAPercent");
            entity.Property(e => e.BranchEmployeeAssignmentId).HasColumnName("BranchEmployeeAssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DepartmentName).HasMaxLength(500);
            entity.Property(e => e.DescriptionText).HasMaxLength(500);
            entity.Property(e => e.EmployeeFirstName).HasMaxLength(100);
            entity.Property(e => e.EmployeeLastName).HasMaxLength(100);
            entity.Property(e => e.GrossTotal).HasColumnType("money");
            entity.Property(e => e.GroupTicketId).HasColumnName("GroupTicketID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemTotal)
                .HasComputedColumnSql("([rate]*[Quantity]+[TaxAmount])", false)
                .HasColumnType("decimal(31, 6)");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PositionText).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.ShiftName).HasMaxLength(500);
            entity.Property(e => e.SupervisorName).HasMaxLength(100);
            entity.Property(e => e.TaxAmount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.TimeCardNumber).HasMaxLength(50);

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.InvoiceItems)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_InvoiceItems_BranchEmployees");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceItems)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK__InvoiceIt__Invoi__318258D2");
        });

        modelBuilder.Entity<InvoiceRoyalty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvoiceRoyalties", "acc");

            entity.Property(e => e.BaseRatePct).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DiscountPct).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.EffectiveRate).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.GrossAr)
                .HasColumnType("money")
                .HasColumnName("GrossAR");
            entity.Property(e => e.GrossRoyaltyValue).HasColumnType("money");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsJournaled)
                .HasDefaultValue(false)
                .HasColumnName("isJournaled");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.NetRoyaltyValue).HasColumnType("money");

            entity.HasOne(d => d.Invoice).WithMany()
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK__InvoiceRo__Invoi__46C92529");
        });

        modelBuilder.Entity<JobOrderSkillsNeeded>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobOrder__3213E83F5423E116");

            entity.ToTable("JobOrderSkillsNeeded", tb => tb.HasComment("DEPRECATED/REPLACED "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");

            entity.HasOne(d => d.JobOrder).WithMany(p => p.JobOrderSkillsNeededs)
                .HasForeignKey(d => d.JobOrderId)
                .HasConstraintName("FK_JobOrderSkillsNeeded_BranchJobOrders");

            entity.HasOne(d => d.Skill).WithMany(p => p.JobOrderSkillsNeededs)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK__JobOrderS__Skill__5D2BD0E6");
        });

        modelBuilder.Entity<Jobordercache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jobordercache");

            entity.Property(e => e.Branchclientid).HasColumnName("branchclientid");
            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Joborderid).HasColumnName("joborderid");
            entity.Property(e => e.Joborderident)
                .HasMaxLength(50)
                .HasColumnName("joborderident");
        });

        modelBuilder.Entity<LedgerEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledger_entries_id");

            entity.ToTable("LedgerEntries", "acc", tb => tb.HasComment("IN PROGRESS - "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.EntryType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Account).WithMany(p => p.LedgerEntries)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK__LedgerEnt__Accou__4707859D");

            entity.HasOne(d => d.Transaction).WithMany(p => p.LedgerEntries)
                .HasForeignKey(d => d.TransactionId)
                .HasConstraintName("FK__LedgerEnt__Trans__46136164");
        });

        modelBuilder.Entity<PayCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayCheck__3213E83FABC33122");

            entity.ToTable("PayChecks", "emp", tb => tb.HasComment("Instance of a paycheck for an employee "));

            entity.HasIndex(e => new { e.BranchPayPeriodId, e.IsActive }, "ix_Paychecks_BranchPayPeriodID");

            entity.HasIndex(e => e.BranchPayPeriodId, "ix_emp_PayChecks_BranchPayPeriodID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedOnUTCDt");
            entity.Property(e => e.DoNotPay)
                .HasDefaultValue(false)
                .HasColumnName("doNotPay");
            entity.Property(e => e.IsAch).HasColumnName("isACH");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsDraft)
                .HasDefaultValue(true)
                .HasColumnName("isDraft");
            entity.Property(e => e.IsPaperCheck).HasColumnName("isPaperCheck");
            entity.Property(e => e.IsPayCard).HasColumnName("isPayCard");
            entity.Property(e => e.IsVoid)
                .HasDefaultValue(false)
                .HasColumnName("isVoid");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedUTCDt");
            entity.Property(e => e.Ssnmasked)
                .HasMaxLength(255)
                .HasColumnName("SSNMasked");
            entity.Property(e => e.VoidReplacedByPaycheckId).HasColumnName("VoidReplacedByPaycheckID");
            entity.Property(e => e.VoidedByUserId)
                .HasMaxLength(50)
                .HasColumnName("VoidedByUserID");
            entity.Property(e => e.VoidedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("VoidedDTUTC");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.PayChecks)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK__PayChecks__Branc__556091EC");

            entity.HasOne(d => d.BranchPayPeriod).WithMany(p => p.PayChecks)
                .HasForeignKey(d => d.BranchPayPeriodId)
                .HasConstraintName("FK__PayChecks__Branc__5654B625");
        });

        modelBuilder.Entity<PayCheckFinalPayDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayCheck__3213E83FB26BAD2C");

            entity.ToTable("PayCheckFinalPayDetails", "emp", tb => tb.HasComment("IN PROGRESS "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.Address1).HasMaxLength(2048);
            entity.Property(e => e.Address2).HasMaxLength(2048);
            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CheckNum).HasMaxLength(20);
            entity.Property(e => e.City).HasMaxLength(2048);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmpFirstName).HasMaxLength(200);
            entity.Property(e => e.EmpLastName).HasMaxLength(200);
            entity.Property(e => e.EmployeeType).HasMaxLength(25);
            entity.Property(e => e.FromAcctNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.FromRoutNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.IsAch)
                .HasDefaultValue(false)
                .HasColumnName("isACH");
            entity.Property(e => e.IsPaperCheck)
                .HasDefaultValue(false)
                .HasColumnName("isPaperCheck");
            entity.Property(e => e.IsPayCard)
                .HasDefaultValue(false)
                .HasColumnName("isPayCard");
            entity.Property(e => e.IsVoid)
                .HasDefaultValue(false)
                .HasColumnName("isVoid");
            entity.Property(e => e.NetPay).HasColumnType("money");
            entity.Property(e => e.OfficeCode).HasMaxLength(10);
            entity.Property(e => e.PayAllocationId).HasColumnName("PayAllocationID");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.RoutingNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.TaxPayerIdencrypted)
                .HasMaxLength(2048)
                .HasColumnName("TaxPayerIDEncrypted");
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.PayCheckFinalPayDetails)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK__PayCheckF__Branc__257C74A0");

            entity.HasOne(d => d.PayAllocation).WithMany(p => p.PayCheckFinalPayDetails)
                .HasForeignKey(d => d.PayAllocationId)
                .HasConstraintName("FK__PayCheckF__PayAl__2A4129BD");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.PayCheckFinalPayDetails)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK__PayCheckF__PayCh__2B354DF6");

            entity.HasOne(d => d.State).WithMany(p => p.PayCheckFinalPayDetails)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__PayCheckF__State__2C29722F");
        });

        modelBuilder.Entity<PayChecksDeduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayCheck__3213E83F91E11CAA");

            entity.ToTable("PayChecksDeductions", "emp", tb => tb.HasComment("All deductions recorded for a paycheck "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedOnUTCDt");
            entity.Property(e => e.EmployeeDeductionInstanceId).HasColumnName("EmployeeDeductionInstanceID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsPreTax).HasColumnName("isPreTax");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedUTCDt");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");

            entity.HasOne(d => d.DeductionTypeNavigation).WithMany(p => p.PayChecksDeductions)
                .HasForeignKey(d => d.DeductionType)
                .HasConstraintName("FK_PayChecksDeductions_vt_PayrollDeductionTypesBranchAssoc");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.PayChecksDeductions)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK__PayChecks__PayCh__6E2C3FB6");
        });

        modelBuilder.Entity<PayChecksPay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayCheck__3213E83FC9B3A6B5");

            entity.ToTable("PayChecksPays", "emp", tb => tb.HasComment("All pay items for a paycheck "));

            entity.HasIndex(e => e.BillableToBranchAssignmentId, "ix_emp_PayChecksPays_BillableToBranchAssignmentID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddlPayBillTotal).HasColumnType("money");
            entity.Property(e => e.BillableToBranchAssignmentId).HasColumnName("BillableToBranchAssignmentID");
            entity.Property(e => e.BillableToBranchClientId).HasColumnName("BillableToBranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedOnUTCDt");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsTaxable)
                .HasDefaultValue(true)
                .HasColumnName("isTaxable");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedUtcdt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedUTCDt");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ShiftName).HasMaxLength(100);
            entity.Property(e => e.ShiftScheduleDays).HasMaxLength(50);
            entity.Property(e => e.ShiftScheduleShiftduration).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UnitAmount).HasColumnType("money");

            entity.HasOne(d => d.BillableToBranchAssignment).WithMany(p => p.PayChecksPays)
                .HasForeignKey(d => d.BillableToBranchAssignmentId)
                .HasConstraintName("FK__PayChecks__Billa__609D3A6E");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.PayChecksPays)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK__PayChecks__PayCh__677F4227");

            entity.HasOne(d => d.PayTypeNavigation).WithMany(p => p.PayChecksPays)
                .HasForeignKey(d => d.PayType)
                .HasConstraintName("FK_PayChecksPays_vt_PayrollPayTypes");
        });

        modelBuilder.Entity<PayChecksTimeDetailsAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayCheck__3213E83F8E97ABCA");

            entity.ToTable("PayChecksTimeDetailsAssoc", "emp");

            entity.HasIndex(e => e.PayCheckPaysId, "ix_emp_PayChecksTimeDetailsAssoc_PayCheckPaysID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayCheckPaysId).HasColumnName("PayCheckPaysID");
            entity.Property(e => e.TimeWorkedDetailsId).HasColumnName("TimeWorkedDetailsID");
        });

        modelBuilder.Entity<PayrollBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayrollB__3213E83FF957C076");

            entity.ToTable("PayrollBatches", "emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
        });

        modelBuilder.Entity<PayrollBatchPayPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayrollB__3213E83F3A227278");

            entity.ToTable("PayrollBatchPayPeriods", "emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
        });

        modelBuilder.Entity<PayrollCheckSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayrollCheckSummary", "acc");

            entity.Property(e => e.AchdownloadDt)
                .HasColumnType("datetime")
                .HasColumnName("ACHDownloadDT");
            entity.Property(e => e.Achdownloaded)
                .HasDefaultValue(false)
                .HasColumnName("ACHDownloaded");
            entity.Property(e => e.AchdownloadedByUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACHDownloadedByUserID");
            entity.Property(e => e.AchreplacedWithPaperCheck)
                .HasDefaultValue(false)
                .HasColumnName("ACHReplacedWithPaperCheck");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CheckDocumentId).HasColumnName("CheckDocumentID");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[fn_ACHState]([id]))", false);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Deductions).HasColumnType("money");
            entity.Property(e => e.EmpFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpTaxId)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("EmpTaxID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Erfica)
                .HasColumnType("money")
                .HasColumnName("ERFICA");
            entity.Property(e => e.Fica)
                .HasColumnType("money")
                .HasColumnName("FICA");
            entity.Property(e => e.Fit)
                .HasColumnType("money")
                .HasColumnName("FIT");
            entity.Property(e => e.FromAccountNum)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("fromAccountNum");
            entity.Property(e => e.FromRoutingNum)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("fromRoutingNum");
            entity.Property(e => e.Futa)
                .HasColumnType("money")
                .HasColumnName("FUTA");
            entity.Property(e => e.Garnishments).HasColumnType("money");
            entity.Property(e => e.GrossPay).HasColumnType("money");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsJournaled)
                .HasDefaultValue(false)
                .HasColumnName("isJournaled");
            entity.Property(e => e.JournaledDt)
                .HasColumnType("datetime")
                .HasColumnName("JournaledDT");
            entity.Property(e => e.NetPay).HasColumnType("money");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PaycheckId).HasColumnName("paycheckID");
            entity.Property(e => e.PosPayDownloadDt)
                .HasColumnType("datetime")
                .HasColumnName("PosPayDownloadDT");
            entity.Property(e => e.PosPayDownloaded).HasDefaultValue(false);
            entity.Property(e => e.PosPayDownloadedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PosPayDownloadedByUserID");
            entity.Property(e => e.Sit)
                .HasColumnType("money")
                .HasColumnName("SIT");
            entity.Property(e => e.Suta)
                .HasColumnType("money")
                .HasColumnName("SUTA");
            entity.Property(e => e.ToAccountNum)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("toAccountNum");
            entity.Property(e => e.ToRoutingNum)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("toRoutingNum");
        });

        modelBuilder.Entity<PayrollCheckSummaryLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayrollCheckSummaryLog", "acc");

            entity.Property(e => e.CheckStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckSummaryId).HasColumnName("CheckSummaryID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<PdfDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pdfData__3213E83F04A89484");

            entity.ToTable("pdfData");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDTUTC");
            entity.Property(e => e.PdfData).HasColumnName("pdfData");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("token");
        });

        modelBuilder.Entity<PositivePayManifest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Positive__3213E83F5C064ED1");

            entity.ToTable("PositivePayManifest", "acc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FromAccountEncrypted).HasMaxLength(2000);
            entity.Property(e => e.IsSentToBank)
                .HasDefaultValue(false)
                .HasColumnName("isSentToBank");
            entity.Property(e => e.IsVoid).HasColumnName("isVoid");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PaycheckId).HasColumnName("PaycheckID");
            entity.Property(e => e.SentToBankDt)
                .HasColumnType("datetime")
                .HasColumnName("SentToBankDT");
        });

        modelBuilder.Entity<PreUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PreUser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountInviteId)
                .HasMaxLength(500)
                .HasColumnName("AccountInviteID");
            entity.Property(e => e.AppRoleId).HasColumnName("AppRoleID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.InvitedUserId)
                .HasMaxLength(100)
                .HasColumnName("InvitedUserID");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasColumnName("token");

            entity.HasOne(d => d.AccountInvite).WithMany(p => p.PreUsers)
                .HasForeignKey(d => d.AccountInviteId)
                .HasConstraintName("FK_PreUser_AccountInvite");

            entity.HasOne(d => d.AppRole).WithMany(p => p.PreUsers)
                .HasForeignKey(d => d.AppRoleId)
                .HasConstraintName("FK_PreUser_AppRoles");

            entity.HasOne(d => d.InvitedUser).WithMany(p => p.PreUsers)
                .HasForeignKey(d => d.InvitedUserId)
                .HasConstraintName("FK_PreUser_Users");
        });

        modelBuilder.Entity<QueryWorstTsql>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("query_WorstTSQL", tb => tb.HasComment("used for performance analysis during development. not for production.  "));

            entity.Property(e => e.AverageIos).HasColumnName("Average IOs");
            entity.Property(e => e.AvgCpu).HasColumnName("Avg CPU");
            entity.Property(e => e.AvgElapsedTime).HasColumnName("Avg Elapsed Time");
            entity.Property(e => e.AvgLogicalReads).HasColumnName("Avg Logical Reads");
            entity.Property(e => e.AvgLogicalWrites).HasColumnName("Avg Logical Writes");
            entity.Property(e => e.AvgPhysicalReads).HasColumnName("Avg Physical Reads");
            entity.Property(e => e.CachedPlanObjtype)
                .HasMaxLength(20)
                .HasColumnName("Cached Plan objtype");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(1000)
                .HasColumnName("Database Name");
            entity.Property(e => e.ExecutionCount).HasColumnName("Execution Count");
            entity.Property(e => e.LastExecutionTime)
                .HasColumnType("datetime")
                .HasColumnName("Last Execution Time");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(128)
                .HasColumnName("Object Name");
            entity.Property(e => e.SchemaName)
                .HasMaxLength(128)
                .HasColumnName("Schema Name");
            entity.Property(e => e.Statement).HasColumnType("ntext");
            entity.Property(e => e.TotalCpu).HasColumnName("Total CPU");
            entity.Property(e => e.TotalElaspedTime).HasColumnName("Total Elasped Time");
            entity.Property(e => e.TotalIos).HasColumnName("Total IOs");
            entity.Property(e => e.TotalLogicalReads).HasColumnName("Total Logical Reads");
            entity.Property(e => e.TotalLogicalWrites).HasColumnName("Total Logical Writes");
            entity.Property(e => e.TotalPhysicalReads).HasColumnName("Total Physical Reads");
        });

        modelBuilder.Entity<ReportInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__reportIn__3213E83F9EB37710");

            entity.ToTable("reportInstances");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ReportStatus).HasMaxLength(20);
            entity.Property(e => e.ReportTypeId).HasColumnName("ReportTypeID");
            entity.Property(e => e.UserReportName).HasMaxLength(100);
            entity.Property(e => e.WorkflowId)
                .HasMaxLength(50)
                .HasColumnName("workflowID");
        });

        modelBuilder.Entity<SkillGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SkillGro__3213E83F15B18184");

            entity.ToTable(tb => tb.HasComment("Groups the skills listed in vt_skills into topic-related groups "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillsGroupDefId).HasColumnName("SkillsGroupDefID");

            entity.HasOne(d => d.Skill).WithMany(p => p.SkillGroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK__SkillGrou__Skill__2E70E1FD");

            entity.HasOne(d => d.SkillsGroupDef).WithMany(p => p.SkillGroups)
                .HasForeignKey(d => d.SkillsGroupDefId)
                .HasConstraintName("FK__SkillGrou__Skill__2F650636");
        });

        modelBuilder.Entity<Talent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Talent__3213E83FCB75D846");

            entity.ToTable("Talent", tb => tb.HasComment("All applicants/employees, etc/ "));

            entity.HasIndex(e => e.RecruiterId, "ix_dbo_Talent_RecruiterID");

            entity.HasIndex(e => e.MsgThreadId, "ix_dbo_Talent_msgThreadID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1).HasMaxLength(2048);
            entity.Property(e => e.Address2).HasMaxLength(2048);
            entity.Property(e => e.City).HasMaxLength(2048);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.CreatedbyUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedbyUserID");
            entity.Property(e => e.DateOfBirth).HasMaxLength(50);
            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.EmailAddress2).HasMaxLength(200);
            entity.Property(e => e.EmergencyContactName).HasMaxLength(500);
            entity.Property(e => e.EmergencyContactPhone).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(50)
                .HasColumnName("geoCodeID");
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MiddleName).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.MsgThreadId)
                .HasMaxLength(50)
                .HasColumnName("msgThreadID");
            entity.Property(e => e.PreferredName).HasMaxLength(500);
            entity.Property(e => e.RecruitedByUserId)
                .HasMaxLength(50)
                .HasColumnName("RecruitedByUserID");
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(50)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SendSmsupdates).HasColumnName("SendSMSUpdates");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.TaxpayerId)
                .HasMaxLength(2048)
                .HasColumnName("TaxpayerID");
            entity.Property(e => e.ZipCode).HasMaxLength(20);

            entity.HasOne(d => d.State).WithMany(p => p.Talents)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__Talent__StateID__0DA4EB0F");
        });

        modelBuilder.Entity<TalentApplicationAddlQuestion>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.TalentAnswer).HasMaxLength(2048);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Question).WithMany(p => p.TalentApplicationAddlQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentAppQuestions_TalentAppQuestions");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentApplicationAddlQuestions)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentApplicationAddlQuestions_Talent");
        });

        modelBuilder.Entity<TalentApplicationJobOrderShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentAp__3213E83FBF43DC36");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationInstanceId).HasColumnName("ApplicationInstanceID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ShiftScheduleId).HasColumnName("ShiftScheduleID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.ApplicationInstance).WithMany(p => p.TalentApplicationJobOrderShifts)
                .HasForeignKey(d => d.ApplicationInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentApp__Appli__68C93772");

            entity.HasOne(d => d.JobOrder).WithMany(p => p.TalentApplicationJobOrderShifts)
                .HasForeignKey(d => d.JobOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentApp__JobOr__67D51339");

            entity.HasOne(d => d.ShiftSchedule).WithMany(p => p.TalentApplicationJobOrderShifts)
                .HasForeignKey(d => d.ShiftScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentApp__Shift__69BD5BAB");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentApplicationJobOrderShifts)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentApp__Talen__66E0EF00");
        });

        modelBuilder.Entity<TalentApplicationStatement>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StatementId).HasColumnName("StatementID");
            entity.Property(e => e.TalentAnswer).HasMaxLength(2048);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.Employee).WithMany(p => p.TalentApplicationStatements)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__TalentApp__Emplo__2C7F4341");

            entity.HasOne(d => d.Statement).WithMany(p => p.TalentApplicationStatements)
                .HasForeignKey(d => d.StatementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentAppstatements_branchappstatements");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentApplicationStatements)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentApplicationStatements_Talent");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TalentApplicationStatements)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TalentApp__Tenan__2B8B1F08");
        });

        modelBuilder.Entity<TalentAtworkHistory>(entity =>
        {
            entity.ToTable("TalentAtworkHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.WorkedAtWorkBefore)
                .HasDefaultValue(false)
                .HasColumnName("workedAtWorkBefore");
            entity.Property(e => e.WorkedBranchId).HasColumnName("workedBranchID");
            entity.Property(e => e.WorkedLocation)
                .HasMaxLength(500)
                .HasColumnName("workedLocation");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentAtworkHistories)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentAtworkHistory_Talent");
        });

        modelBuilder.Entity<TalentAvailability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentAv__3213E83FC175E656");

            entity.ToTable("TalentAvailability");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AvailabilityId).HasColumnName("AvailabilityID");
            entity.Property(e => e.AvailableDate).HasColumnName("availableDate");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Shift1).HasDefaultValue(false);
            entity.Property(e => e.Shift2).HasDefaultValue(false);
            entity.Property(e => e.Shift3).HasDefaultValue(false);
            entity.Property(e => e.ShiftFlexible).HasDefaultValue(false);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentAvailabilities)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK__TalentAva__Talen__5BD950A8");
        });

        modelBuilder.Entity<TalentBankAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentBa__3213E83F62636FEB");

            entity.ToTable(tb => tb.HasComment("Encrypted bank account information for talent EFT payments.  "));

            entity.HasIndex(e => new { e.TalentId, e.IsActive }, "ix_dbo_TalentBankAccounts_TalentID_isActive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.BankName).HasMaxLength(250);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(100)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsVerified)
                .HasDefaultValue(false)
                .HasColumnName("isVerified");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(100)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RoutingNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.RoutingNumber).HasMaxLength(50);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.AccountType).WithMany(p => p.TalentBankAccounts)
                .HasForeignKey(d => d.AccountTypeId)
                .HasConstraintName("FK__TalentBan__Accou__172E5549");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentBankAccounts)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK__TalentBan__Talen__163A3110");
        });

        modelBuilder.Entity<TalentBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentBr__3213E83F2304EC7B");

            entity.ToTable(tb => tb.HasComment("Branches each talent is associated with, either by job application or employment.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Branch).WithMany(p => p.TalentBranches)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_TalentBranches_TenantBranches");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentBranches)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK_TalentBranches_Talent");
        });

        modelBuilder.Entity<TalentCertification>(entity =>
        {
            entity.ToTable("TalentCertification");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertificationName).HasMaxLength(500);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentCertifications)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentCertification_Talent");
        });

        modelBuilder.Entity<TalentConditionalJobOffer>(entity =>
        {
            entity.ToTable("TalentConditionalJobOffer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppId).HasColumnName("AppID");
            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.Conditions).HasMaxLength(1024);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("createdByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("createdDTUTC");
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDTUTC");
            entity.Property(e => e.Modifiedbyuserid).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.OfferDate).HasColumnType("datetime");
            entity.Property(e => e.TalentId).HasColumnName("talentID");
            entity.Property(e => e.TalentResponseDate).HasColumnType("datetime");
            entity.Property(e => e.TalentResponseId).HasColumnName("talentResponseID");

            entity.HasOne(d => d.App).WithMany(p => p.TalentConditionalJobOffers)
                .HasForeignKey(d => d.AppId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentConditionalJobOffer_TalentJobOrderAppInstance");

            entity.HasOne(d => d.Branch).WithMany(p => p.TalentConditionalJobOffers)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentConditionalJobOffer_TenantBranches");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentConditionalJobOffers)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentConditionalJobOffer_Talent");

            entity.HasOne(d => d.TalentResponse).WithMany(p => p.TalentConditionalJobOffers)
                .HasForeignKey(d => d.TalentResponseId)
                .HasConstraintName("FK_TalentConditionalJobOffer_TalentResponse");
        });

        modelBuilder.Entity<TalentDnr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentDN__3213E83FFCE4139F");

            entity.ToTable("TalentDNR");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Dnrnote).HasColumnName("DNRNote");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<TalentDocumentUpload>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("createdByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("createdDTUTC");
            entity.Property(e => e.DocDescription).HasMaxLength(2048);
            entity.Property(e => e.DocFriendlyName).HasMaxLength(100);
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDTUTC");
            entity.Property(e => e.Modifiedbyuserid).HasMaxLength(50);
            entity.Property(e => e.SignDate).HasColumnType("datetime");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentDocumentUploads)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentDocumentUploads_Talent");
        });

        modelBuilder.Entity<TalentDrugScreen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentDr__3213E83FEF602F0D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectedByName).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.ResultLotNum).HasMaxLength(50);
            entity.Property(e => e.ScreeningReasonId).HasColumnName("ScreeningReasonID");
            entity.Property(e => e.ScreeningTypeId).HasColumnName("ScreeningTypeID");
            entity.Property(e => e.SpecimenIdent).HasMaxLength(100);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TesterId)
                .HasMaxLength(50)
                .HasColumnName("TesterID");
        });

        modelBuilder.Entity<TalentDrugScreensResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentDr__3213E83FFA72E4F2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DrugScreenId).HasColumnName("DrugScreenID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ResultId).HasColumnName("ResultID");
        });

        modelBuilder.Entity<TalentEducation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentEd__3213E83FAC163C8B");

            entity.ToTable("TalentEducation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaOfStudy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.InstitutionName).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.YearsAttended).HasMaxLength(100);
        });

        modelBuilder.Entity<TalentEmergencyContact>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactName).HasMaxLength(500);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PhoneNumber).HasMaxLength(100);
            entity.Property(e => e.Relationship).HasMaxLength(500);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentEmergencyContacts)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentEmergencyContacts_Talent");
        });

        modelBuilder.Entity<TalentEmploymentHistory>(entity =>
        {
            entity.ToTable("TalentEmploymentHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyAddress).HasMaxLength(2048);
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.CompanyPhone).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EndingSallary).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LeavingReason).HasMaxLength(2048);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Position).HasMaxLength(500);
            entity.Property(e => e.Responsabilities).HasMaxLength(2048);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.Title).HasMaxLength(500);

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentEmploymentHistories)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentEmploymentHistory_Talent");
        });

        modelBuilder.Entity<TalentJobOrderApplicationInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentJo__3213E83F4857911D");

            entity.ToTable("TalentJobOrderApplicationInstance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationDefInstanceId).HasColumnName("ApplicationDefInstanceID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.IsStale).HasColumnName("isStale");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<TalentJobOrderApplicationInstanceStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentJo__3213E83F95275D85");

            entity.ToTable(tb => tb.HasTrigger("t_TalentAppCompleteStep"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppDefInstanceStepId).HasColumnName("AppDefInstanceStepID");
            entity.Property(e => e.CompletedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CompletedByUserID");
            entity.Property(e => e.CompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("CompletedDT");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.IsStale).HasColumnName("isStale");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentJobOrderApplicationInstanceId).HasColumnName("TalentJobOrderApplicationInstanceID");
        });

        modelBuilder.Entity<TalentJobOrderApplicationInstanceSubStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentJo__3213E83F2CA85FBD");

            entity.ToTable(tb => tb.HasTrigger("t_TalentAppCompleteSubStep"));

            entity.HasIndex(e => e.AppDefInstanceSubStepId, "ix_dbo_TalentJobOrderApplicationInstanceSubSteps_AppDefInstanceSubStepID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppDefInstanceSubStepId).HasColumnName("AppDefInstanceSubStepID");
            entity.Property(e => e.CompletedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CompletedByUserID");
            entity.Property(e => e.CompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("CompletedDT");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.IsStale).HasColumnName("isStale");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentJobOrderApplicationInstanceStepId).HasColumnName("TalentJobOrderApplicationInstanceStepID");
        });

        modelBuilder.Entity<TalentJobOrderApplicationInterviewQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentJo__3213E83FBE0A44CE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationDefId).HasColumnName("ApplicationDefID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<TalentJobOrderDirectHire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentJo__3213E83F4D8C3421");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FeeAmount).HasColumnType("money");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsRescinded).HasColumnName("isRescinded");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RescindedDt).HasColumnName("RescindedDT");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<TalentProfileVerifySectionConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentPr__3213E83FFC6245B5");

            entity.ToTable("TalentProfileVerifySectionConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SectionDefId).HasColumnName("SectionDefID");
            entity.Property(e => e.SectionSupported).HasDefaultValue(true);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.SectionDef).WithMany(p => p.TalentProfileVerifySectionConfigs)
                .HasForeignKey(d => d.SectionDefId)
                .HasConstraintName("FK__TalentPro__Secti__4401C717");
        });

        modelBuilder.Entity<TalentProfileVerifySectionDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentPr__3213E83FD3A071C1");

            entity.ToTable("TalentProfileVerifySectionDef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SectionDisplayName).HasMaxLength(100);
            entity.Property(e => e.SectionIdentifier).HasMaxLength(50);
        });

        modelBuilder.Entity<TalentReference>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ReferenceName).HasMaxLength(500);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentReferences)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentReferences_Talent");
        });

        modelBuilder.Entity<TalentSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentSk__3213E83F3370EA7C");

            entity.ToTable(tb => tb.HasComment("The skills associated with the talent.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalDetails).HasMaxLength(2048);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RelevantEmploymentHistory).HasMaxLength(2048);
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Skill).WithMany(p => p.TalentSkills)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK__TalentSki__Skill__38EE7070");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentSkills)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK__TalentSki__Talen__37FA4C37");
        });

        modelBuilder.Entity<TalentSupervisor>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CanContactThisSupervisor)
                .HasDefaultValue(false)
                .HasColumnName("canContactThisSupervisor");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.SupervisorName).HasMaxLength(500);
            entity.Property(e => e.TalentEmploymentId).HasColumnName("TalentEmploymentID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentSupervisors)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TalentSupervisors_Talent");
        });

        modelBuilder.Entity<TalentUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentUs__3213E83F72298D5C");

            entity.ToTable("TalentUser", tb => tb.HasComment("Associates a talent entity with a user account.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentUsers)
                .HasForeignKey(d => d.TalentId)
                .HasConstraintName("FK__TalentUse__Talen__4C2C2D6D");
        });

        modelBuilder.Entity<TalentWorkPreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TalentWo__3213E83FE1318642");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmploymentTypeId).HasColumnName("employmentTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");

            entity.HasOne(d => d.EmploymentType).WithMany(p => p.TalentWorkPreferences)
                .HasForeignKey(d => d.EmploymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentWor__emplo__6D8DEC8F");

            entity.HasOne(d => d.Talent).WithMany(p => p.TalentWorkPreferences)
                .HasForeignKey(d => d.TalentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TalentWor__Talen__6C99C856");
        });

        modelBuilder.Entity<TaxCompensation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__taxCompe__3213E83F25B992E8");

            entity.ToTable("taxCompensations", "emp", tb => tb.HasComment("IN PROGRESS "));

            entity.HasIndex(e => e.PayCheckId, "ix_emp_taxCompensations_PayCheckID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CompensationDescription)
                .HasMaxLength(200)
                .HasColumnName("compensationDescription");
            entity.Property(e => e.CompensationId)
                .HasMaxLength(200)
                .HasColumnName("compensationId");
            entity.Property(e => e.ExemptAmount)
                .HasColumnType("money")
                .HasColumnName("exemptAmount");
            entity.Property(e => e.GeocodeId)
                .HasMaxLength(200)
                .HasColumnName("geocodeId");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PayType)
                .HasMaxLength(200)
                .HasColumnName("payType");
            entity.Property(e => e.TaxIdentifierId)
                .HasMaxLength(200)
                .HasColumnName("taxIdentifierId");
            entity.Property(e => e.TaxName)
                .HasMaxLength(200)
                .HasColumnName("taxName");
            entity.Property(e => e.TaxType)
                .HasMaxLength(200)
                .HasColumnName("taxType");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("money")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.TaxingLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxingLocationType");
            entity.Property(e => e.UtilizedCompensationId)
                .HasMaxLength(200)
                .HasColumnName("utilizedCompensationId");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.TaxCompensations)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_taxCompensations_BranchEmployees");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.TaxCompensations)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK_taxCompensations_PayChecks");

            entity.HasOne(d => d.PayPeriod).WithMany(p => p.TaxCompensations)
                .HasForeignKey(d => d.PayPeriodId)
                .HasConstraintName("FK_taxCompensations_BranchPayPeriods");
        });

        modelBuilder.Entity<TaxFormDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__taxFormD__3213E83FD2832F22");

            entity.ToTable("taxFormData", "emp", tb => tb.HasComment("IN PROGRESS "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.FormDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("formDescription");
            entity.Property(e => e.FormExists)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("formExists");
            entity.Property(e => e.FormFieldIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("formFieldIdentifier");
            entity.Property(e => e.FormStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("formStatus");
            entity.Property(e => e.GeocodeId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("geocodeId");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.TaxIdentifierId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxIdentifierId");
            entity.Property(e => e.TaxName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxName");
            entity.Property(e => e.TaxType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxType");
            entity.Property(e => e.UtilizedFormValue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("utilizedFormValue");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.TaxFormData)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_taxFormData_BranchEmployees");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.TaxFormData)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK_taxFormData_PayChecks");

            entity.HasOne(d => d.PayPeriod).WithMany(p => p.TaxFormData)
                .HasForeignKey(d => d.PayPeriodId)
                .HasConstraintName("FK_taxFormData_BranchPayPeriods");
        });

        modelBuilder.Entity<TaxFormFieldDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxFormF__3213E83FFA4A0C35");

            entity.ToTable(tb => tb.HasComment("Tax form fields nationwide, as provided by the payroll tax API "));

            entity.HasIndex(e => new { e.GeoCodeId, e.StartDt, e.StopDt }, "ix_dbo_TaxFormFieldDefinitions_GeoCodeID_StartDT_StopDT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountyGeoCodeId)
                .HasMaxLength(500)
                .HasColumnName("CountyGeoCodeID");
            entity.Property(e => e.FedGeoCodeId)
                .HasMaxLength(500)
                .HasColumnName("FedGeoCodeID");
            entity.Property(e => e.FormDocumentation)
                .HasMaxLength(500)
                .HasColumnName("formDocumentation");
            entity.Property(e => e.FormFieldDescriptiveName)
                .HasMaxLength(500)
                .HasColumnName("formFieldDescriptiveName");
            entity.Property(e => e.FormFieldIdentifier).HasMaxLength(500);
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(500)
                .HasColumnName("GeoCodeID");
            entity.Property(e => e.ParentFormId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("parentFormID");
            entity.Property(e => e.ReciprocalJurisdictionGeoCodeId)
                .HasMaxLength(500)
                .HasColumnName("reciprocalJurisdictionGeoCodeId");
            entity.Property(e => e.SchoolDistrictId)
                .HasMaxLength(500)
                .HasColumnName("SchoolDistrictID");
            entity.Property(e => e.StartDt).HasColumnName("StartDT");
            entity.Property(e => e.StateGeoCodeId)
                .HasMaxLength(500)
                .HasColumnName("StateGeoCodeID");
            entity.Property(e => e.StopDt).HasColumnName("StopDT");
            entity.Property(e => e.TaxIdentifier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxIdentifierId)
                .HasMaxLength(500)
                .HasColumnName("taxIdentifierID");
            entity.Property(e => e.TaxName)
                .HasMaxLength(500)
                .HasColumnName("taxName");
        });

        modelBuilder.Entity<TaxTaxis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__taxTaxes__3213E83F14A5CFCB");

            entity.ToTable("taxTaxes", "emp", tb => tb.HasComment("IN PROGRESS "));

            entity.HasIndex(e => new { e.BranchEmployeeId, e.PayPeriodId }, "ix_emp_taxTaxes_BranchEmployeeID_PayPeriodID");

            entity.HasIndex(e => e.PayCheckId, "ix_emp_taxTaxes_PayCheckID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdjustedGross)
                .HasColumnType("money")
                .HasColumnName("adjustedGross");
            entity.Property(e => e.AdjustedSupplementalGross)
                .HasColumnType("money")
                .HasColumnName("adjustedSupplementalGross");
            entity.Property(e => e.AnnualizedAdjustedCurrentGross)
                .HasColumnType("money")
                .HasColumnName("annualizedAdjustedCurrentGross");
            entity.Property(e => e.AnnualizedAdjustedSupplementalGross)
                .HasColumnType("money")
                .HasColumnName("annualizedAdjustedSupplementalGross");
            entity.Property(e => e.AnnualizedRegularTax)
                .HasColumnType("money")
                .HasColumnName("annualizedRegularTax");
            entity.Property(e => e.AnnualizedSupplementalTax)
                .HasColumnType("money")
                .HasColumnName("annualizedSupplementalTax");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.CalculationMethod)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("calculationMethod");
            entity.Property(e => e.CalculationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("calculationStatus");
            entity.Property(e => e.FilingStatusId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("filingStatusId");
            entity.Property(e => e.GeocodeId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("geocodeId");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.Recalculation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("recalculation");
            entity.Property(e => e.SubjectGrossAmount)
                .HasColumnType("money")
                .HasColumnName("subjectGrossAmount");
            entity.Property(e => e.SupplementalPayTaxAmount)
                .HasColumnType("money")
                .HasColumnName("supplementalPayTaxAmount");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("money")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxIdentifierId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxIdentifierId");
            entity.Property(e => e.TaxName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxName");
            entity.Property(e => e.TaxType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("taxType");
            entity.Property(e => e.TaxableGross)
                .HasColumnType("money")
                .HasColumnName("taxableGross");
            entity.Property(e => e.TaxableTips)
                .HasColumnType("money")
                .HasColumnName("taxableTips");
            entity.Property(e => e.UtilizedAlternativeCalculationCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("utilizedAlternativeCalculationCode");
            entity.Property(e => e.UtilizedBaseAmount)
                .HasColumnType("money")
                .HasColumnName("utilizedBaseAmount");
            entity.Property(e => e.UtilizedExemptAmount)
                .HasColumnType("money")
                .HasColumnName("utilizedExemptAmount");
            entity.Property(e => e.UtilizedJurisdictionTreatmentInteraction)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("utilizedJurisdictionTreatmentInteraction");
            entity.Property(e => e.UtilizedMaximumDeductionAmount)
                .HasColumnType("money")
                .HasColumnName("utilizedMaximumDeductionAmount");
            entity.Property(e => e.UtilizedRate)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("utilizedRate");
            entity.Property(e => e.UtilizedSchoolDistrictId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("utilizedSchoolDistrictId");
            entity.Property(e => e.UtilizedSupplementalPayTypeTreatment)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("utilizedSupplementalPayTypeTreatment");
            entity.Property(e => e.UtilizedSupplementalRate)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("utilizedSupplementalRate");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.TaxTaxes)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_taxTaxes_BranchEmployees");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.TaxTaxes)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK_taxTaxes_PayChecks");

            entity.HasOne(d => d.PayPeriod).WithMany(p => p.TaxTaxes)
                .HasForeignKey(d => d.PayPeriodId)
                .HasConstraintName("FK_taxTaxes_BranchPayPeriods");
        });

        modelBuilder.Entity<TaxVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__taxVersi__3213E83F5F7CA66A");

            entity.ToTable("taxVersion", "emp", tb => tb.HasComment("IN PROGRESS "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.DataVersion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dataVersion");
            entity.Property(e => e.LegacyVersion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("legacyVersion");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.Version)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("version");

            entity.HasOne(d => d.BranchEmployee).WithMany(p => p.TaxVersions)
                .HasForeignKey(d => d.BranchEmployeeId)
                .HasConstraintName("FK_taxVersion_BranchEmployees");

            entity.HasOne(d => d.PayCheck).WithMany(p => p.TaxVersions)
                .HasForeignKey(d => d.PayCheckId)
                .HasConstraintName("FK_taxVersion_PayChecks");

            entity.HasOne(d => d.PayPeriod).WithMany(p => p.TaxVersions)
                .HasForeignKey(d => d.PayPeriodId)
                .HasConstraintName("FK_taxVersion_BranchPayPeriods");
        });

        modelBuilder.Entity<TbIxMissing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_ixMissing");

            entity.Property(e => e.CreateIndexStatement).HasMaxLength(4000);
            entity.Property(e => e.Dbname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dbname");
            entity.Property(e => e.EqualityColumns)
                .HasMaxLength(4000)
                .HasColumnName("equality_columns");
            entity.Property(e => e.IncludedColumns)
                .HasMaxLength(4000)
                .HasColumnName("included_columns");
            entity.Property(e => e.InequalityColumns)
                .HasMaxLength(4000)
                .HasColumnName("inequality_columns");
            entity.Property(e => e.LastUserSeek)
                .HasColumnType("datetime")
                .HasColumnName("last_user_seek");
            entity.Property(e => e.Objectname)
                .HasMaxLength(128)
                .HasColumnName("objectname");
            entity.Property(e => e.Schemaname)
                .HasMaxLength(128)
                .HasColumnName("schemaname");
        });

        modelBuilder.Entity<TempInvoiceDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TempInvo__3213E83F1A828626");

            entity.ToTable("TempInvoiceDates", "acc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Invoicedate).HasColumnName("invoicedate");
            entity.Property(e => e.Jobsiteid).HasColumnName("jobsiteid");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("ponumber");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tenants__3213E83F1695CF12");

            entity.ToTable(tb => tb.HasComment("These are the paying TS entities -- high-level defined as an EIN. Self-referencing parentage to maintain parent-child franchise relationship.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AchcompanyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACHCompanyID");
            entity.Property(e => e.BankAccountNumberEncrypted).HasMaxLength(2048);
            entity.Property(e => e.BankRoutingNumberEncrypted).HasMaxLength(2048);
            entity.Property(e => e.BranchIdentPrefix).HasMaxLength(20);
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("client_name");
            entity.Property(e => e.Ein)
                .HasMaxLength(50)
                .HasColumnName("EIN");
            entity.Property(e => e.MaxLicenses).HasColumnName("max_licenses");
            entity.Property(e => e.ParentCanEditCustomers).HasDefaultValue(true);
            entity.Property(e => e.ParentCanEditEmployees).HasDefaultValue(true);
            entity.Property(e => e.ParentCanViewCustomers).HasDefaultValue(true);
            entity.Property(e => e.ParentCanViewEmployees).HasDefaultValue(true);
            entity.Property(e => e.ParentCanViewFinancials).HasDefaultValue(true);
            entity.Property(e => e.ParentTenantId).HasColumnName("ParentTenantID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StartingAchnumber).HasColumnName("StartingACHNumber");
            entity.Property(e => e.UseParentCheckNumbers).HasDefaultValue(true);
        });

        modelBuilder.Entity<TenantApplicationTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantAp__3213E83F3FBAACDB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DerivedFromId).HasColumnName("derivedFromID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.TemplateName).HasMaxLength(200);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<TenantApplicationTemplateStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantAp__3213E83F26F5197D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.StepOrder).HasDefaultValue(0);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.UserType).HasMaxLength(50);
        });

        modelBuilder.Entity<TenantApplicationTemplateSubStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantAp__3213E83F2DDB8691");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DaysToStale).HasDefaultValue(5);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StepId).HasColumnName("StepID");
            entity.Property(e => e.SubStepName).HasMaxLength(100);
        });

        modelBuilder.Entity<TenantBankAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantBa__3213E83F62636FEB");

            entity.ToTable(tb => tb.HasComment("Encrypted bank account information for Tenant EFT payments.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.BankName).HasMaxLength(250);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(100)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FractionalRouting1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fractionalRouting1");
            entity.Property(e => e.FractionalRouting2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fractionalRouting2");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(100)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RoutingNumEncrypted).HasMaxLength(2048);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.AccountType).WithMany(p => p.TenantBankAccounts)
                .HasForeignKey(d => d.AccountTypeId)
                .HasConstraintName("FK__TenantBan__Accou__172E5549");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantBankAccounts)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TenantBan__Tenan__163A3110");
        });

        modelBuilder.Entity<TenantBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantBr__3213E83F98C26C06");

            entity.ToTable(tb => tb.HasComment("Branches for any tenant.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchAddress1).HasMaxLength(500);
            entity.Property(e => e.BranchAddress2).HasMaxLength(500);
            entity.Property(e => e.BranchCity).HasMaxLength(500);
            entity.Property(e => e.BranchIdent).HasMaxLength(500);
            entity.Property(e => e.BranchLegalName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchState).HasMaxLength(50);
            entity.Property(e => e.BranchZipCode).HasMaxLength(500);
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Ein)
                .HasMaxLength(20)
                .HasColumnName("EIN");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("geoCodeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsMasterBranch)
                .HasDefaultValue(false)
                .HasColumnName("isMasterBranch");
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.StartingCheckNumber).HasMaxLength(20);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Website).HasMaxLength(500);

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantBranches)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TenantBra__TSCli__18EBB532");
        });

        modelBuilder.Entity<TenantBranchesRoyaltyRate>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RateDiscount).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.RateDiscountEndDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountEndDT");
            entity.Property(e => e.RateDiscountStartDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountStartDT");
            entity.Property(e => e.TenantRateId).HasColumnName("TenantRateID");

            entity.HasOne(d => d.Branch).WithMany(p => p.TenantBranchesRoyaltyRates)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__TenantBra__Branc__32C22C7C");
        });

        modelBuilder.Entity<TenantConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantCo__3213E83F768CAA32");

            entity.ToTable("TenantConfig", tb => tb.HasComment("Configuration options for tenant site behavior -- Not implemented yet "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfigKey).HasMaxLength(100);
            entity.Property(e => e.ConfigValue).HasMaxLength(2000);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantConfigs)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TenantCon__Tenan__5FD33367");
        });

        modelBuilder.Entity<TenantJurisdiction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantJu__3213E83F06AC11ED");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.OrganizationId)
                .HasMaxLength(50)
                .HasColumnName("OrganizationID");
            entity.Property(e => e.SalesTaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SalesTaxID");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnemploymentTaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnemploymentTaxID");
            entity.Property(e => e.Wcmultiplier)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("WCMultiplier");
        });

        modelBuilder.Entity<TenantRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantRe__3213E83F901CB2B8");

            entity.ToTable(tb => tb.HasComment("The regions that a tenant is associated with.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.RegionName).HasMaxLength(500);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantRegions)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TenantReg__Tenan__4B422AD5");
        });

        modelBuilder.Entity<TenantRoyaltyRatesDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tenantRoyaltyRateDiscounts");

            entity.ToTable("TenantRoyaltyRatesDiscount");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.RateDiscount).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.RateDiscountEndDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountEndDT");
            entity.Property(e => e.RateDiscountStartDt)
                .HasColumnType("datetime")
                .HasColumnName("RateDiscountStartDT");
            entity.Property(e => e.TenantBaseRateId).HasColumnName("TenantBaseRateID");

            entity.HasOne(d => d.TenantBaseRate).WithMany(p => p.TenantRoyaltyRatesDiscounts)
                .HasForeignKey(d => d.TenantBaseRateId)
                .HasConstraintName("FK__TenantRoy__Tenan__428E7FF1");
        });

        modelBuilder.Entity<TenantWorkCompCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantWo__3213E83F7C564F80");

            entity.HasIndex(e => new { e.TenantId, e.Wccode, e.IsActive }, "ix_dbo_TenantWorkCompCodes_TenantID_WCCode_isActive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FootnoteId).HasColumnName("FootnoteID");
            entity.Property(e => e.HazardgroupId).HasColumnName("HazardgroupID");
            entity.Property(e => e.IndustryGroupId).HasColumnName("IndustryGroupID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LossCost).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Premium).HasColumnType("money");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.RateBeginDt).HasColumnName("RateBeginDT");
            entity.Property(e => e.RateEndDt).HasColumnName("RateEndDT");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Wccode)
                .HasMaxLength(50)
                .HasColumnName("WCCode");
        });

        modelBuilder.Entity<TenantWorkCompCodesBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TenantWorkCompCodesBAK");

            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FootnoteId).HasColumnName("FootnoteID");
            entity.Property(e => e.HazardgroupId).HasColumnName("HazardgroupID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IndustryGroupId).HasColumnName("IndustryGroupID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LossCost).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Premium).HasColumnType("money");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.RateBeginDt).HasColumnName("RateBeginDT");
            entity.Property(e => e.RateEndDt).HasColumnName("RateEndDT");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Wccode)
                .HasMaxLength(50)
                .HasColumnName("WCCode");
        });

        modelBuilder.Entity<TenantWorkCompCodesState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TenantWo__3213E83F08242367");

            entity.HasIndex(e => e.TenantWorkcompCodeId, "ix_dbo_TenantWorkCompCodesStates_TenantWorkcompCodeID");

            entity.HasIndex(e => new { e.TenantWorkcompCodeId, e.IsActive }, "ix_dbo_TenantWorkCompCodesStates_TenantWorkcompCodeID_isActive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StateId)
                .HasMaxLength(10)
                .HasColumnName("StateID");
            entity.Property(e => e.TenantWorkcompCodeId).HasColumnName("TenantWorkcompCodeID");
        });

        modelBuilder.Entity<TenantsRoyaltyRate>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("t_ManageFranchiseRates"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EffectiveEndDt)
                .HasColumnType("datetime")
                .HasColumnName("EffectiveEndDT");
            entity.Property(e => e.EffectiveStartDt)
                .HasColumnType("datetime")
                .HasColumnName("EffectiveStartDT");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ParentRateDynamic).HasComputedColumnSql("([dbo].[fn_GetParentRoyaltyRate]([TenantID]))", false);
            entity.Property(e => e.ParentRateLocked).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.Rate).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantsRoyaltyRates)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK__TenantsRo__Tenan__3CD5A69B");
        });

        modelBuilder.Entity<TenantworkcompcodesStatesBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tenantworkcompcodesStatesBAK");

            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.StateId)
                .HasMaxLength(10)
                .HasColumnName("StateID");
            entity.Property(e => e.TenantWorkcompCodeId).HasColumnName("TenantWorkcompCodeID");
        });

        modelBuilder.Entity<TestingFormSubmitsPto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestingFormSubmitsPTO");

            entity.Property(e => e.Assignment)
                .HasMaxLength(100)
                .HasColumnName("assignment");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .HasColumnName("endTime");
            entity.Property(e => e.PartialShift)
                .HasMaxLength(50)
                .HasColumnName("partialShift");
            entity.Property(e => e.PtoDate)
                .HasMaxLength(50)
                .HasColumnName("ptoDate");
            entity.Property(e => e.PtoType)
                .HasMaxLength(100)
                .HasColumnName("ptoType");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .HasColumnName("startTime");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_transactions_id");

            entity.ToTable("Transactions", "acc", tb => tb.HasComment("IN PROGRESS - "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDescrip).HasMaxLength(500);

            entity.HasOne(d => d.Branch).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__Transacti__Branc__414EAC47");

            entity.HasOne(d => d.TransactionStatusNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionStatus)
                .HasConstraintName("FK__Transacti__Trans__4242D080");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3213E83FEA22ABC8");

            entity.ToTable(tb => tb.HasComment("All User account information, encrypted. "));

            entity.HasIndex(e => e.Auth0UserKey, "ix_dbo_Users_Auth0UserKey");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ActivationDt)
                .HasColumnType("datetime")
                .HasColumnName("ActivationDT");
            entity.Property(e => e.Auth0UserKey).HasMaxLength(500);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDt)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDT");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.ProfileImgUrl)
                .HasMaxLength(1024)
                .HasColumnName("ProfileImgURL");
        });

        modelBuilder.Entity<UserAccountInvite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasComment("Unsatisfied invitations for users.  "));

            entity.Property(e => e.ExpiresDt)
                .HasColumnType("datetime")
                .HasColumnName("ExpiresDT");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Token).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserAccou__UserI__531856C7");
        });

        modelBuilder.Entity<UserNotificationPreference>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.UserId, "ix_dbo_UserNotificationPreferences_userID");

            entity.Property(e => e.DoEmail)
                .HasDefaultValue(true)
                .HasColumnName("doEmail");
            entity.Property(e => e.DoSms)
                .HasDefaultValue(true)
                .HasColumnName("doSMS");
            entity.Property(e => e.DoSystem)
                .HasDefaultValue(true)
                .HasColumnName("doSystem");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3213E83F444F4BA3");

            entity.ToTable(tb => tb.HasComment("Associates users with roles and tenants.  "));

            entity.HasIndex(e => new { e.UserId, e.TenantId, e.ApproleId, e.BranchId }, "userroles_uq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApproleId).HasColumnName("approle_id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TenantId).HasColumnName("Tenant_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("user_id");

            entity.HasOne(d => d.Approle).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.ApproleId)
                .HasConstraintName("FK_UserRoles_AppRoles");

            entity.HasOne(d => d.Tenant).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_UserRoles_Tenants");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRoles_Users");
        });

        modelBuilder.Entity<UserSignatureDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userSign__3213E83F10F8532C");

            entity.ToTable("userSignatureDef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.SignaturePath)
                .HasMaxLength(2048)
                .HasColumnName("signaturePath");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<UsersAccountInvite>(entity =>
        {
            entity.ToTable("UsersAccountInvite");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountInviteId)
                .HasMaxLength(500)
                .HasColumnName("AccountInviteID");
            entity.Property(e => e.InvitedUserId)
                .HasMaxLength(100)
                .HasColumnName("InvitedUserID");

            entity.HasOne(d => d.AccountInvite).WithMany(p => p.UsersAccountInvites)
                .HasForeignKey(d => d.AccountInviteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersAccountInvite_AccountInvite");
        });

        modelBuilder.Entity<VAllApplicationDefinitionConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllApplicationDefinitionConfigs");

            entity.Property(e => e.AppDefInstanceId).HasColumnName("AppDefInstanceID");
            entity.Property(e => e.AppDefInstanceStepId).HasColumnName("AppDefInstanceStepID");
            entity.Property(e => e.AppDefInstanceSubStepId).HasColumnName("AppDefInstanceSubStepID");
            entity.Property(e => e.ApprovedForUseByUserId)
                .HasMaxLength(50)
                .HasColumnName("ApprovedForUseByUserID");
            entity.Property(e => e.ApprovedForUseDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedForUseDTUTC");
            entity.Property(e => e.IsApprovedForUse).HasColumnName("isApprovedForUse");
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.SubStepName).HasMaxLength(100);
            entity.Property(e => e.TemplateDerivedFromTemplateId).HasColumnName("TemplateDerivedFromTemplateID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateName).HasMaxLength(200);
            entity.Property(e => e.TemplateStepId).HasColumnName("TemplateStepID");
            entity.Property(e => e.TemplateSupStepId).HasColumnName("TemplateSupStepID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UserType).HasMaxLength(50);
        });

        modelBuilder.Entity<VAllAssignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAllAssignments");

            entity.Property(e => e.AssignmentAddress1).HasMaxLength(500);
            entity.Property(e => e.AssignmentAddress2).HasMaxLength(500);
            entity.Property(e => e.AssignmentBillRateDouble).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateHealth).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateOt)
                .HasColumnType("money")
                .HasColumnName("AssignmentBillRateOT");
            entity.Property(e => e.AssignmentBillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateReg).HasColumnType("money");
            entity.Property(e => e.AssignmentBranchClientId).HasColumnName("AssignmentBranchClientID");
            entity.Property(e => e.AssignmentBranchId).HasColumnName("assignmentBranchID");
            entity.Property(e => e.AssignmentCity).HasMaxLength(500);
            entity.Property(e => e.AssignmentClientId).HasColumnName("AssignmentClientID");
            entity.Property(e => e.AssignmentClientName).HasMaxLength(500);
            entity.Property(e => e.AssignmentContactEmail).HasMaxLength(500);
            entity.Property(e => e.AssignmentContractNumber).HasMaxLength(50);
            entity.Property(e => e.AssignmentDepartmentName).HasMaxLength(100);
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentJobSiteId).HasColumnName("AssignmentJobSiteID");
            entity.Property(e => e.AssignmentJobSiteName).HasMaxLength(500);
            entity.Property(e => e.AssignmentJobTitle).HasMaxLength(100);
            entity.Property(e => e.AssignmentLimitDollars).HasColumnType("money");
            entity.Property(e => e.AssignmentLimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AssignmentName).HasMaxLength(518);
            entity.Property(e => e.AssignmentPayRateDouble).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateHealth).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateOt)
                .HasColumnType("money")
                .HasColumnName("AssignmentPayRateOT");
            entity.Property(e => e.AssignmentPayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateReg).HasColumnType("money");
            entity.Property(e => e.AssignmentPointofContactName).HasMaxLength(100);
            entity.Property(e => e.AssignmentPurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.AssignmentRatesEndDt).HasColumnName("AssignmentRatesEndDT");
            entity.Property(e => e.AssignmentRatesStartDt).HasColumnName("AssignmentRatesStartDT");
            entity.Property(e => e.AssignmentRecruiterId)
                .HasMaxLength(50)
                .HasColumnName("AssignmentRecruiterID");
            entity.Property(e => e.AssignmentSalespersonId)
                .HasMaxLength(50)
                .HasColumnName("AssignmentSalespersonID");
            entity.Property(e => e.AssignmentShiftScheduleId).HasColumnName("AssignmentShiftScheduleID");
            entity.Property(e => e.AssignmentStateName).HasMaxLength(500);
            entity.Property(e => e.AssignmentSupervisorName).HasMaxLength(100);
            entity.Property(e => e.AssignmentTerminationDt)
                .HasColumnType("datetime")
                .HasColumnName("AssignmentTerminationDT");
            entity.Property(e => e.AssignmentTerminationReasonId).HasColumnName("AssignmentTerminationReasonID");
            entity.Property(e => e.AssignmentTerminationReasonValue).HasMaxLength(500);
            entity.Property(e => e.AssignmentZipCode).HasMaxLength(500);
            entity.Property(e => e.Assignmentpayrateid).HasColumnName("assignmentpayrateid");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.ClientAcarate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ClientACARate");
            entity.Property(e => e.ClientDnr).HasColumnName("ClientDNR");
            entity.Property(e => e.DaysWorked)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DnrId).HasColumnName("dnrID");
            entity.Property(e => e.Dnrnote).HasColumnName("DNRNote");
            entity.Property(e => e.EmpAnnualWage).HasColumnType("money");
            entity.Property(e => e.EmpDtwage)
                .HasColumnType("money")
                .HasColumnName("EmpDTWage");
            entity.Property(e => e.EmpHrlyWage).HasColumnType("money");
            entity.Property(e => e.EmpOtwage)
                .HasColumnType("money")
                .HasColumnName("EmpOTWage");
            entity.Property(e => e.EmpWageEndDt).HasColumnType("datetime");
            entity.Property(e => e.EmpWageStartDt)
                .HasColumnType("datetime")
                .HasColumnName("EmpWageStartDT");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.JobOrderAddress1).HasMaxLength(500);
            entity.Property(e => e.JobOrderAddress2).HasMaxLength(500);
            entity.Property(e => e.JobOrderCity).HasMaxLength(500);
            entity.Property(e => e.JobOrderClientId).HasColumnName("JobOrderClientID");
            entity.Property(e => e.JobOrderClientName).HasMaxLength(500);
            entity.Property(e => e.JobOrderContactEmail).HasMaxLength(500);
            entity.Property(e => e.JobOrderContractNumber).HasMaxLength(50);
            entity.Property(e => e.JobOrderDepartmentName).HasMaxLength(100);
            entity.Property(e => e.JobOrderDnr).HasColumnName("JobOrderDNR");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobOrderJobSiteId).HasColumnName("JobOrderJobSiteID");
            entity.Property(e => e.JobOrderJobSiteName).HasMaxLength(500);
            entity.Property(e => e.JobOrderJobTitle).HasMaxLength(100);
            entity.Property(e => e.JobOrderLimitDollars).HasColumnType("money");
            entity.Property(e => e.JobOrderLimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.JobOrderPointofContactName).HasMaxLength(100);
            entity.Property(e => e.JobOrderPurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.JobOrderRecruiterId)
                .HasMaxLength(50)
                .HasColumnName("JobOrderRecruiterID");
            entity.Property(e => e.JobOrderSalespersonId)
                .HasMaxLength(50)
                .HasColumnName("JobOrderSalespersonID");
            entity.Property(e => e.JobOrderStateName).HasMaxLength(500);
            entity.Property(e => e.JobOrderSupervisorName).HasMaxLength(100);
            entity.Property(e => e.JobOrderZipCode).HasMaxLength(500);
            entity.Property(e => e.JobSiteDnr).HasColumnName("JobSiteDNR");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MiddleName).HasMaxLength(500);
            entity.Property(e => e.PreferredName).HasMaxLength(500);
            entity.Property(e => e.SiteAcarate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SiteACARate");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TalentStatus).HasMaxLength(200);
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
        });

        modelBuilder.Entity<VAllAssignments2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAllAssignments2");

            entity.Property(e => e.AssignmentAddress1).HasMaxLength(500);
            entity.Property(e => e.AssignmentAddress2).HasMaxLength(500);
            entity.Property(e => e.AssignmentBillRateDouble).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateHealth).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateOt)
                .HasColumnType("money")
                .HasColumnName("AssignmentBillRateOT");
            entity.Property(e => e.AssignmentBillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.AssignmentBillRateReg).HasColumnType("money");
            entity.Property(e => e.AssignmentBranchClientId).HasColumnName("AssignmentBranchClientID");
            entity.Property(e => e.AssignmentCity).HasMaxLength(500);
            entity.Property(e => e.AssignmentClientId).HasColumnName("AssignmentClientID");
            entity.Property(e => e.AssignmentClientName).HasMaxLength(500);
            entity.Property(e => e.AssignmentContactEmail).HasMaxLength(500);
            entity.Property(e => e.AssignmentContractNumber).HasMaxLength(50);
            entity.Property(e => e.AssignmentDepartmentName).HasMaxLength(100);
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentJobSiteId).HasColumnName("AssignmentJobSiteID");
            entity.Property(e => e.AssignmentJobSiteName).HasMaxLength(500);
            entity.Property(e => e.AssignmentJobTitle).HasMaxLength(100);
            entity.Property(e => e.AssignmentLimitDollars).HasColumnType("money");
            entity.Property(e => e.AssignmentLimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AssignmentName).HasMaxLength(518);
            entity.Property(e => e.AssignmentPayRateDouble).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateHealth).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateOt)
                .HasColumnType("money")
                .HasColumnName("AssignmentPayRateOT");
            entity.Property(e => e.AssignmentPayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.AssignmentPayRateReg).HasColumnType("money");
            entity.Property(e => e.AssignmentPointofContactName).HasMaxLength(100);
            entity.Property(e => e.AssignmentPurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.AssignmentRatesEndDt).HasColumnName("AssignmentRatesEndDT");
            entity.Property(e => e.AssignmentRatesStartDt).HasColumnName("AssignmentRatesStartDT");
            entity.Property(e => e.AssignmentRecruiterId)
                .HasMaxLength(50)
                .HasColumnName("AssignmentRecruiterID");
            entity.Property(e => e.AssignmentSalespersonId)
                .HasMaxLength(50)
                .HasColumnName("AssignmentSalespersonID");
            entity.Property(e => e.AssignmentShiftScheduleId).HasColumnName("AssignmentShiftScheduleID");
            entity.Property(e => e.AssignmentStateName).HasMaxLength(500);
            entity.Property(e => e.AssignmentSupervisorName).HasMaxLength(100);
            entity.Property(e => e.AssignmentTerminationDt)
                .HasColumnType("datetime")
                .HasColumnName("AssignmentTerminationDT");
            entity.Property(e => e.AssignmentZipCode).HasMaxLength(500);
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.DaysWorked)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpAnnualWage).HasColumnType("money");
            entity.Property(e => e.EmpDtwage)
                .HasColumnType("money")
                .HasColumnName("EmpDTWage");
            entity.Property(e => e.EmpHrlyWage).HasColumnType("money");
            entity.Property(e => e.EmpOtwage)
                .HasColumnType("money")
                .HasColumnName("EmpOTWage");
            entity.Property(e => e.EmpWageEndDt).HasColumnType("datetime");
            entity.Property(e => e.EmpWageStartDt)
                .HasColumnType("datetime")
                .HasColumnName("EmpWageStartDT");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.JobOrderContractNumber).HasMaxLength(50);
            entity.Property(e => e.JobOrderDepartmentName).HasMaxLength(100);
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobOrderJobTitle).HasMaxLength(100);
            entity.Property(e => e.JobOrderLimitDollars).HasColumnType("money");
            entity.Property(e => e.JobOrderLimitHours).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.JobOrderPointofContactName).HasMaxLength(100);
            entity.Property(e => e.JobOrderPurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.JobOrderRecruiterId)
                .HasMaxLength(50)
                .HasColumnName("JobOrderRecruiterID");
            entity.Property(e => e.JobOrderSalespersonId)
                .HasMaxLength(50)
                .HasColumnName("JobOrderSalespersonID");
            entity.Property(e => e.JobOrderSupervisorName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TalentStatus).HasMaxLength(200);
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
        });

        modelBuilder.Entity<VAllBranchEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllBranchEmployees");

            entity.Property(e => e.Address1).HasMaxLength(2048);
            entity.Property(e => e.City).HasMaxLength(2048);
            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmploymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmploymentTypeId).HasColumnName("EmploymentTypeID");
            entity.Property(e => e.EmploymentTypeName).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.Gender).HasMaxLength(500);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.IsAssignable).HasColumnName("isAssignable");
            entity.Property(e => e.Language).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.SendSmsupdates).HasColumnName("SendSMSUpdates");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("submittedStatus");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            entity.Property(e => e.TerminationReasonId).HasColumnName("TerminationReasonID");
            entity.Property(e => e.TerminationReasonValue).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<VAllInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllInvoices");

            entity.Property(e => e.Adjustment).HasColumnType("money");
            entity.Property(e => e.AmountPaidToDate).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.ContactAddress1).HasMaxLength(500);
            entity.Property(e => e.ContactAddress2).HasMaxLength(500);
            entity.Property(e => e.ContactCity).HasMaxLength(500);
            entity.Property(e => e.ContactEmail).HasMaxLength(500);
            entity.Property(e => e.ContactName).HasMaxLength(500);
            entity.Property(e => e.ContactPhone).HasMaxLength(500);
            entity.Property(e => e.ContactState).HasMaxLength(500);
            entity.Property(e => e.ContactTaxNumber).HasMaxLength(500);
            entity.Property(e => e.ContactZipCode).HasMaxLength(500);
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DoubleDue).HasColumnType("money");
            entity.Property(e => e.DoubleHrs).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FullClientIdent).HasMaxLength(31);
            entity.Property(e => e.GrossDue).HasColumnType("money");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(50);
            entity.Property(e => e.IsVoid).HasColumnName("isVoid");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.OrderNumber).HasMaxLength(100);
            entity.Property(e => e.Otdue)
                .HasColumnType("money")
                .HasColumnName("OTDue");
            entity.Property(e => e.Othrs)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OTHrs");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDue).HasColumnType("money");
            entity.Property(e => e.RegHrs).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
            entity.Property(e => e.Terms).HasMaxLength(500);
            entity.Property(e => e.TermsId).HasColumnName("TermsID");
            entity.Property(e => e.TotalDue).HasColumnType("money");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("money");
            entity.Property(e => e.VoidedDt)
                .HasColumnType("datetime")
                .HasColumnName("VoidedDT");
        });

        modelBuilder.Entity<VAllInvoicesAggregatedByClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllInvoicesAggregatedByClient");

            entity.Property(e => e.AmountPaidToDate).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DoubleDue).HasColumnType("money");
            entity.Property(e => e.FullClientIdent).HasMaxLength(31);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(50);
            entity.Property(e => e.Otdue)
                .HasColumnType("money")
                .HasColumnName("OTDue");
            entity.Property(e => e.RegDue).HasColumnType("money");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Terms).HasMaxLength(500);
            entity.Property(e => e.TermsId).HasColumnName("TermsID");
            entity.Property(e => e.TotalAdjustment).HasColumnType("money");
            entity.Property(e => e.TotalDue).HasColumnType("money");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VAllPayCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllPayChecks");

            entity.Property(e => e.AccountNumber).HasMaxLength(2048);
            entity.Property(e => e.BankCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.BranchEmployeeId).HasColumnName("branchEmployeeID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Dbcd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DBCD");
            entity.Property(e => e.DoNotPay).HasColumnName("doNotPay");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(1001)
                .HasColumnName("employeeName");
            entity.Property(e => e.EmployeeType).HasMaxLength(500);
            entity.Property(e => e.ExternalEmployeeId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ExternalEmployeeID");
            entity.Property(e => e.GrossPay)
                .HasColumnType("money")
                .HasColumnName("grossPay");
            entity.Property(e => e.IsAch).HasColumnName("isACH");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDraft).HasColumnName("isDraft");
            entity.Property(e => e.IsPaperCheck).HasColumnName("isPaperCheck");
            entity.Property(e => e.IsPayCard).HasColumnName("isPayCard");
            entity.Property(e => e.NetPay)
                .HasColumnType("money")
                .HasColumnName("netPay");
            entity.Property(e => e.OfficeCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ParentTenantId).HasColumnName("ParentTenantID");
            entity.Property(e => e.PayCheckId).HasColumnName("payCheckID");
            entity.Property(e => e.PayPeriodAchsubmitted).HasColumnName("PayPeriodACHSubmitted");
            entity.Property(e => e.PayPeriodApprovedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PayPeriodApprovedByUserID");
            entity.Property(e => e.PayPeriodApprovedDt)
                .HasColumnType("datetime")
                .HasColumnName("PayPeriodApprovedDT");
            entity.Property(e => e.PayPeriodInitiatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PayPeriodInitiatedByUserID");
            entity.Property(e => e.PayPeriodInitiatedDt)
                .HasColumnType("datetime")
                .HasColumnName("PayPeriodInitiatedDT");
            entity.Property(e => e.PayPeriodSubmittedByUserId)
                .HasMaxLength(50)
                .HasColumnName("PayPeriodSubmittedByUserID");
            entity.Property(e => e.PayPeriodSubmittedDt)
                .HasColumnType("datetime")
                .HasColumnName("PayPeriodSubmittedDT");
            entity.Property(e => e.PaychecksFinalizedDt).HasColumnName("PaychecksFinalizedDT");
            entity.Property(e => e.RoutingNumber).HasMaxLength(2048);
            entity.Property(e => e.Ssnmasked)
                .HasMaxLength(255)
                .HasColumnName("SSNMasked");
            entity.Property(e => e.TaxpayerIdEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("TaxpayerID_Encrypted");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TotalDeductions)
                .HasColumnType("money")
                .HasColumnName("totalDeductions");
            entity.Property(e => e.Void)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAllPayChecksPayOutput>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllPayChecksPayOutputs");

            entity.Property(e => e.AchpayToAccountNumberEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("ACHPayToAccountNumber_Encrypted");
            entity.Property(e => e.AchpayToRoutingNumberEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("ACHPayToRoutingNumber_Encrypted");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(1001);
            entity.Property(e => e.IsAch).HasColumnName("isACH");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsPaperCheck).HasColumnName("isPaperCheck");
            entity.Property(e => e.IsPayCard).HasColumnName("isPayCard");
            entity.Property(e => e.PayFromAccountEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("PayFromAccount_Encrypted");
            entity.Property(e => e.PayFromRoutingNumberEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("PayFromRoutingNumber_Encrypted");
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.SubmittedDt)
                .HasColumnType("datetime")
                .HasColumnName("SubmittedDT");
            entity.Property(e => e.TaxpayerIdEncrypted)
                .HasMaxLength(2048)
                .HasColumnName("TaxpayerID_Encrypted");
        });

        modelBuilder.Entity<VAllPayChecksPaysNormalized>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllPayChecksPaysNormalized");

            entity.Property(e => e.BillTotal)
                .HasColumnType("money")
                .HasColumnName("billTotal");
            entity.Property(e => e.BillableToBranchAssignmentId).HasColumnName("BillableToBranchAssignmentID");
            entity.Property(e => e.BillableToBranchClientId).HasColumnName("billableToBranchClientID");
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(500)
                .HasColumnName("clientName");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");
            entity.Property(e => e.PayCheckId).HasColumnName("payCheckID");
            entity.Property(e => e.PayCheckPaysId).HasColumnName("payCheckPaysID");
            entity.Property(e => e.PayType)
                .HasMaxLength(100)
                .HasColumnName("payType");
            entity.Property(e => e.PayTypeId).HasColumnName("payTypeID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UnitAmount).HasColumnType("money");
            entity.Property(e => e.W2box)
                .HasMaxLength(50)
                .HasColumnName("W2Box");
        });

        modelBuilder.Entity<VAllSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllSkills");

            entity.Property(e => e.SkillGroupId).HasColumnName("SkillGroupID");
            entity.Property(e => e.SkillGroupName).HasMaxLength(100);
            entity.Property(e => e.SkillGroupShortName).HasMaxLength(50);
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillIdent).HasMaxLength(10);
            entity.Property(e => e.SkillName).HasMaxLength(100);
            entity.Property(e => e.WctypeIdent)
                .HasMaxLength(10)
                .HasColumnName("WCTypeIdent");
            entity.Property(e => e.WorkersCompSkillTypeIdent).HasMaxLength(10);
        });

        modelBuilder.Entity<VAllSkillsWithSynonym>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllSkillsWithSynonyms");

            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillName).HasMaxLength(100);
            entity.Property(e => e.SynonymName).HasMaxLength(100);
        });

        modelBuilder.Entity<VAllTalentApplicationInstance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTalentApplicationInstances");

            entity.Property(e => e.AppDefInstanceStepId).HasColumnName("AppDefInstanceStepID");
            entity.Property(e => e.AppDefInstanceSubStepId).HasColumnName("AppDefInstanceSubStepID");
            entity.Property(e => e.ApplicationDefInstanceId).HasColumnName("ApplicationDefInstanceID");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.StepCompleteDt)
                .HasColumnType("datetime")
                .HasColumnName("StepCompleteDT");
            entity.Property(e => e.StepCompletedByUserId)
                .HasMaxLength(50)
                .HasColumnName("StepCompletedByUserID");
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.SubStepCompleteDt)
                .HasColumnType("datetime")
                .HasColumnName("SubStepCompleteDT");
            entity.Property(e => e.SubStepCompletedByUserId)
                .HasMaxLength(50)
                .HasColumnName("SubStepCompletedByUserID");
            entity.Property(e => e.SubStepName).HasMaxLength(100);
            entity.Property(e => e.TalentAppId).HasColumnName("TalentAppID");
            entity.Property(e => e.TalentAppStepId).HasColumnName("TalentAppStepID");
            entity.Property(e => e.TalentAppSubStepId).HasColumnName("TalentAppSubStepID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TalentJobOrderApplicationInstanceId).HasColumnName("TalentJobOrderApplicationInstanceID");
            entity.Property(e => e.TalentJobOrderApplicationInstanceStepId).HasColumnName("TalentJobOrderApplicationInstanceStepID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateName).HasMaxLength(200);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UserType).HasMaxLength(50);
        });

        modelBuilder.Entity<VAllTalentWithBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTalentWithBranches");

            entity.Property(e => e.Address1).HasMaxLength(2048);
            entity.Property(e => e.Address2).HasMaxLength(2048);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.City).HasMaxLength(2048);
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.EmailAddress2).HasMaxLength(200);
            entity.Property(e => e.EmergencyContactName).HasMaxLength(500);
            entity.Property(e => e.EmergencyContactPhone).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(50)
                .HasColumnName("geoCodeID");
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.PreferredName).HasMaxLength(500);
            entity.Property(e => e.SendSmsupdates).HasColumnName("SendSMSUpdates");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TaxpayerId)
                .HasMaxLength(2048)
                .HasColumnName("TaxpayerID");
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<VAllTalentWithEmployeeAndUserInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTalentWithEmployeeAndUserInfo");

            entity.Property(e => e.Auth0UserKey).HasMaxLength(500);
            entity.Property(e => e.BranchLegalName).HasMaxLength(100);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("emailAddress");
            entity.Property(e => e.EmployedByBranchId).HasColumnName("EmployedByBranchID");
            entity.Property(e => e.EmployedByTenantId).HasColumnName("EmployedByTenantID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");
            entity.Property(e => e.EmployeeTypeValue).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.IsEmployee).HasColumnName("isEmployee");
            entity.Property(e => e.IsUser).HasColumnName("isUser");
            entity.Property(e => e.IsUserAccountActive).HasColumnName("isUserAccountActive");
            entity.Property(e => e.LanguageValue).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.Token).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserStatus)
                .HasMaxLength(21)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAllTimeWorkedEntriesComputed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTimeWorkedEntriesComputed");

            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchEmployeeAssignmentId).HasColumnName("BranchEmployeeAssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.ClientJobSiteId).HasColumnName("ClientJobSiteID");
            entity.Property(e => e.DetailEndTime).HasColumnType("datetime");
            entity.Property(e => e.DetailStartTime).HasColumnType("datetime");
            entity.Property(e => e.EffectiveBillRate).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.EffectivePayRate).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.EffectivePayType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EffectivePayTypeId).HasColumnName("EffectivePayTypeID");
            entity.Property(e => e.EmployeeTimeCardId).HasColumnName("EmployeeTimeCardID");
            entity.Property(e => e.EmployeeTimeWorkedDetailsId).HasColumnName("EmployeeTimeWorkedDetailsID");
            entity.Property(e => e.EmployeeTimeWorkedShiftId).HasColumnName("EmployeeTimeWorkedShiftID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsBreak).HasColumnName("isBreak");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.WorkedHrs).HasColumnType("numeric(27, 14)");
        });

        modelBuilder.Entity<VAllTimeWorkedEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTimeWorkedEntries");

            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchEmployeeAssignmentId).HasColumnName("BranchEmployeeAssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.ClientJobSiteId).HasColumnName("ClientJobSiteID");
            entity.Property(e => e.DetailEndTime).HasColumnType("datetime");
            entity.Property(e => e.DetailStartTime).HasColumnType("datetime");
            entity.Property(e => e.EmployeeTimeCardId).HasColumnName("EmployeeTimeCardID");
            entity.Property(e => e.EmployeeTimeWorkedDetailsId).HasColumnName("EmployeeTimeWorkedDetailsID");
            entity.Property(e => e.EmployeeTimeWorkedShiftId).HasColumnName("EmployeeTimeWorkedShiftID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsBreak).HasColumnName("isBreak");
            entity.Property(e => e.IsDoubleRate).HasColumnName("isDoubleRate");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsOtrate).HasColumnName("isOTRate");
            entity.Property(e => e.IsRegRate).HasColumnName("isRegRate");
            entity.Property(e => e.PayPeriodId).HasColumnName("payPeriodID");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<VAllTimecardAggregateMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTimecardAggregateMaster");

            entity.Property(e => e.AssignmentBranchClientId).HasColumnName("AssignmentBranchClientID");
            entity.Property(e => e.AssignmentClientName).HasMaxLength(500);
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentJobSiteId).HasColumnName("AssignmentJobSiteID");
            entity.Property(e => e.AssignmentJobSiteName).HasMaxLength(500);
            entity.Property(e => e.AssignmentName).HasMaxLength(518);
            entity.Property(e => e.AssignmentShiftScheduleId).HasColumnName("AssignmentShiftScheduleID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.DataSource).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.GrossBill).HasColumnType("decimal(32, 6)");
            entity.Property(e => e.GrossPay).HasColumnType("decimal(32, 6)");
            entity.Property(e => e.HoursDt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursDT");
            entity.Property(e => e.HoursOt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursOT");
            entity.Property(e => e.HoursReg).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsAdhoc).HasColumnName("isAdhoc");
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsManual).HasColumnName("isManual");
            entity.Property(e => e.IsVerified).HasColumnName("isVerified");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.LockedDt)
                .HasColumnType("datetime")
                .HasColumnName("LockedDT");
            entity.Property(e => e.PayCheckId).HasColumnName("payCheckID");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.RateId).HasColumnName("RateID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TimeCardAggregateId).HasColumnName("TimeCardAggregateID");
            entity.Property(e => e.TimecardId).HasColumnName("TimecardID");
            entity.Property(e => e.VerifiedDt)
                .HasColumnType("datetime")
                .HasColumnName("verifiedDT");
        });

        modelBuilder.Entity<VAllTimecardAggregateMasterVertical>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTimecardAggregateMasterVertical");

            entity.Property(e => e.AssignmentBranchClientId).HasColumnName("AssignmentBranchClientID");
            entity.Property(e => e.AssignmentClientName).HasMaxLength(500);
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentJobSiteId).HasColumnName("AssignmentJobSiteID");
            entity.Property(e => e.AssignmentJobSiteName).HasMaxLength(500);
            entity.Property(e => e.AssignmentName).HasMaxLength(518);
            entity.Property(e => e.AssignmentShiftScheduleId).HasColumnName("AssignmentShiftScheduleID");
            entity.Property(e => e.BillRateDouble).HasColumnType("money");
            entity.Property(e => e.BillRateHealth).HasColumnType("money");
            entity.Property(e => e.BillRateOt)
                .HasColumnType("money")
                .HasColumnName("BillRateOT");
            entity.Property(e => e.BillRatePerDiem).HasColumnType("money");
            entity.Property(e => e.BillRateReg).HasColumnType("money");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.DataSource).HasMaxLength(50);
            entity.Property(e => e.EffectiveBillRate).HasColumnType("money");
            entity.Property(e => e.EffectivePayRate).HasColumnType("money");
            entity.Property(e => e.EffectivePayType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EffectivePayTypeId).HasColumnName("EffectivePayTypeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.GrossBill).HasColumnType("decimal(32, 6)");
            entity.Property(e => e.GrossPay).HasColumnType("decimal(32, 6)");
            entity.Property(e => e.HoursDt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursDT");
            entity.Property(e => e.HoursOt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("HoursOT");
            entity.Property(e => e.HoursReg).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsAdhoc).HasColumnName("isAdhoc");
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsManual).HasColumnName("isManual");
            entity.Property(e => e.IsVerified).HasColumnName("isVerified");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.LockedDt)
                .HasColumnType("datetime")
                .HasColumnName("LockedDT");
            entity.Property(e => e.PayCheckId).HasColumnName("payCheckID");
            entity.Property(e => e.PayRateDouble).HasColumnType("money");
            entity.Property(e => e.PayRateHealth).HasColumnType("money");
            entity.Property(e => e.PayRateOt)
                .HasColumnType("money")
                .HasColumnName("PayRateOT");
            entity.Property(e => e.PayRatePerDiem).HasColumnType("money");
            entity.Property(e => e.PayRateReg).HasColumnType("money");
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.RateId).HasColumnName("RateID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TimeCardAggregateId).HasColumnName("TimeCardAggregateID");
            entity.Property(e => e.TimecardId).HasColumnName("TimecardID");
            entity.Property(e => e.TotalBillable).HasColumnType("decimal(30, 6)");
            entity.Property(e => e.TotalPay).HasColumnType("decimal(30, 6)");
            entity.Property(e => e.VerifiedDt)
                .HasColumnType("datetime")
                .HasColumnName("verifiedDT");
            entity.Property(e => e.WorkedHrs).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<VAllTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllTransactions");

            entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchIdent).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.DebitAmount).HasColumnType("money");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.LedgerEntryId).HasColumnName("LedgerEntryID");
            entity.Property(e => e.ParentAccountCategoryId).HasColumnName("ParentAccountCategoryID");
            entity.Property(e => e.ParentAccountId).HasColumnName("ParentAccountID");
            entity.Property(e => e.ParentAccountName).HasMaxLength(100);
            entity.Property(e => e.ParentAccountNumber).HasMaxLength(50);
            entity.Property(e => e.ParentAccountTypeId).HasColumnName("ParentAccountTypeID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDescrip).HasMaxLength(500);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAllUserComponentClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllUserComponentClaims");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ComponentId).HasColumnName("ComponentID");
            entity.Property(e => e.ComponentKey).HasMaxLength(500);
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.IsSupported).HasColumnName("isSupported");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
        });

        modelBuilder.Entity<VAllUsersWithRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAllUsersWithRoles");

            entity.Property(e => e.Auth0UserKey).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("client_name");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("user_id");
            entity.Property(e => e.UseraccountIsActive).HasColumnName("useraccount_is_active");
            entity.Property(e => e.UserroleIsActive).HasColumnName("userrole_is_active");
        });

        modelBuilder.Entity<VAllUsersWithRolesFlat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllUsersWithRoles_Flat");

            entity.Property(e => e.Auth0UserKey).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("emailAddress");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
            entity.Property(e => e.Token).HasMaxLength(500);
            entity.Property(e => e.UserAccountIsActive).HasColumnName("userAccountIsActive");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("userID");
            entity.Property(e => e.UserStatus)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.UserroleIsActive).HasColumnName("userrole_is_active");
        });

        modelBuilder.Entity<VApplyJobOrderAppHeadersByAppDefId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ApplyJobOrderAppHeadersByAppDefID");

            entity.Property(e => e.Address1).HasMaxLength(2048);
            entity.Property(e => e.AppId).HasColumnName("appID");
            entity.Property(e => e.AppModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationDefInstanceId).HasColumnName("ApplicationDefInstanceID");
            entity.Property(e => e.BaseWage).HasColumnType("money");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.City).HasMaxLength(2048);
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.Employer).HasMaxLength(100);
            entity.Property(e => e.EmployingBranchId).HasColumnName("EmployingBranchID");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.IsDirectHire).HasColumnName("isDirectHire");
            entity.Property(e => e.JobOrderCreationDate).HasColumnType("datetime");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.JobranchId).HasColumnName("JOBranchID");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MiddleName).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.PreferredName).HasMaxLength(500);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(50)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalespersonId)
                .HasMaxLength(50)
                .HasColumnName("SalespersonID");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("StateID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TalentName).HasMaxLength(1001);
            entity.Property(e => e.TaxpayerId)
                .HasMaxLength(2048)
                .HasColumnName("TaxpayerID");
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<VBranchEmployeeWorkSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_BranchEmployeeWorkSchedules");

            entity.Property(e => e.AssignmentBranchClientId).HasColumnName("AssignmentBranchClientID");
            entity.Property(e => e.AssignmentClientName).HasMaxLength(500);
            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentName).HasMaxLength(518);
            entity.Property(e => e.AssignmentTerminationDt)
                .HasColumnType("datetime")
                .HasColumnName("AssignmentTerminationDT");
            entity.Property(e => e.AssignmentTerminationReasonId).HasColumnName("AssignmentTerminationReasonID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Duration).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EmployeeName).HasMaxLength(1001);
            entity.Property(e => e.EmploymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmploymentTerminationDate).HasColumnType("datetime");
            entity.Property(e => e.EmploymentTerminationReasonId).HasColumnName("EmploymentTerminationReasonID");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobOrderJobSiteId).HasColumnName("JobOrderJobSiteID");
            entity.Property(e => e.JobOrderJobSiteName).HasMaxLength(500);
            entity.Property(e => e.JobOrderJobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.ShiftDefId).HasColumnName("ShiftDefID");
            entity.Property(e => e.ShiftName).HasMaxLength(100);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<VBranchTimeOffConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_BranchTimeOffConfigs");

            entity.Property(e => e.AccrualFrequencyName).HasMaxLength(50);
            entity.Property(e => e.AccruePerHoursWorked).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchTimeOffTypeId).HasColumnName("BranchTimeOffTypeID");
            entity.Property(e => e.CapAccrualHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.HoursAccrued).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsUnlimited).HasColumnName("isUnlimited");
            entity.Property(e => e.MaxCarryoverHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.MaxNegativeCarryover).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PlanDescription).HasMaxLength(2000);
            entity.Property(e => e.PlanName).HasMaxLength(100);
            entity.Property(e => e.ProbationaryPeriodMonths).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TimeOffTypeName).HasMaxLength(100);
            entity.Property(e => e.ToplanId).HasColumnName("TOPlanID");
            entity.Property(e => e.ToplanIsActive).HasColumnName("TOPlanIsActive");
            entity.Property(e => e.TotypeId).HasColumnName("TOTypeID");
            entity.Property(e => e.TotypeIsActive).HasColumnName("TOTypeIsActive");
        });

        modelBuilder.Entity<VClientJobSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ClientJobSites");

            entity.Property(e => e.AcabillInsuredOnly).HasColumnName("ACABillInsuredOnly");
            entity.Property(e => e.AcainvoiceFormat).HasColumnName("ACAInvoiceFormat");
            entity.Property(e => e.AcasurchargeMethodId).HasColumnName("ACASurchargeMethodID");
            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.Address1).HasMaxLength(500);
            entity.Property(e => e.Address2).HasMaxLength(500);
            entity.Property(e => e.BillAddress1).HasMaxLength(500);
            entity.Property(e => e.BillAddress2).HasMaxLength(500);
            entity.Property(e => e.BillCity).HasMaxLength(100);
            entity.Property(e => e.BillDepartment).HasMaxLength(100);
            entity.Property(e => e.BillEmail).HasMaxLength(100);
            entity.Property(e => e.BillPerson).HasMaxLength(500);
            entity.Property(e => e.BillPhone).HasMaxLength(100);
            entity.Property(e => e.BillState).HasMaxLength(100);
            entity.Property(e => e.BillZip).HasMaxLength(20);
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.City).HasMaxLength(500);
            entity.Property(e => e.ClientJobSiteId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ClientJobSiteID");
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DiscountPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.GeoCodeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("geoCodeID");
            entity.Property(e => e.GeoLat).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.GeoLon).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsPrimary).HasColumnName("isPrimary");
            entity.Property(e => e.JobSiteContactEmail).HasMaxLength(500);
            entity.Property(e => e.JobSiteIdent).HasMaxLength(10);
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.ModifiedbyUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedbyUserID");
            entity.Property(e => e.PrimaryPhone).HasMaxLength(100);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(100)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalesTaxPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.StateName).HasMaxLength(500);
            entity.Property(e => e.Website).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(500);
        });

        modelBuilder.Entity<VClientJobSiteBillingInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ClientJobSiteBillingInfo");

            entity.Property(e => e.AcabillInsuredOnly).HasColumnName("ACABillInsuredOnly");
            entity.Property(e => e.AcainvoiceFormat).HasColumnName("ACAInvoiceFormat");
            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.Address1).HasMaxLength(500);
            entity.Property(e => e.Address2).HasMaxLength(500);
            entity.Property(e => e.BillAddress1).HasMaxLength(500);
            entity.Property(e => e.BillAddress2).HasMaxLength(500);
            entity.Property(e => e.BillCity).HasMaxLength(100);
            entity.Property(e => e.BillDepartment).HasMaxLength(100);
            entity.Property(e => e.BillEmail).HasMaxLength(100);
            entity.Property(e => e.BillPerson).HasMaxLength(500);
            entity.Property(e => e.BillPhone).HasMaxLength(100);
            entity.Property(e => e.BillState).HasMaxLength(100);
            entity.Property(e => e.BillZip).HasMaxLength(20);
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchDiscountPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BranchIdent).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchSalesTax).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.City).HasMaxLength(500);
            entity.Property(e => e.ClientJobSiteId).HasColumnName("ClientJobSiteID");
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.EmailAddress).HasMaxLength(200);
            entity.Property(e => e.GeoLat).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.GeoLon).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.InvoiceTermsValue).HasMaxLength(500);
            entity.Property(e => e.JobSiteContactEmail).HasMaxLength(500);
            entity.Property(e => e.JobSiteIdent).HasMaxLength(10);
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(100);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(100)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SiteDiscountPct).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SiteSalesTaxPct).HasColumnType("decimal(13, 5)");
            entity.Property(e => e.StateName).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(500);
        });

        modelBuilder.Entity<VCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vCustomers", "acc");

            entity.Property(e => e.BranchEin)
                .HasMaxLength(20)
                .HasColumnName("BranchEIN");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchIdent).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.IsClientRelationshipActive).HasColumnName("isClientRelationshipActive");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
        });

        modelBuilder.Entity<VDirectHireJobOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DirectHireJobOrders");

            entity.Property(e => e.BillAddress1).HasMaxLength(500);
            entity.Property(e => e.BillAddress2).HasMaxLength(500);
            entity.Property(e => e.BillCity).HasMaxLength(100);
            entity.Property(e => e.BillDepartment).HasMaxLength(100);
            entity.Property(e => e.BillEmail).HasMaxLength(100);
            entity.Property(e => e.BillPerson).HasMaxLength(500);
            entity.Property(e => e.BillPhone).HasMaxLength(100);
            entity.Property(e => e.BillState).HasMaxLength(100);
            entity.Property(e => e.BillZip).HasMaxLength(20);
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(500)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DirectHirePositionName).HasMaxLength(200);
            entity.Property(e => e.FlatFeeAmount).HasColumnType("money");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobSiteIdent).HasMaxLength(10);
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(500)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.PercentageAmount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PointofContactName).HasMaxLength(100);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.RecruiterId)
                .HasMaxLength(50)
                .HasColumnName("RecruiterID");
            entity.Property(e => e.SalespersonId)
                .HasMaxLength(50)
                .HasColumnName("SalespersonID");
            entity.Property(e => e.SupervisorName).HasMaxLength(100);
            entity.Property(e => e.WageAmountPerPeriod).HasColumnType("money");
        });

        modelBuilder.Entity<VInvoiceStagedItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_InvoiceStagedItems");

            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.BillRate).HasColumnType("money");
            entity.Property(e => e.BillToBranchClientId).HasColumnName("BillToBranchClientID");
            entity.Property(e => e.BillToEmployeeAssignmentId).HasColumnName("BillToEmployeeAssignmentID");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.Descrip).HasMaxLength(500);
            entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmployeeFirstName).HasMaxLength(500);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeLastName).HasMaxLength(500);
            entity.Property(e => e.InvoiceCreated).HasColumnName("invoiceCreated");
            entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsSubmitted).HasColumnName("isSubmitted");
            entity.Property(e => e.ItemId).HasColumnName("itemID");
            entity.Property(e => e.ItemTotalBilled).HasColumnType("money");
            entity.Property(e => e.ItemTotalPaid).HasColumnType("money");
            entity.Property(e => e.ItemTypeId).HasColumnName("itemTypeID");
            entity.Property(e => e.ItemTypeName).HasMaxLength(500);
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PayRate).HasColumnType("money");
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SalesTaxPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.ShiftDefinitionId).HasColumnName("ShiftDefinitionID");
            entity.Property(e => e.ShiftName).HasMaxLength(500);
            entity.Property(e => e.TimeCardId).HasColumnName("TimeCardID");
        });

        modelBuilder.Entity<VInvoiceStagedItemsAggregated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_InvoiceStagedItemsAggregated");

            entity.Property(e => e.AcasurchargeRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ACASurchargeRate");
            entity.Property(e => e.AcasurchargeTotal)
                .HasColumnType("decimal(30, 6)")
                .HasColumnName("ACASurchargeTotal");
            entity.Property(e => e.BillRate).HasColumnType("money");
            entity.Property(e => e.BillToEmployeeAssignmentId).HasColumnName("BillToEmployeeAssignmentID");
            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.Descrip).HasMaxLength(500);
            entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(30, 6)");
            entity.Property(e => e.EmployeeFirstName).HasMaxLength(500);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeLastName).HasMaxLength(500);
            entity.Property(e => e.InvoiceCreated).HasColumnName("invoiceCreated");
            entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsSubmitted).HasColumnName("isSubmitted");
            entity.Property(e => e.ItemId).HasColumnName("itemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ItemTypeName).HasMaxLength(500);
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobSiteId).HasColumnName("JobSiteID");
            entity.Property(e => e.JobSiteName).HasMaxLength(500);
            entity.Property(e => e.NetTotal).HasColumnType("decimal(35, 9)");
            entity.Property(e => e.PayCheckId).HasColumnName("PayCheckID");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.PayRate).HasColumnType("money");
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SalesTaxAmt).HasColumnType("decimal(30, 9)");
            entity.Property(e => e.SalesTaxPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.ShiftDefinitionId).HasColumnName("ShiftDefinitionID");
            entity.Property(e => e.ShiftName).HasMaxLength(500);
            entity.Property(e => e.SubtotalBillable).HasColumnType("money");
            entity.Property(e => e.TimeCardId).HasColumnName("TimeCardID");
            entity.Property(e => e.TotalPayable).HasColumnType("money");
        });

        modelBuilder.Entity<VJobOrderShiftSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_JobOrderShiftSchedules");

            entity.Property(e => e.BaseBillable).HasColumnType("money");
            entity.Property(e => e.BaseWage).HasColumnType("money");
            entity.Property(e => e.BillAdjustmentAmount).HasColumnType("money");
            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.BranchJobOrderShiftId).HasColumnName("branchJobOrderShiftID");
            entity.Property(e => e.DaysWorked)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DtbillAdjustmentAmount)
                .HasColumnType("money")
                .HasColumnName("DTBillAdjustmentAmount");
            entity.Property(e => e.Dtbillable)
                .HasColumnType("money")
                .HasColumnName("DTBillable");
            entity.Property(e => e.EffectiveBaseBillable).HasColumnType("money");
            entity.Property(e => e.EffectiveDtbillable)
                .HasColumnType("money")
                .HasColumnName("EffectiveDTBillable");
            entity.Property(e => e.EffectiveMargin).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EffectiveOtbillable)
                .HasColumnType("money")
                .HasColumnName("EffectiveOTBillable");
            entity.Property(e => e.EffectiveWage).HasColumnType("money");
            entity.Property(e => e.IsInternalClient).HasColumnName("isInternalClient");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JoisActive).HasColumnName("JOIsActive");
            entity.Property(e => e.OtbillAdjustmentAmount)
                .HasColumnType("money")
                .HasColumnName("OTBillAdjustmentAmount");
            entity.Property(e => e.Otbillable)
                .HasColumnType("money")
                .HasColumnName("OTBillable");
            entity.Property(e => e.QtyFilled).HasColumnName("qtyFilled");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.ShiftDefId).HasColumnName("ShiftDefID");
            entity.Property(e => e.ShiftDurationHrs).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftName).HasMaxLength(100);
            entity.Property(e => e.ShiftSupervisorContactId).HasColumnName("ShiftSupervisorContactID");
            entity.Property(e => e.SupervisorFirstName).HasMaxLength(200);
            entity.Property(e => e.SupervisorLastName).HasMaxLength(200);
            entity.Property(e => e.TenantId).HasColumnName("tenantID");
            entity.Property(e => e.WageAdjustmentAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VParentPayrollAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ParentPayrollAggregate");

            entity.Property(e => e.ApprovedDt)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedDT");
            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.CntAllPayments).HasColumnName("cntAllPayments");
            entity.Property(e => e.CntLargePaychecks).HasColumnName("cntLargePaychecks");
            entity.Property(e => e.CntPaperChecks).HasColumnName("cntPaperChecks");
            entity.Property(e => e.GrossPay).HasColumnType("money");
            entity.Property(e => e.HasPaperChecks).HasColumnName("hasPaperChecks");
            entity.Property(e => e.InvoiceCreated).HasColumnName("invoiceCreated");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsInitiated).HasColumnName("isInitiated");
            entity.Property(e => e.IsSubmitted).HasColumnName("isSubmitted");
            entity.Property(e => e.ParentTenantId).HasColumnName("ParentTenantID");
            entity.Property(e => e.ParentTenantName).HasMaxLength(255);
            entity.Property(e => e.PayPeriodStatus)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.PeriodType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedDt)
                .HasColumnType("datetime")
                .HasColumnName("SubmittedDT");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
            entity.Property(e => e.TotalHours).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VParentPayrollAggregateByPayMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ParentPayrollAggregateByPayMethod");

            entity.Property(e => e.AmtAch)
                .HasColumnType("money")
                .HasColumnName("AmtACH");
            entity.Property(e => e.AmtPaperChecks).HasColumnType("money");
            entity.Property(e => e.AmtPayCards).HasColumnType("money");
            entity.Property(e => e.ApprovedDt)
                .HasColumnType("datetime")
                .HasColumnName("ApprovedDT");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchPayPeriodId).HasColumnName("BranchPayPeriodID");
            entity.Property(e => e.CntAch).HasColumnName("cntACH");
            entity.Property(e => e.CntLargeAch).HasColumnName("cntLargeACH");
            entity.Property(e => e.CntLargeChecks).HasColumnName("cntLargeChecks");
            entity.Property(e => e.CntLargePayCards).HasColumnName("cntLargePayCards");
            entity.Property(e => e.CntPaperChecks).HasColumnName("cntPaperChecks");
            entity.Property(e => e.CntPayCards).HasColumnName("cntPayCards");
            entity.Property(e => e.ParentTenantId).HasColumnName("ParentTenantID");
            entity.Property(e => e.ParentTenantName).HasMaxLength(255);
            entity.Property(e => e.PayPeriodStatus)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEndDt).HasColumnName("PeriodEndDT");
            entity.Property(e => e.PeriodStartDt).HasColumnName("PeriodStartDT");
            entity.Property(e => e.PeriodType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedDt)
                .HasColumnType("datetime")
                .HasColumnName("SubmittedDT");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
        });

        modelBuilder.Entity<VPayflowPayAmountsVsBillAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PayflowPayAmountsVsBillAmounts");

            entity.Property(e => e.BillAmt).HasColumnType("money");
            entity.Property(e => e.BranchClientIdHidden).HasColumnName("branchClientID.hidden");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.Deductions).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(30, 6)");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Ertaxes)
                .HasColumnType("money")
                .HasColumnName("ERTaxes");
            entity.Property(e => e.GrossPay).HasColumnType("money");
            entity.Property(e => e.Hours).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.InvoiceCreated).HasColumnName("invoiceCreated");
            entity.Property(e => e.NetPay).HasColumnType("money");
            entity.Property(e => e.PayPeriodId).HasColumnName("payPeriodID");
            entity.Property(e => e.PaycheckId).HasColumnName("paycheckID");
            entity.Property(e => e.Profit).HasColumnType("money");
            entity.Property(e => e.TalentName).HasMaxLength(1001);
            entity.Property(e => e.Taxes).HasColumnType("money");
        });

        modelBuilder.Entity<VSearchBranchClientsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchBranchClientsAll");

            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchClientNameRev).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.SalesPersonName).HasMaxLength(1001);
        });

        modelBuilder.Entity<VSearchableBranchPayroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableBranchPayroll");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchNameRev).HasMaxLength(500);
            entity.Property(e => e.Mmyyyy)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MMYYYY");
            entity.Property(e => e.PayPeriodId).HasColumnName("PayPeriodID");
            entity.Property(e => e.Style101)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style112)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style120)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TheMonthName)
                .HasMaxLength(30)
                .HasColumnName("theMonthName");
            entity.Property(e => e.TheYear)
                .HasMaxLength(4)
                .HasColumnName("theYear");
        });

        modelBuilder.Entity<VSearchableInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableInvoices");

            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchClientNameRev).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchNameRev).HasMaxLength(500);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(50);
            entity.Property(e => e.Mmyyyy)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MMYYYY");
            entity.Property(e => e.Style101)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style112)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style120)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TheMonthName)
                .HasMaxLength(30)
                .HasColumnName("theMonthName");
            entity.Property(e => e.TheYear)
                .HasMaxLength(4)
                .HasColumnName("theYear");
        });

        modelBuilder.Entity<VSearchableJobOrdersAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableJobOrdersAll");

            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchClientIdent).HasMaxLength(20);
            entity.Property(e => e.BranchClientName).HasMaxLength(500);
            entity.Property(e => e.BranchClientNameRev).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JobOrderId).HasColumnName("JobOrderID");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.JobTitleRev).HasMaxLength(100);
        });

        modelBuilder.Entity<VSearchableTalent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableTalent");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.EmailRev).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.FirstnameRev).HasMaxLength(500);
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.LastNameRev).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.TalentBranchId).HasColumnName("TalentBranchID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<VSearchableTalentDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableTalentDocs");

            entity.Property(e => e.DocDescription).HasMaxLength(2048);
            entity.Property(e => e.DocFriendlyName).HasMaxLength(100);
            entity.Property(e => e.DocType).HasMaxLength(500);
            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.DocumentDescrip).HasMaxLength(500);
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DocumentIdent).HasMaxLength(2056);
            entity.Property(e => e.TalentDocId).HasColumnName("TalentDocID");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
        });

        modelBuilder.Entity<VSearchableTalentSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableTalentSkills");

            entity.Property(e => e.EmailAddress1).HasMaxLength(200);
            entity.Property(e => e.EmailRev).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.FirstnameRev).HasMaxLength(500);
            entity.Property(e => e.HomePhone).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.LastNameRev).HasMaxLength(500);
            entity.Property(e => e.MobilePhone).HasMaxLength(100);
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillName).HasMaxLength(100);
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TalentSkillId).HasColumnName("TalentSkillID");
        });

        modelBuilder.Entity<VSearchableTenant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SearchableTenants");

            entity.Property(e => e.BranchCity).HasMaxLength(500);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchZipCode).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
        });

        modelBuilder.Entity<VTalentProfileVerifyDefaultConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TalentProfileVerifyDefaultConfig");

            entity.Property(e => e.SectionDefId).HasColumnName("SectionDefID");
            entity.Property(e => e.SectionDisplayName).HasMaxLength(100);
            entity.Property(e => e.SectionIdentifier).HasMaxLength(50);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<VTenantBranchOrganization>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TenantBranchOrganizations");

            entity.Property(e => e.AchcompanyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACHCompanyID");
            entity.Property(e => e.BranchAddress1).HasMaxLength(500);
            entity.Property(e => e.BranchAddress2).HasMaxLength(500);
            entity.Property(e => e.BranchCity).HasMaxLength(500);
            entity.Property(e => e.BranchEmail).HasMaxLength(500);
            entity.Property(e => e.BranchGeoCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchIdent).HasMaxLength(500);
            entity.Property(e => e.BranchIdentPrefix).HasMaxLength(20);
            entity.Property(e => e.BranchLegalName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(500);
            entity.Property(e => e.BranchPhone).HasMaxLength(500);
            entity.Property(e => e.BranchState).HasMaxLength(50);
            entity.Property(e => e.BranchWebsite).HasMaxLength(500);
            entity.Property(e => e.BranchZipCode).HasMaxLength(500);
            entity.Property(e => e.FullBranchIdent).HasMaxLength(520);
            entity.Property(e => e.IsMasterBranch).HasColumnName("isMasterBranch");
            entity.Property(e => e.MasterBranchId).HasColumnName("MasterBranchID");
            entity.Property(e => e.ParentTenantEin)
                .HasMaxLength(50)
                .HasColumnName("ParentTenantEIN");
            entity.Property(e => e.ParentTenantId).HasColumnName("ParentTenantID");
            entity.Property(e => e.ParentTenantName).HasMaxLength(255);
            entity.Property(e => e.ParentTenantRegionId).HasColumnName("ParentTenantRegionID");
            entity.Property(e => e.TenantEin)
                .HasMaxLength(50)
                .HasColumnName("TenantEIN");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantName).HasMaxLength(255);
            entity.Property(e => e.TenantRegionId).HasColumnName("TenantRegionID");
        });

        modelBuilder.Entity<VTenantWccall>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TenantWCCAll");

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantWorkCompCodeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TenantWorkCompCodeID");
            entity.Property(e => e.Wccode)
                .HasMaxLength(50)
                .HasColumnName("WCCode");
            entity.Property(e => e.WccodeRev)
                .HasMaxLength(50)
                .HasColumnName("WCCodeRev");
        });

        modelBuilder.Entity<VTimeCardsDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TimeCardsDaily");

            entity.Property(e => e.BranchClientId).HasColumnName("BranchClientID");
            entity.Property(e => e.BranchEmployeeAssignmentId).HasColumnName("BranchEmployeeAssignmentID");
            entity.Property(e => e.BranchEmployeeId).HasColumnName("BranchEmployeeID");
            entity.Property(e => e.ClientJobSiteId).HasColumnName("ClientJobSiteID");
            entity.Property(e => e.DetailsId).HasColumnName("detailsID");
            entity.Property(e => e.EffectiveBillRate).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.EffectivePayRate).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.EffectivePayType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EffectivePayTypeId).HasColumnName("EffectivePayTypeID");
            entity.Property(e => e.EmployeeTimeCardId).HasColumnName("EmployeeTimeCardID");
            entity.Property(e => e.EmployeeTimeWorkedShiftId).HasColumnName("EmployeeTimeWorkedShiftID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.TalentId).HasColumnName("TalentID");
            entity.Property(e => e.TenantBranchId).HasColumnName("TenantBranchID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TotalBillable).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalPay).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.WorkedHrs).HasColumnType("numeric(38, 14)");
        });

        modelBuilder.Entity<VWorkCompCodesParentTenant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_WorkCompCodesParentTenants");

            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(50)
                .HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("CreatedDTUTC");
            entity.Property(e => e.FootnoteId).HasColumnName("FootnoteID");
            entity.Property(e => e.HazardgroupId).HasColumnName("HazardgroupID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IndustryGroupId).HasColumnName("IndustryGroupID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LossCost).HasColumnType("money");
            entity.Property(e => e.ModifiedByUserId)
                .HasMaxLength(50)
                .HasColumnName("ModifiedByUserID");
            entity.Property(e => e.ModifiedDtutc)
                .HasColumnType("datetime")
                .HasColumnName("ModifiedDTUTC");
            entity.Property(e => e.Premium).HasColumnType("money");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.RateBeginDt).HasColumnName("RateBeginDT");
            entity.Property(e => e.RateEndDt).HasColumnName("RateEndDT");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Wccode)
                .HasMaxLength(50)
                .HasColumnName("WCCode");
        });

        modelBuilder.Entity<VertexForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vertex_forms");

            entity.Property(e => e.FormDocumentation)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("formDocumentation");
            entity.Property(e => e.FormFieldDescriptiveName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("formFieldDescriptiveName");
            entity.Property(e => e.FormFieldIdentifier)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("formFieldIdentifier");
            entity.Property(e => e.GeocodeId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("geocodeId");
            entity.Property(e => e.ParentFormId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("parentFormId");
            entity.Property(e => e.ReciprocalJurisdictionGeoCodeId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reciprocalJurisdictionGeoCodeId");
            entity.Property(e => e.SchoolDistrictId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("schoolDistrictId");
            entity.Property(e => e.StartDate)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("startDate");
            entity.Property(e => e.StopDate)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("stopDate");
            entity.Property(e => e.TaxIdentifierId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("taxIdentifierId");
            entity.Property(e => e.TaxName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("taxName");
        });

        modelBuilder.Entity<VtAcainvoiceFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_ACASu__3213E83Fj7BA47A40");

            entity.ToTable("vt_ACAInvoiceFormat", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAcasurchargeMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_ACASu__3213E83F7BA47A40");

            entity.ToTable("vt_ACASurchargeMethod", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAcceptedDeclinedOffer>(entity =>
        {
            entity.ToTable("vt_AcceptedDeclinedOffer", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAccountCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Accou__3213E83FE4A3068F");

            entity.ToTable("vt_AccountCategory", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAccountClassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Accou__3213E83F28A06944");

            entity.ToTable("vt_AccountClassification", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAccountNormalBalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Accou__3213E83FAB8BF311");

            entity.ToTable("vt_AccountNormalBalance", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAccountReportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Accou__3213E83F4C4C2A28");

            entity.ToTable("vt_AccountReportType", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AccountT__3213E83FDA38E141");

            entity.ToTable("vt_AccountTypes", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountType).HasMaxLength(50);
        });

        modelBuilder.Entity<VtActiveInactive>(entity =>
        {
            entity.ToTable("vt_ActiveInactive", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtApprovalStatus>(entity =>
        {
            entity.ToTable("vt_ApprovalStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtAssignmentTerminationReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Assig__3213E83FE3786EA0");

            entity.ToTable("vt_AssignmentTerminationReason", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtBankAccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_BankA__3213E83F75F6A092");

            entity.ToTable("vt_BankAccountTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(50)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtCheckVoidReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Check__3213E83F11BB5C6C");

            entity.ToTable("vt_CheckVoidReason", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtClientDeactivationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Clien__3213E83F145AB9AD");

            entity.ToTable("vt_ClientDeactivationType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtClientOppValue>(entity =>
        {
            entity.ToTable("vt_ClientOppValue", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Dates__3213E83F3730F6B0");

            entity.ToTable("vt_Dates", tb => tb.HasComment("variable table - lookup -- all dimensional data regarding a date "));

            entity.HasIndex(e => e.TheDate, "ix_dbo_vt_Dates_TheDate");

            entity.HasIndex(e => e.TheDate, "ix_dbo_vt_Dates_TheDate2");

            entity.HasIndex(e => e.TheDate, "ix_dbo_vt_Dates_TheDate3");

            entity.HasIndex(e => new { e.TheDayName, e.TheDate }, "ix_dbo_vt_Dates_TheDayName_TheDate");

            entity.HasIndex(e => new { e.TheWeek, e.TheYear }, "ix_dbo_vt_Dates_TheWeek_TheYear");

            entity.HasIndex(e => new { e.TheYear, e.TheDayName }, "ix_dbo_vt_Dates_TheYear_TheDayName");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Has53Isoweeks).HasColumnName("Has53ISOWeeks");
            entity.Property(e => e.Mmyyyy)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MMYYYY");
            entity.Property(e => e.QuarterName).HasMaxLength(10);
            entity.Property(e => e.Style101)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style103)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style112)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Style120)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TheDayName).HasMaxLength(30);
            entity.Property(e => e.TheDaySuffix)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TheIsoweek).HasColumnName("TheISOweek");
            entity.Property(e => e.TheIsoyear).HasColumnName("TheISOYear");
            entity.Property(e => e.TheMonthName).HasMaxLength(30);
        });

        modelBuilder.Entity<VtDirectHireBillingMethod>(entity =>
        {
            entity.ToTable("vt_DirectHireBillingMethods", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDocumentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Docum__3213E83F0D558F4B");

            entity.ToTable("vt_DocumentTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.OnlyAllowOneActive).HasColumnName("onlyAllowOneActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDocumentTypeTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Docum__3213E83F0AECF889");

            entity.ToTable("vt_DocumentTypeTemplates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocUrl)
                .HasMaxLength(1024)
                .HasColumnName("DocURL");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.EffectiveUseBeginDt).HasColumnName("EffectiveUseBeginDT");
            entity.Property(e => e.EffectiveUseEndDt).HasColumnName("EffectiveUseEndDT");
            entity.Property(e => e.TemplateKey).HasMaxLength(500);

            entity.HasOne(d => d.DocumentType).WithMany(p => p.VtDocumentTypeTemplates)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("FK__vt_Docume__Docum__78EA90A2");
        });

        modelBuilder.Entity<VtDrugScreenProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_DrugS__3213E83FB9BE658A");

            entity.ToTable("vt_DrugScreenProvider");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDrugScreenReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_DrugS__3213E83F6BD17E4D");

            entity.ToTable("vt_DrugScreenReasons");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDrugScreenResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_DrugS__3213E83FBAF35699");

            entity.ToTable("vt_DrugScreenResult");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtDrugScreenSpecimenType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_DrugS__3213E83F0E0569A3");

            entity.ToTable("vt_DrugScreenSpecimenTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtEduInstitutionType>(entity =>
        {
            entity.ToTable("vt_EduInstitutionTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtEmployeeTerminationReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Emplo__3213E83FAE6CB64C");

            entity.ToTable("vt_EmployeeTerminationReason", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtEmploymentType>(entity =>
        {
            entity.ToTable("vt_EmploymentType", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtGender>(entity =>
        {
            entity.ToTable("vt_gender", tb =>
                {
                    tb.HasComment("variable table - lookup  ");
                    tb.HasTrigger("TR_Audit_Log_vt_gender");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtInterviewLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Inter__3213E83F08D13E5D");

            entity.ToTable("vt_InterviewLocations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtInviteType>(entity =>
        {
            entity.ToTable("vt_InviteType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtInvoiceDeliveryFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Invoi__3213E83F880B089C");

            entity.ToTable("vt_InvoiceDeliveryFormat", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtInvoiceTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Invoi__3213E83F7D20344C");

            entity.ToTable("vt_InvoiceTerms", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtInvoiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Invoi__3213E83FB613CEFB");

            entity.ToTable("vt_InvoiceType", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DescripNote).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtJobOrderApplicationStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_JobOr__3213E83F1FAC8D54");

            entity.ToTable("vt_JobOrderApplicationSteps", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtJobOrderApplicationSubStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_JobOr__3213E83FA9BAD859");

            entity.ToTable("vt_JobOrderApplicationSubSteps", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationStepId).HasColumnName("ApplicationStepID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.UserType).HasMaxLength(100);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtJobOrderCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_JobOr__3213E83FBB6A88A1");

            entity.ToTable("vt_JobOrderCategory", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtJobOrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_JobOr__3213E83FE56C15F5");

            entity.ToTable("vt_JobOrderStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtJobOrderType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_JobOr__3213E83F6E5DCDA8");

            entity.ToTable("vt_JobOrderType", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtLanguage>(entity =>
        {
            entity.ToTable("vt_language", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtNum1to5>(entity =>
        {
            entity.ToTable("vt_Num1to5", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtOptInOut>(entity =>
        {
            entity.ToTable("vt_OptInOut", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayCyclePeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_PayCy__3213E83FEEE50914");

            entity.ToTable("vt_PayCyclePeriods", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(50)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayMethod>(entity =>
        {
            entity.ToTable("vt_PayMethods", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayTypeAccountCrosswalk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_vt_PayTypeAccountCrosswalk__3213E83FB613CEFB");

            entity.ToTable("vt_PayTypeAccountCrosswalk", "acc", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.PaytypeId).HasColumnName("PaytypeID");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPaycheckAllocationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Paych__3213E83FDB4744B1");

            entity.ToTable("vt_PaycheckAllocationTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(50)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayrollDeductionGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83F9746E384");

            entity.ToTable("vt_PayrollDeductionGroups", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayrollDeductionMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83FE88CDDAF");

            entity.ToTable("vt_PayrollDeductionMethods", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayrollDeductionPayer>(entity =>
        {
            entity.ToTable("vt_PayrollDeductionPayers", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPayrollDeductionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83FF71371E2");

            entity.ToTable("vt_PayrollDeductionTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeductionMethodId).HasColumnName("DeductionMethodID");
            entity.Property(e => e.DefaultLimit).HasColumnType("money");
            entity.Property(e => e.DefaultPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsNondiscretionary).HasColumnName("isNondiscretionary");
            entity.Property(e => e.IsPreTax).HasColumnName("isPreTax");
            entity.Property(e => e.IsPretaxFederal).HasColumnName("isPretaxFederal");
            entity.Property(e => e.IsPretaxFica).HasColumnName("isPretaxFICA");
            entity.Property(e => e.IsPretaxLocal).HasColumnName("isPretaxLocal");
            entity.Property(e => e.IsPretaxState).HasColumnName("isPretaxState");
            entity.Property(e => e.LiabilityAccountId).HasColumnName("LiabilityAccountID");
            entity.Property(e => e.LongDescription).HasMaxLength(500);
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Payer).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
            entity.Property(e => e.W2box)
                .HasMaxLength(50)
                .HasColumnName("W2Box");
            entity.Property(e => e.W2code)
                .HasMaxLength(10)
                .HasColumnName("W2Code");
        });

        modelBuilder.Entity<VtPayrollDeductionTypesBranchAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83FF19282E4");

            entity.ToTable("vt_PayrollDeductionTypesBranchAssoc", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.DeductionMethodId).HasColumnName("DeductionMethodID");
            entity.Property(e => e.DeductionTypeAlias).HasMaxLength(100);
            entity.Property(e => e.DeductionTypeId).HasColumnName("DeductionTypeID");
            entity.Property(e => e.DefaultLimit).HasColumnType("money");
            entity.Property(e => e.DefaultPct).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsNondiscretionary).HasColumnName("isNondiscretionary");
            entity.Property(e => e.IsPreTax).HasColumnName("isPreTax");
            entity.Property(e => e.IsPretaxFederal).HasColumnName("isPretaxFederal");
            entity.Property(e => e.IsPretaxFica).HasColumnName("isPretaxFICA");
            entity.Property(e => e.IsPretaxLocal).HasColumnName("isPretaxLocal");
            entity.Property(e => e.IsPretaxState).HasColumnName("isPretaxState");
            entity.Property(e => e.LongDescription).HasMaxLength(500);
            entity.Property(e => e.Payer).HasMaxLength(50);
            entity.Property(e => e.W2code)
                .HasMaxLength(10)
                .HasColumnName("W2Code");

            entity.HasOne(d => d.Branch).WithMany(p => p.VtPayrollDeductionTypesBranchAssocs)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__vt_Payrol__Branc__5066D2A5");

            entity.HasOne(d => d.DeductionType).WithMany(p => p.VtPayrollDeductionTypesBranchAssocs)
                .HasForeignKey(d => d.DeductionTypeId)
                .HasConstraintName("FK__vt_Payrol__Deduc__515AF6DE");
        });

        modelBuilder.Entity<VtPayrollPayType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83F12F8A7DE");

            entity.ToTable("vt_PayrollPayTypes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ForInvoiceOnly)
                .HasDefaultValue(false)
                .HasColumnName("forInvoiceOnly");
            entity.Property(e => e.InventoryName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceLabel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsTaxable)
                .HasDefaultValue(true)
                .HasColumnName("isTaxable");
            entity.Property(e => e.VtValue)
                .HasMaxLength(100)
                .HasColumnName("vtValue");
            entity.Property(e => e.W2box)
                .HasMaxLength(50)
                .HasColumnName("W2Box");
        });

        modelBuilder.Entity<VtPayrollPayTypesBranchAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Payro__3213E83FDD344F63");

            entity.ToTable("vt_PayrollPayTypesBranchAssoc", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.PayTypeAlias).HasMaxLength(100);
            entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

            entity.HasOne(d => d.Branch).WithMany(p => p.VtPayrollPayTypesBranchAssocs)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__vt_Payrol__Branc__78A9CE29");

            entity.HasOne(d => d.PayType).WithMany(p => p.VtPayrollPayTypesBranchAssocs)
                .HasForeignKey(d => d.PayTypeId)
                .HasConstraintName("FK__vt_Payrol__PayTy__77B5A9F0");
        });

        modelBuilder.Entity<VtPaystubHandling>(entity =>
        {
            entity.ToTable("vt_PaystubHandling", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPrePost>(entity =>
        {
            entity.ToTable("vt_PrePost", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtPriorityLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_prior__3213E83FBB6A88A1");

            entity.ToTable("vt_PriorityLevel", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtProspectStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Prosp__3213E83FC5BA223B");

            entity.ToTable("vt_ProspectStatus", tb => tb.HasComment("variable table - lookup "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.NextStateId).HasColumnName("NextStateID");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtReportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_ReportTypes");

            entity.ToTable("vt_ReportTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Skill__3213E83F131E2C33");

            entity.ToTable("vt_Skills", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(100);
            entity.Property(e => e.SkillIdent).HasMaxLength(10);
            entity.Property(e => e.VtValue)
                .HasMaxLength(100)
                .HasColumnName("vtValue");
            entity.Property(e => e.WorkersCompSkillTypeIdent).HasMaxLength(10);
        });

        modelBuilder.Entity<VtSkillSynonym>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SkillSyn__3213E83FDFDB7857");

            entity.ToTable("vt_SkillSynonyms", tb => tb.HasComment("Creates queryable synonyms for skills so that talent can be queried in a variety of skills-related ways. "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SynonymText).HasMaxLength(100);

            entity.HasOne(d => d.Skill).WithMany(p => p.VtSkillSynonyms)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK__SkillSyno__Skill__324172E1");
        });

        modelBuilder.Entity<VtSkillsGroupDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Skill__3213E83F27B1BDA2");

            entity.ToTable("vt_SkillsGroupDefinition", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(100);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(100)
                .HasColumnName("vtValue");
            entity.Property(e => e.WctypeIdent)
                .HasMaxLength(10)
                .HasColumnName("WCTypeIdent");
        });

        modelBuilder.Entity<VtStateList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_vt_statelist_ID");

            entity.ToTable("vt_StateList", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Abbrev)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtStateOvertimeRule>(entity =>
        {
            entity.ToTable("vt_StateOvertimeRules", tb => tb.HasComment("variable table - lookup -- contains overtime/doubletime rules for all states.  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountMealBreaks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DayDtthreshold)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DayDTThreshold");
            entity.Property(e => e.DayOtthreshold)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DayOTThreshold");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.MealBreakMinutes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealRequiredAtHrs)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinWage).HasColumnType("money");
            entity.Property(e => e.SeventhDayWageMultiplier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StateID");
            entity.Property(e => e.ValidFromDt).HasColumnName("ValidFromDT");
            entity.Property(e => e.ValidToDt).HasColumnName("ValidToDT");
            entity.Property(e => e.WeekOtthreshold)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WeekOTThreshold");
        });

        modelBuilder.Entity<VtTalentScheduleAvailability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Talen__3213E83FA90CE3BA");

            entity.ToTable("vt_TalentScheduleAvailability");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTaxExtraWithholdingType>(entity =>
        {
            entity.ToTable("vt_TaxExtraWithholdingType", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTaxFederalFilingStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_vt_FederalFilingStatus");

            entity.ToTable("vt_TaxFederalFilingStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTaxLocalFilingStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_vt_LocalFilingStatus");

            entity.ToTable("vt_TaxLocalFilingStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTaxStateFilingStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_vt_StateFilingStatus");

            entity.ToTable("vt_TaxStateFilingStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTimeBy15Minute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_TimeB__3213E83F95468D70");

            entity.ToTable("vt_TimeBy15Minutes", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTimeOffAccrualFrequency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_TimeO__3213E83FEB2497DC");

            entity.ToTable("vt_TimeOffAccrualFrequency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(50)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtTransactionStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_Trans__3213E83F925999FE");

            entity.ToTable("vt_TransactionStatus", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtUiLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_uiLan__3213E83F0473D2FC");

            entity.ToTable("vt_uiLanguages", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtWagePeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_WageP__3213E83F87667541");

            entity.ToTable("vt_WagePeriods", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtWcfootnoteId>(entity =>
        {
            entity.ToTable("vt_WCFootnoteID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("ExternalID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.VtValue)
                .HasMaxLength(200)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtWchazardGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_WCHaz__3213E83F1BEB5010");

            entity.ToTable("vt_WCHazardGroups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtWcindustryGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_WCInd__3213E83F9B1D9AAE");

            entity.ToTable("vt_WCIndustryGroups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtWorkShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vt_WorkS__3213E83FB7A84185");

            entity.ToTable("vt_WorkShifts", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        modelBuilder.Entity<VtYesNo>(entity =>
        {
            entity.ToTable("vt_YesNo", tb => tb.HasComment("variable table - lookup  "));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BoolValue).HasColumnName("boolValue");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LookupValue).HasMaxLength(50);
            entity.Property(e => e.VtValue)
                .HasMaxLength(500)
                .HasColumnName("vtValue");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
