using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI
{
    public class CreateOrder
    {

      
        public string SourceSystem { get; set; }
      
        public string SourceOrderNumber { get; set; }
     
        public string TransactionId { get; set; }

        public QuoteHeaderData QuoteHeaderData { get; set; }

        public ItemData ItemData { get; set; }

    }

    public class QuoteHeaderData
    {
      
        public string PurchaseOrderNumber { set; get; }
        public string TotalPurchaseOrderAmount { set; get; }
        public string TotalRequestedValue { set; get; }
        public string AuthorizedTOMV { set; get; }
        public string QuoteName { set; get; }
        public string QuoteCountryCode { set; get; }
        public string ProjectType { set; get; }
        public string PrimaryMarketingProgram { set; get; }
        public string SecondaryMarketingProgram { set; get; }
        public string ResponsibleSalesTerritory { set; get; }
        public string SalesOffice { set; get; }
        public string GovernmentClassification { set; get; }
        public string WeaponQuestionAnswer { set; get; }
        public string ITARQuestionAnswer { set; get; }
        public string NuclearQuestionAnswer { set; get; }
        public string ExternalQuoteIndicator { set; get; }
        public string AddendumThruNumber { set; get; }
        public string BidDate { set; get; }
        public string DropShipPricingIndicator { set; get; }
        public string FederalTaxStatus { set; get; }
        public string LocationCompleteShipIndicator { set; get; }
        public string Routing { set; get; }
        public string Carrier { set; get; }
        public string RebateType { set; get; }
        public string ProposalName { set; get; }
        public QuoteContactPeople QuoteContactPeople { set; get; }
        public ValueChainAccounts ValueChainAccounts { set; get; }

        //[XmlElement("ShipToAddress")]
        //public List<ShipBillAddress> ShipToAddress = new List<ShipBillAddress>();

        public ShipBillAddress ShipToAddress { set; get; }
        public CollectThirdAddress ThirdPartyAddress { set; get; }
        public CollectThirdAddress CollectAddress { set; get; }
        public ShipBillAddress BillToAddress { set; get; }
        public ExportData ExportData { set; get; }
        public ConditionsOfSaleInformation ConditionsOfSaleInformation { set; get; }
        public SpecialRequirements SpecialRequirements { set; get; }


        public List<ProgressBilling> progressBilling = new List<ProgressBilling>();


        public List<AgentCredits> agentCredits = new List<AgentCredits>();

 
        public List<SalesCredit> salesCredit = new List<SalesCredit>();


        public List<ServiceCredit> serviceCredit = new List<ServiceCredit>();

   
        public List<AANotes> aaNotes = new List<AANotes>();

     
        public List<ARNotes> arNotes = new List<ARNotes>();

        public string InstructionsToShipping { set; get; }

        //[XmlElement("Markings")]
        //public List<string> markings = new List<string>();
        public string Markings { set; get; }
    }

    
    public class ItemData
    {
     
        public List<Item> item = new List<Item>();
    }

    
    public class QuoteContactPeople
    {
        public string ProjectManager { set; get; }
        public string EnteredBy { set; get; }
        public string SalesRep { set; get; }
        public string TakeOffPerson { set; get; }
    }

    /// <summary>
    /// Address part of the request
    /// </summary>
    
    public class Address
    {
        
        public string Name { get; set; }
        
        public string StreetAddress { get; set; }
        
        public string BldgFloorSuite { get; set; }
        
        public string Landmark { get; set; }
        
        public string City { get; set; }
        
        public string StateOrProvinceCode { get; set; }
        
        public string PostalCode { get; set; }
        
        public string CountyCode { get; set; }
        
        public string CountryCode { get; set; }
    }

    /// <summary>
    /// Ship-Bill To Address part of the request
    /// </summary>
    
    public class ShipBillAddress : Address
    {
        
        public string POBox { get; set; }
        
        public string COAndAttn { get; set; }
        
        public string DeliveryInstructions { get; set; }
        
        public string WillAddressIndicator { get; set; }

    }

    /// <summary>
    /// Collect-ThirdParty Address part of the request
    /// </summary>
    
    public class CollectThirdAddress : Address
    {
        
        public string FreightAccountNumber { get; set; }
    }

    public class ShipmentScheduleAddress : ShipBillAddress
    {
        public string Add_id { get; set; }
    }
    /// <summary>
    /// Proposal Ship part of the request
    /// </summary>
    
    public class ShipTo
    {
        
        public string Name { get; set; }
        
        public string City { get; set; }
        
        public string County { get; set; }
        
        public string Country { get; set; }
        
        public string PostalCode { get; set; }
        
        public string StateProvince { get; set; }
        
        public string Street { get; set; }
        
        public string BuildingFloorSuite { get; set; }
        
        public string Landmark { get; set; }
        
        public string POBox { get; set; }
        
        public string Attention { get; set; }
        
        public string DeliveryInstructions { get; set; }
    }

    
    public class ValueChainAccounts
    {
        public string DirectPurchaserAccountNumber { set; get; }
        public string DirectPurchaserAccountName { set; get; }
        public string DirectPurchaserPrimaryBusinessType { set; get; }
        //Renamed below 2 fields as per Kim's request - 11/5/2015
        public string SoldToId { set; get; }
        public string SoldToName { set; get; }
        public string InstallerId { set; get; }
        public string InstallerName { set; get; }
        public string ConsultantOrSpecifierId { set; get; }
        public string ConsultantOrSpecifierName { set; get; }
        public string EndUserId { set; get; }
        public string EndUserName { set; get; }
        public string OEMId { set; get; }
        public string OEMName { set; get; }
        public string OtherAccountId1 { set; get; }
        public string OtherAccountName1 { set; get; }
        public string OtherAccountId2 { set; get; }
        public string OtherAccountName2 { set; get; }
        public string OtherAccountId3 { set; get; }
        public string OtherAccountName3 { set; get; }
        public string OtherAccountId4 { set; get; }
        public string OtherAccountName4 { set; get; }
        public string CompetitorId { set; get; }
        public string CompetitorName { set; get; }
        public string TotalCompetitorPrice { set; get; }

    }

    
    public class ExportData
    {
        public string CountryOfFinalDestination { set; get; }
        public string ExportCode { set; get; }
        public string CurrencyExchangeRate { set; get; }
        public string IncoTermsCode { set; get; }
        public string IncoTermsNamedPlace { set; get; }
        public string InternationalCurrencyCode { set; get; }



    }


    public class ConditionsOfSaleInformation
    {
        public string PaymentTerms { set; get; }
        public string CashDiscountPercentage { set; get; }
        public string CashDiscountDay { set; get; }
        public string CashDiscountNetDays { set; get; }
        public string InvoiceFormat { set; get; }
        public string InvoiceMethod { set; get; }
        public string InvoiceFrequency { set; get; }
        public string InvoiceDayForMonthlyBilling { set; get; }
        public string InvoiceDayForBiMonthlyBilling { set; get; }
        public string InvoiceDayForWeeklyBilling { set; get; }
        public string BillingOrInvoicingAcceptedIndicator { set; get; }
        public string BillingOrInvoicingRequestedIndicator { set; get; }
        public string WaiveMinimumBillingIndicator { set; get; }
        public string WaiveShippingChargesIndicator { set; get; }
    }


    public class SpecialRequirements
    {
        public string ApprovalDrawingRequestedIndicator { set; get; }
        public string ApprovalDrawingAcceptedIndicator { set; get; }
        public string ApprovalDrawingCustomerRequestFormat { set; get; }
        public string ApprovalDrawingMfgFormat { set; get; }
        public string ApprovalDrawingMfgDeliveryFormat { set; get; }
        public string RecordDrawingCustomerRequestFormat { set; get; }
        public string RecordDrawingMfgformat { set; get; }
        public string RecordDrawingMfgDeliveryFormat { set; get; }
        public string ManualsRequestedIndicator { set; get; }
        public string ManualsAcceptedIndicator { set; get; }
        public string QuantityOfManuals { set; get; }
        public string ManualsMfgFormat { set; get; }
        public string ManualsFormat { set; get; }
        public string PricingPolicyRequestedIndicator { set; get; }
        public string PricingPolicyAcceptedIndicator { set; get; }
        public string BidBondindicator { set; get; }
        public string PerformanceBondIndicator { set; get; }
        public string LiquidatedDamageIndicator { set; get; }
        public string PricingPolicy { set; get; }
        public string TestAndTrialRequestedIndicator { set; get; }
        public string TestAndTrialAcceptedIndicator { set; get; }
        public string TestAndTrial { set; get; }
        public string CommitConvertDate { set; get; }
        public string CommitShipRequestedIndicator { set; get; }
        public string CommitShipAcceptedIndicator { set; get; }
        public string TestAndReportsRequestedIndicator { set; get; }
        public string TestAndReportsAcceptedIndicator { set; get; }
        public string WarrantyRequestedIndicator { set; get; }
        public string WarrantyAcceptedIndicator { set; get; }
        public string FOBRequestedIndicator { set; get; }
        public string FOBAcceptedIndicator { set; get; }
    }

    
    public class AgentCredits
    {
        public string Agent { set; get; }
        public string Percent { set; get; }
    }

    
    public class SalesCredit
    {
        public string Territory { set; get; }
        public string SalesEngineer { set; get; }
        public string Percent { set; get; }
    }

    
    public class ServiceCredit
    {
        public string Territory { set; get; }
        public string ServiceEngineer { set; get; }
        public string Percent { set; get; }
    }

    
    public class ProgressBilling
    {
        public string InvoiceDate { set; get; }
        public string BillingDescription { set; get; }
        public string FollowUpDate { set; get; }
        public string InvoiceAmount { set; get; }
        public string Name { set; get; }
        public string BillingPercent { set; get; }
    }
    
    public class AANotes
    {
        public string Description { set; get; }
    }
    
    public class ARNotes
    {
        public string Description { set; get; }
    }

    public class item
    {
        public string SourceLineNumber { set; get; }
        public string ParentLineNumber { set; get; }
        public string RelationshipFilter { set; get; }
        //public string SourceSubLineId { set; get; }
        //public string SourceShipScheduleId { set; get; }
        public string RebateItemIndicator { set; get; }
        public string SublineItemTypeIndicator { set; get; }
        public string IncompleteLineIndicator { set; get; }
        public string Quantity { set; get; }
        public string CatalogNumber { set; get; }
        public string CatalogDescription { set; get; }
        public string ProductCode { set; get; }
        public string NonProfileItemIndicator { set; get; }
        public string LineCode { set; get; }
        public string CategoryId { set; get; }
        public string SubCategoryId { set; get; }
        public string ProductDiscountSchedule { set; get; }
        public string UnitWeight { set; get; }
        public string BackOrderPriorityCode { set; get; }
        public string NoChargeIndicator { set; get; }
        public string FreightBusinessArea { set; get; }
        public string HazardousMaterialDocumentIndicator { set; get; }
        public string UnitOfMeasure { set; get; }
        public string NonStockSparePartCode { set; get; }
        public string StateProvinceTaxStatus { set; get; }
        public string InventoryProfitLocation { set; get; }
        public string ManufacturingLocation { set; get; }
        public string MarketingHeadQuarterLocation { set; get; }
        public string MarketingLocation { set; get; }
        public string ItemShippingLocation { set; get; }
        public string ItemLongDescription { set; get; }
        public string SAPMaterialID { set; get; }
        public ConfigurationDetail ConfigurationDetails { set; get; }
        public ItemPricingDetail ItemPricingDetail { set; get; }
        public string BillOnlyIndicator { set; get; }
        public string BillOnlyDate { set; get; }
        public string FOB { set; get; }
        public string FOBPercentage { set; get; }
        public string FOBWhere { set; get; }
        public string WarrantyCode { set; get; }
        public string WarrantyPercentage { set; get; }
        public string WarrantyCostIncludedIndicator { set; get; }
        public string ManualsSuppliedByCode { set; get; }
        public string ApprovalDrawingSuppliedByCode { set; get; }
        public string RequestedPlantSendOutDrawingDate { set; get; }
        public string ApprovedPlantSendOutDrawingDate { set; get; }
        public string RequestedReleaseToMfgDate { set; get; }
        public string ApprovedReleaseToMfgDate { set; get; }
        public string RecordDrawingsSuppliedByCode { set; get; }
        public string RequestedCommitShipDate { set; get; }
        public string ApprovedCommitShipDate { set; get; }
        public string SystemDesignation { set; get; }
        public string EstimatedManufacturingDays { set; get; }
        public string EquipmentTest { set; get; }
        public string TestReport { set; get; }
        public string CountryofOrigin { set; get; }
        public string HarmonizedCode { set; get; }
        public string ECCNNumber { set; get; }
        public ItemCostInformation ItemCostInformation { set; get; }
        //Kiran Added Canadaorders
        public CrossBorder CrossBorder { set; get; }
        //till here

        //[XmlElement("Markings")]
        //public List<string> markings = new List<string>();
        public string Markings { set; get; }

        public string InstructionsToEngineering { set; get; }
        public string InstructionsToShipping { set; get; }

    
        public List<ShipmentInformation> shipmentInfo = new List<ShipmentInformation>();
    }

    
    public class Item : item
    {
 
        public List<ComponentItem> componentItem = new List<ComponentItem>();
    }


    public class ComponentItem : item
    {
        public string SourceSubLineId { set; get; }
    }

    
    public class ConfigurationDetail
    {
        public string ProductId { set; get; }
        public string ProductMaterialType { set; get; }
        public string ProductSelectorName { set; get; }
        public string CostStatusCode { set; get; }
        public string EngineeringStatusCode { set; get; }
        public string ProductSequenceId { set; get; }
        public string DeliveryCode { set; get; }
        public string DeletableIndicator { set; get; }
        public string AdjustedQtyIndicator { set; get; }
        public string DesignationDescription { set; get; }
        public string CatalogEditIndicator { set; get; }
        public string LineItemCopyIndicator { set; get; }
        public string SystemAdjustedSPDIndicator { set; get; }
        public string NonSNAIndicator { set; get; }
     
        public List<Features> features = new List<Features>();
        //[XmlElement("Drawings"
        //public List<Drawings> drawings = new List<Drawings>();
     
        public List<ThirdPartySupplierInformation> thirdPartySupplierInfo = new List<ThirdPartySupplierInformation>();
    }

    
    public class ItemPricingDetail
    {
        public string CurrentUnitListPrice { set; get; }
        public string RequestedExtendedSellingNetPrice { set; get; }
        public string NormalNetMultiplier { set; get; }
        public string InternalUnitNetPrice { set; get; }
        public string ProfileNetMultiplier { set; get; }
        public string ProfileUnitNetPrice { set; get; }
        public string ProfilePriceMultiplierSource { set; get; }
        public string AuthorizedCompetitorCode { set; get; }
        public string AuthorizedUnitSellingNetPrice { set; get; }
        public string AuthorizedUnitSellingNetMultiplier { set; get; }
        public string CategoryItemizedIndicator { set; get; }
        public string FixMultiplierIndicator { set; get; }
        public string FixPriceIndicator { set; get; }
        public string CashDiscountPercent { set; get; }
    }

    //Kiran Added CrossBorder
    
    public class CrossBorder
    {
        public string XBAuthProfileNetMult { set; get; }
        public string XBAuthSellNetMult { set; get; }
        public string XBDualSrceInd { set; get; }
        public string XBEccnNbr { set; get; }
        public string XBNormNetMult { set; get; }
        public string XBPrflNetMult { set; get; }
        public string XBPriceSource { set; get; }
        public string XBPrflUnitPrice { set; get; }
        public string XBCostMarkUp { set; get; }
        public string XBDescription { set; get; }
        public string XBLineCode { set; get; }
        public string XBMfgLoc { set; get; }
        public string XBMktLoc { set; get; }
        public string XBNoChrgInd { set; get; }
        public string XBNonSysProdInd { set; get; }
        public string XBNonstkSparPrtCd { set; get; }
        public string XBIndicator { set; get; }
        public string XBAuthSNP { set; get; }
        public string XBListPrice { set; get; }
        public string XBCustomsValue { set; get; }
        public string XBCostFixBurdn { set; get; }
        public string XBCostLabor { set; get; }
        public string XBCostMarterial { set; get; }
        public string XBCostMfgBurdn { set; get; }
        public string XBCostVarBurdn { set; get; }
        public string XBPDCategory { set; get; }
        public string XBProductDiscSchedID { set; get; }
        public string XBHTS { set; get; }
        public string XBCountryOfOrigin { set; get; }
        public string XBInvProfLoc { set; get; }
        public string XBCurrencyXChangeRate { set; get; }
        public string XBIntlCurrencyCode { set; get; }
        public string XBPurchaserID { set; get; }
        public string XBSalesTerritory { set; get; }
    }
    //till here


    
    public class ItemCostInformation
    {
        public string UnitFixBurdenCost { set; get; }
        public string UnitLaborCost { set; get; }
        public string MarkUpCost { set; get; }
        public string MaterialCost { set; get; }
        public string UnitMfgBurdenCost { set; get; }
        public string UnitPurchaserCost { set; get; }
        public string UnitVariableBurdenCost { set; get; }
    }

    
    public class ThirdPartySupplierInformation
    {
        public string Supplier { set; get; }
        public string SupplierCost { set; get; }
        public string SupplierCostCurrencyCode { set; get; }
    }

    
    public class Features
    {
        public string ContentType { set; get; }
        public string FeaturesContent { set; get; }
    }

    
    public class Drawings
    {
        public string DrawingContent { set; get; }
        public string DataClassification { set; get; }
        public string DataFormat { set; get; }
        public string GroupNumber { set; get; }
        public string ResultsTitle { set; get; }
        public string ResultsType { set; get; }
    }

    
    public class ShipmentInformation
    {
        public string SourceShipScheduleId { set; get; }
        public string Quantity { set; get; }
        public string ShippingLocation { set; get; }
        public string FreightTerms { set; get; }
        public string NotBeforeDate { set; get; }
        public string OriginalOnsiteDate { set; get; }
        public string CustomerRequestedDeliveryDate { set; get; }
        public string Routing { set; get; }
        public string Carrier { set; get; }
        public Holds Holds { set; get; }
        //[XmlElement("Holds"
        //public List<string> holds = new List<string>();
        public ShipBillAddress ShipToAddress { set; get; }

    }

    /// <summary>
    /// Marking Document Data of the request
    /// </summary>    
    public class Holds
    {
        public string PurchaserHold { set; get; }
        public string ClarificationHold { set; get; }
        public string EngineeringHold { set; get; }
        public string InternationalShippingHold { set; get; }
        public string MarketingHold { set; get; }
    }

    /// <summary>
    /// Marking Document Data of the request
    /// </summary>    
    public class MarkingDocument
    {
        public string DocId { set; get; }
    }

    /// <summary>
    /// Header part of the request
    /// </summary>    
    public class HeaderDetail
    {
        /// <summary>
        /// Required or mandatory fields in the request
        /// </summary>
        /// 
        
        public string SourceSystemInd { get; set; }
        
        public string UserCountryCode { get; set; }
        
        public string OrderNumber { get; set; }
        
        public string PurchaserID { get; set; }
        
        public string CustomerID { get; set; }
        
        public string InstallerId { get; set; }
        
        public string ConsultantorSpecifierId { get; set; }
        
        public string EndCustomerID { get; set; }
        
        public string OEMAccountID { get; set; }
        
        public string SoldToAccountID { get; set; }
        
        public ShipBillAddress ProposalAddress { get; set; }
        
        public ShipTo ShipToAddress { get; set; }
        
        public string Routing { get; set; }
        
        public string Carrier { get; set; }
        
        public string GovernmentClass { get; set; }
        
        public string MarketingSegmentType { get; set; }
        
        public string JobSiteSalesTerritory { get; set; }
        
        public string QuoteName { get; set; }
        
        public string QuoteSubName { get; set; }
        
        public string QuoteTakeOffName { get; set; }
        
        public string ProjectManagerID { get; set; }
        
        public string SalesRepID { get; set; }
        
        public string LocationCompleteShipIndicator { get; set; }
        
        public string DropShipPricingIndicator { get; set; }
        
        public string Markings { get; set; }
        
        public List<MarkingDocument> MarkingsDocuments { get; set; }
        
        public string Notes { get; set; }
        
        public string CompetitorID { get; set; }
        
        public string TotalCompetitorPrice { get; set; }
        
        public string CurrentAuthTOMV { get; set; }
        
        public string PurchaseOrderNumber { get; set; }
        
        public string PurchaseAmount { get; set; }
    }

    /// <summary>
    /// Details part of the request
    /// </summary>   
    public class ItemDetail
    {
        /// <summary>
        /// Required or mandatory fields in the request
        /// </summary>
        ///
        
        public string ExternalItemIdentifier { get; set; }
        
        public string PurchSpecifyLnNbr { get; set; }
        
        public string Quantity { get; set; }
        
        public string UOM { get; set; }
        
        public string ProductCode { get; set; }
        
        public string ProductId { get; set; }
        
        public string Catalog { get; set; }
        
        public string CatalogDescription { get; set; }
        
        public string LongDescription { get; set; }
        
        public string Designation { get; set; }
        
        public string ModificationType { get; set; }
        
        public string SystemRecognizedFlag { get; set; }
        
        public string UnitNetPrice { get; set; }
        
        public string UnitListPrice { get; set; }
        
        public string NormalUnitNetPrice { get; set; }
        
        public string NormalDerivedInd { get; set; }
        
        public string NormalMultiplier { get; set; }
        
        public string ProfileMultiplier { get; set; }
        
        public string AuthSellNetMultiplier { get; set; }
        
        public string ProfilePriceMultiplierSource { get; set; }
        
        public string LineCode { get; set; }
        
        public string ProductCategory { get; set; }
        
        public string ProductSubCategory { get; set; }
        
        public string ProductDiscountSchedule { get; set; }
        
        public string NoChargeFlag { get; set; }
        
        public string UnitWeight { get; set; }
        
        public string NonStkSparePartCd { get; set; }
        
        public string FreightBusinessArea { get; set; }
        
        public string HazardousMaterialFlag { get; set; }
        
        public string DiscountPercent { get; set; }
        
        public string NetPayDays { get; set; }
        
        public string BackOrderPriorityCode { get; set; }
        
        public string NotBeforeDate { get; set; }
        
        public string ShippingLocation { get; set; }
        
        public string ManufacturingLocation { get; set; }
        
        public string MarketingLocation { get; set; }
        
        public string MarketingHeadquartersLocation { get; set; }
        
        public string InventoryProfitLocation { get; set; }
        
        public string FixedBurdenCost { get; set; }
        
        public string LaborCost { get; set; }
        
        public string PurchaserCost { get; set; }
        
        public string ManufacturingBurdenCost { get; set; }
        
        public string MarkUpCost { get; set; }
        
        public string MaterialCost { get; set; }
        
        public string VariableBurdenCost { get; set; }
        
        public string InstructionsToShipping { get; set; }
        
        public string EngineeringInstructions { get; set; }
        
        public string Markings { get; set; }
        
        public List<MarkingDocument> MarkingsDocuments { get; set; }
        
        public string WarrantyCode { get; set; }
        
        public string WarrantyCostIncl { get; set; }


        //For Non-System Recognized Products, we are using the below variables to send default values
        
        public string ProductMaterialType { get; set; }
        
        public string ProductMaterialTypeId { get; set; }
        
        public string DeliveryScheduleCode { get; set; }
        
        public string LineItemDeletableIndicator { get; set; }
        
        public string AdjustableQuantityIndicator { get; set; }
        
        public string CategoryItemizeIndicator { get; set; }
        
        public string CatalogNumberEditableIndicator { get; set; }
        
        public string LineItemCopiedIndicator { get; set; }
        
        public string SystemAdjustSPDIndicator { get; set; }
        
        public string AvailableFromWarehouse { get; set; }
    }

    /// <summary>
    ///Bill of Material Data
    /// </summary>    
    public class BOM
    { 
        
        public string BOMName { get; set; }
        
        public string BOMSubName { get; set; }
        
        public string BOMTakeOffName { get; set; }
        
        public List<ItemDetail> ItemDetails { get; set; }

    }

    /// <summary>
    ///Quote Order Data
    /// </summary>    
    public class QuoteOrder
    {
        //Header part of the request
        
        public HeaderDetail Header { get; set; }

        //Details part of the request
        
        public BOM BillOfMaterial { get; set; }
    }

}