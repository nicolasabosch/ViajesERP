using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ViajesERPModel.Model;

namespace DemoCabernetNet6;

public partial class Entities : DbContext
{
    public Entities(DbContextOptions<Entities> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountPayable> AccountPayable { get; set; }

    public virtual DbSet<AccountReceivable> AccountReceivable { get; set; }

    public virtual DbSet<Audit> Audit { get; set; }

    public virtual DbSet<AuditDetail> AuditDetail { get; set; }

    public virtual DbSet<Bank> Bank { get; set; }

    public virtual DbSet<BatchPayment> BatchPayment { get; set; }

    public virtual DbSet<BatchPaymentValue> BatchPaymentValue { get; set; }

    public virtual DbSet<BusinessUnit> BusinessUnit { get; set; }

    public virtual DbSet<BusinessUnitType> BusinessUnitType { get; set; }

    public virtual DbSet<Carrier> Carrier { get; set; }

    public virtual DbSet<CashDesk> CashDesk { get; set; }

    public virtual DbSet<CashDeskValueType> CashDeskValueType { get; set; }

    public virtual DbSet<Channel> Channel { get; set; }

    public virtual DbSet<Check> Check { get; set; }

    public virtual DbSet<CheckStatus> CheckStatus { get; set; }

    public virtual DbSet<ChequesEnCartera> ChequesEnCartera { get; set; }

    public virtual DbSet<ClientError> ClientError { get; set; }

    public virtual DbSet<CommissionCalculated> CommissionCalculated { get; set; }

    public virtual DbSet<CommissionPayable> CommissionPayable { get; set; }

    public virtual DbSet<CommissionProductFamily> CommissionProductFamily { get; set; }

    public virtual DbSet<Concept> Concept { get; set; }

    public virtual DbSet<ConceptGroup> ConceptGroup { get; set; }

    public virtual DbSet<ContactSource> ContactSource { get; set; }

    public virtual DbSet<CountOrder> CountOrder { get; set; }

    public virtual DbSet<CountOrderItem> CountOrderItem { get; set; }

    public virtual DbSet<CountOrderStatus> CountOrderStatus { get; set; }

    public virtual DbSet<Counterfoil> Counterfoil { get; set; }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<CreditNote> CreditNote { get; set; }

    public virtual DbSet<CreditNoteItem> CreditNoteItem { get; set; }

    public virtual DbSet<Currency> Currency { get; set; }

    public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<CustomerBusinessUnit> CustomerBusinessUnit { get; set; }

    public virtual DbSet<CustomerClass> CustomerClass { get; set; }

    public virtual DbSet<CustomerDeliveryAddress> CustomerDeliveryAddress { get; set; }

    public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }

    public virtual DbSet<CustomerType> CustomerType { get; set; }

    public virtual DbSet<DebitNote> DebitNote { get; set; }

    public virtual DbSet<DebitNoteCheck> DebitNoteCheck { get; set; }

    public virtual DbSet<DeliveryStatus> DeliveryStatus { get; set; }

    public virtual DbSet<DeliveryType> DeliveryType { get; set; }

    public virtual DbSet<DeliveryZone> DeliveryZone { get; set; }

    public virtual DbSet<Document> Document { get; set; }

    public virtual DbSet<DocumentClass> DocumentClass { get; set; }

    public virtual DbSet<DocumentStatus> DocumentStatus { get; set; }

    public virtual DbSet<DocumentSubType> DocumentSubType { get; set; }

    public virtual DbSet<DocumentType> DocumentType { get; set; }

    public virtual DbSet<Dolar> Dolar { get; set; }

    public virtual DbSet<Endorsable> Endorsable { get; set; }

    public virtual DbSet<EndorsableCompany> EndorsableCompany { get; set; }

    public virtual DbSet<EndorsableCustomer> EndorsableCustomer { get; set; }

    public virtual DbSet<Event> Event { get; set; }

    public virtual DbSet<ExpenseSubType> ExpenseSubType { get; set; }

    public virtual DbSet<ExpenseType> ExpenseType { get; set; }

    public virtual DbSet<ViajesERPModel.Model.File> File { get; set; }

    public virtual DbSet<FileType> FileType { get; set; }

    public virtual DbSet<FiscalCodeType> FiscalCodeType { get; set; }

    public virtual DbSet<Freight> Freight { get; set; }

    public virtual DbSet<Hoja> Hoja { get; set; }

    public virtual DbSet<Inventory> Inventory { get; set; }

    public virtual DbSet<InventoryBarCode> InventoryBarCode { get; set; }

    public virtual DbSet<InventoryBarCodeStatus> InventoryBarCodeStatus { get; set; }

    public virtual DbSet<InventoryMovement> InventoryMovement { get; set; }

    public virtual DbSet<InventoryTransfer> InventoryTransfer { get; set; }

    public virtual DbSet<InventoryTransferType> InventoryTransferType { get; set; }

    public virtual DbSet<Journal> Journal { get; set; }

    public virtual DbSet<LabelType> LabelType { get; set; }

    public virtual DbSet<Manufacturer> Manufacturer { get; set; }

    public virtual DbSet<MemberType> MemberType { get; set; }

    public virtual DbSet<MenuBar> MenuBar { get; set; }

    public virtual DbSet<MenuItem> MenuItem { get; set; }

    public virtual DbSet<Message> Message { get; set; }

    public virtual DbSet<MessageCategory> MessageCategory { get; set; }

    public virtual DbSet<MessageGroup> MessageGroup { get; set; }

    public virtual DbSet<MessageGroupUser> MessageGroupUser { get; set; }

    public virtual DbSet<MessageStatus> MessageStatus { get; set; }

    public virtual DbSet<MessageUser> MessageUser { get; set; }

    public virtual DbSet<MissingSaleOrder> MissingSaleOrder { get; set; }

    public virtual DbSet<MoveOrder> MoveOrder { get; set; }

    public virtual DbSet<MoveOrderItem> MoveOrderItem { get; set; }

    public virtual DbSet<MoveOrderStatus> MoveOrderStatus { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnit { get; set; }

    public virtual DbSet<OrganizationUnitContact> OrganizationUnitContact { get; set; }

    public virtual DbSet<Parameter> Parameter { get; set; }

    public virtual DbSet<PaymentCondition> PaymentCondition { get; set; }

    public virtual DbSet<PaymentDeclare> PaymentDeclare { get; set; }

    public virtual DbSet<PickingOrder> PickingOrder { get; set; }

    public virtual DbSet<PickingOrderItem> PickingOrderItem { get; set; }

    public virtual DbSet<PickingStatus> PickingStatus { get; set; }

    public virtual DbSet<PriceList> PriceList { get; set; }

    public virtual DbSet<PriceListProduct> PriceListProduct { get; set; }

    public virtual DbSet<PriceListProductFamily> PriceListProductFamily { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<ProductBOM> ProductBOM { get; set; }

    public virtual DbSet<ProductBrand> ProductBrand { get; set; }

    public virtual DbSet<ProductBusinessUnit> ProductBusinessUnit { get; set; }

    public virtual DbSet<ProductCategory> ProductCategory { get; set; }

    public virtual DbSet<ProductClass> ProductClass { get; set; }

    public virtual DbSet<ProductComposition> ProductComposition { get; set; }

    public virtual DbSet<ProductCondition> ProductCondition { get; set; }

    public virtual DbSet<ProductCustomDelivery> ProductCustomDelivery { get; set; }

    public virtual DbSet<ProductFamily> ProductFamily { get; set; }

    public virtual DbSet<ProductFamilyCustomDeliveryCode> ProductFamilyCustomDeliveryCode { get; set; }

    public virtual DbSet<ProductFamilyUnitOfMeasureConversion> ProductFamilyUnitOfMeasureConversion { get; set; }

    public virtual DbSet<ProductGroup> ProductGroup { get; set; }

    public virtual DbSet<ProductSeasonality> ProductSeasonality { get; set; }

    public virtual DbSet<ProductStatus> ProductStatus { get; set; }

    public virtual DbSet<ProductTag> ProductTag { get; set; }

    public virtual DbSet<ProductType> ProductType { get; set; }

    public virtual DbSet<ProductUnitOfMeasureConversion> ProductUnitOfMeasureConversion { get; set; }

    public virtual DbSet<Production> Production { get; set; }

    public virtual DbSet<ProductionStatus> ProductionStatus { get; set; }

    public virtual DbSet<PurchaseDelivery> PurchaseDelivery { get; set; }

    public virtual DbSet<PurchaseDeliveryDetail> PurchaseDeliveryDetail { get; set; }

    public virtual DbSet<PurchaseDeliveryItem> PurchaseDeliveryItem { get; set; }

    public virtual DbSet<PurchaseDeliverySettlement> PurchaseDeliverySettlement { get; set; }

    public virtual DbSet<PurchaseDeliveryStatus> PurchaseDeliveryStatus { get; set; }

    public virtual DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }

    public virtual DbSet<PurchaseInvoicePurchaseReception> PurchaseInvoicePurchaseReception { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    public virtual DbSet<PurchaseOrderItem> PurchaseOrderItem { get; set; }

    public virtual DbSet<PurchaseOrderStatus> PurchaseOrderStatus { get; set; }

    public virtual DbSet<PurchaseReception> PurchaseReception { get; set; }

    public virtual DbSet<PurchaseReceptionItem> PurchaseReceptionItem { get; set; }

    public virtual DbSet<PurchaseReceptionStatus> PurchaseReceptionStatus { get; set; }

    public virtual DbSet<Receipt> Receipt { get; set; }

    public virtual DbSet<ReceiptAccountReceivable> ReceiptAccountReceivable { get; set; }

    public virtual DbSet<ReceiptControlStatus> ReceiptControlStatus { get; set; }

    public virtual DbSet<ReceiptFile> ReceiptFile { get; set; }

    public virtual DbSet<ReceiptValue> ReceiptValue { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<RoleMenuItem> RoleMenuItem { get; set; }

    public virtual DbSet<Rule> Rule { get; set; }

    public virtual DbSet<RuleField> RuleField { get; set; }

    public virtual DbSet<SaleChannel> SaleChannel { get; set; }

    public virtual DbSet<SaleDelivery> SaleDelivery { get; set; }

    public virtual DbSet<SaleDeliveryItem> SaleDeliveryItem { get; set; }

    public virtual DbSet<SaleDeliveryNote> SaleDeliveryNote { get; set; }

    public virtual DbSet<SaleDeliveryNoteHistory> SaleDeliveryNoteHistory { get; set; }

    public virtual DbSet<SaleDeliveryNoteHistoryItem> SaleDeliveryNoteHistoryItem { get; set; }

    public virtual DbSet<SaleDeliveryNoteItem> SaleDeliveryNoteItem { get; set; }

    public virtual DbSet<SaleDeliveryNoteStatus> SaleDeliveryNoteStatus { get; set; }

    public virtual DbSet<SaleDeliveryOnTripStatus> SaleDeliveryOnTripStatus { get; set; }

    public virtual DbSet<SaleDeliveryRejectReason> SaleDeliveryRejectReason { get; set; }

    public virtual DbSet<SaleDeliveryStatus> SaleDeliveryStatus { get; set; }

    public virtual DbSet<SaleDistrict> SaleDistrict { get; set; }

    public virtual DbSet<SaleGroup> SaleGroup { get; set; }

    public virtual DbSet<SaleOrder> SaleOrder { get; set; }

    public virtual DbSet<SaleOrderItem> SaleOrderItem { get; set; }

    public virtual DbSet<SaleOrderStatus> SaleOrderStatus { get; set; }

    public virtual DbSet<SaleOrderTaskStatus> SaleOrderTaskStatus { get; set; }

    public virtual DbSet<SaleRepresentative> SaleRepresentative { get; set; }

    public virtual DbSet<SaleRepresentativePayment> SaleRepresentativePayment { get; set; }

    public virtual DbSet<SaleRepresentativePaymentCommissionPayable> SaleRepresentativePaymentCommissionPayable { get; set; }

    public virtual DbSet<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; set; }

    public virtual DbSet<SaleRetail> SaleRetail { get; set; }

    public virtual DbSet<SaleRetailCredit> SaleRetailCredit { get; set; }

    public virtual DbSet<SaleRetailItem> SaleRetailItem { get; set; }

    public virtual DbSet<SaleRetailValue> SaleRetailValue { get; set; }

    public virtual DbSet<Schedule> Schedule { get; set; }

    public virtual DbSet<Season> Season { get; set; }

    public virtual DbSet<SqlScript> SqlScript { get; set; }

    public virtual DbSet<State> State { get; set; }

    public virtual DbSet<Tag> Tag { get; set; }

    public virtual DbSet<ViajesERPModel.Model.Task> Task { get; set; }

    public virtual DbSet<TaskClass> TaskClass { get; set; }

    public virtual DbSet<TaskCondition> TaskCondition { get; set; }

    public virtual DbSet<TaskLog> TaskLog { get; set; }

    public virtual DbSet<TaskLogStatus> TaskLogStatus { get; set; }

    public virtual DbSet<ViajesERPModel.Model.TaskStatus> TaskStatus { get; set; }

    public virtual DbSet<TaskType> TaskType { get; set; }

    public virtual DbSet<Team> Team { get; set; }

    public virtual DbSet<TeamUser> TeamUser { get; set; }

    public virtual DbSet<ThirdPartyBusinessUnit> ThirdPartyBusinessUnit { get; set; }

    public virtual DbSet<TransferOrder> TransferOrder { get; set; }

    public virtual DbSet<TransferOrderItem> TransferOrderItem { get; set; }

    public virtual DbSet<TransferOrderStatus> TransferOrderStatus { get; set; }

    public virtual DbSet<Trip> Trip { get; set; }

    public virtual DbSet<TripEvent> TripEvent { get; set; }

    public virtual DbSet<TripSaleDelivery> TripSaleDelivery { get; set; }

    public virtual DbSet<TripSaleRetail> TripSaleRetail { get; set; }

    public virtual DbSet<TripStatus> TripStatus { get; set; }

    public virtual DbSet<TripType> TripType { get; set; }

    public virtual DbSet<TripWithdrawalOrder> TripWithdrawalOrder { get; set; }

    public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }

    public virtual DbSet<Urgency> Urgency { get; set; }

    public virtual DbSet<User> User { get; set; }

    public virtual DbSet<UserDataView> UserDataView { get; set; }

    public virtual DbSet<UserMenuItem> UserMenuItem { get; set; }

    public virtual DbSet<UserRole> UserRole { get; set; }

    public virtual DbSet<ValueStatus> ValueStatus { get; set; }

    public virtual DbSet<ViajesERPModel.Model.ValueType> ValueType { get; set; }

    public virtual DbSet<ValueTypeGroup> ValueTypeGroup { get; set; }

    public virtual DbSet<VehicleType> VehicleType { get; set; }

    public virtual DbSet<Vendor> Vendor { get; set; }

    public virtual DbSet<VendorPayment> VendorPayment { get; set; }

    public virtual DbSet<VendorPaymentAccountPayable> VendorPaymentAccountPayable { get; set; }

    public virtual DbSet<VendorPaymentValue> VendorPaymentValue { get; set; }

    public virtual DbSet<Warehouse> Warehouse { get; set; }

    public virtual DbSet<WarehouseGroup> WarehouseGroup { get; set; }

    public virtual DbSet<WarehousePosition> WarehousePosition { get; set; }

    public virtual DbSet<WithdrawalOrder> WithdrawalOrder { get; set; }

    public virtual DbSet<WithdrawalOrderItem> WithdrawalOrderItem { get; set; }

    public virtual DbSet<WithdrawalOrderStatus> WithdrawalOrderStatus { get; set; }

    public virtual DbSet<Workflow> Workflow { get; set; }

    public virtual DbSet<vAllDocument> vAllDocument { get; set; }

    public virtual DbSet<vBarCodeInventory> vBarCodeInventory { get; set; }

    public virtual DbSet<vBasePriceAndProductCommission> vBasePriceAndProductCommission { get; set; }

    public virtual DbSet<vBatchPayment> vBatchPayment { get; set; }

    public virtual DbSet<vBatchPaymentTarot> vBatchPaymentTarot { get; set; }

    public virtual DbSet<vCheck> vCheck { get; set; }

    public virtual DbSet<vClientesVendedores> vClientesVendedores { get; set; }

    public virtual DbSet<vClientesYaquira> vClientesYaquira { get; set; }

    public virtual DbSet<vCuernina> vCuernina { get; set; }

    public virtual DbSet<vCurrencyRate> vCurrencyRate { get; set; }

    public virtual DbSet<vCurrencyRateAvg> vCurrencyRateAvg { get; set; }

    public virtual DbSet<vDeliveryItemStatusReport> vDeliveryItemStatusReport { get; set; }

    public virtual DbSet<vDeliveryStatusReport> vDeliveryStatusReport { get; set; }

    public virtual DbSet<vDetallePedidosFulltex> vDetallePedidosFulltex { get; set; }

    public virtual DbSet<vDetallePedidosTarot> vDetallePedidosTarot { get; set; }

    public virtual DbSet<vDeudaDirectos> vDeudaDirectos { get; set; }

    public virtual DbSet<vDeudaTarot> vDeudaTarot { get; set; }

    public virtual DbSet<vDeudaTarotComma> vDeudaTarotComma { get; set; }

    public virtual DbSet<vDolarIntermedio> vDolarIntermedio { get; set; }

    public virtual DbSet<vIntransitToOrganizationUnit> vIntransitToOrganizationUnit { get; set; }

    public virtual DbSet<vItemNotaDeCredito> vItemNotaDeCredito { get; set; }

    public virtual DbSet<vItemNotaDeCredito20220120> vItemNotaDeCredito20220120 { get; set; }

    public virtual DbSet<vItemNotaDeCredito20230721> vItemNotaDeCredito20230721 { get; set; }

    public virtual DbSet<vItemRemito> vItemRemito { get; set; }

    public virtual DbSet<vMinoristaFamilia> vMinoristaFamilia { get; set; }

    public virtual DbSet<vNotaDeCredito> vNotaDeCredito { get; set; }

    public virtual DbSet<vNotaDeCredito20220120> vNotaDeCredito20220120 { get; set; }

    public virtual DbSet<vOrganizationUnitForMoveOrder> vOrganizationUnitForMoveOrder { get; set; }

    public virtual DbSet<vPackingList> vPackingList { get; set; }

    public virtual DbSet<vPayment> vPayment { get; set; }

    public virtual DbSet<vPriceList> vPriceList { get; set; }

    public virtual DbSet<vPriceListForStock> vPriceListForStock { get; set; }

    public virtual DbSet<vPriceListForVenta> vPriceListForVenta { get; set; }

    public virtual DbSet<vProductAvailableForPicking> vProductAvailableForPicking { get; set; }

    public virtual DbSet<vProductBusinessUnitInventoryAndSoftCommitted> vProductBusinessUnitInventoryAndSoftCommitted { get; set; }

    public virtual DbSet<vProductBusinessUnitSoftCommitted> vProductBusinessUnitSoftCommitted { get; set; }

    public virtual DbSet<vProductFamilyActive> vProductFamilyActive { get; set; }

    public virtual DbSet<vProductGroup> vProductGroup { get; set; }

    public virtual DbSet<vProductInventoryAndSoftCommitted> vProductInventoryAndSoftCommitted { get; set; }

    public virtual DbSet<vProductLabelTypeCustomerDeliveryCode> vProductLabelTypeCustomerDeliveryCode { get; set; }

    public virtual DbSet<vProductSoftCommitted> vProductSoftCommitted { get; set; }

    public virtual DbSet<vProductSoftCommittedDetail> vProductSoftCommittedDetail { get; set; }

    public virtual DbSet<vProductWareHouseInventoryAndSoftCommitted> vProductWareHouseInventoryAndSoftCommitted { get; set; }

    public virtual DbSet<vProductWithBOM> vProductWithBOM { get; set; }

    public virtual DbSet<vPurchaseOrderTotal> vPurchaseOrderTotal { get; set; }

    public virtual DbSet<vReceipt> vReceipt { get; set; }

    public virtual DbSet<vReceiptApplied> vReceiptApplied { get; set; }

    public virtual DbSet<vReceiptAppliedAux> vReceiptAppliedAux { get; set; }

    public virtual DbSet<vReceiptAppliedInCurrency> vReceiptAppliedInCurrency { get; set; }

    public virtual DbSet<vReceiptSumByCurrency> vReceiptSumByCurrency { get; set; }

    public virtual DbSet<vReceiptSumByCurrencyHasta20240905> vReceiptSumByCurrencyHasta20240905 { get; set; }

    public virtual DbSet<vReceiptValue> vReceiptValue { get; set; }

    public virtual DbSet<vReceiptValuePart> vReceiptValuePart { get; set; }

    public virtual DbSet<vRemito> vRemito { get; set; }

    public virtual DbSet<vRemitoTotal> vRemitoTotal { get; set; }

    public virtual DbSet<vRemitoTotal20210514> vRemitoTotal20210514 { get; set; }

    public virtual DbSet<vRemitoTotal20220826> vRemitoTotal20220826 { get; set; }

    public virtual DbSet<vRemitoTotal20220923> vRemitoTotal20220923 { get; set; }

    public virtual DbSet<vRemitoTotal20230529> vRemitoTotal20230529 { get; set; }

    public virtual DbSet<vRemitoTotalComisiones> vRemitoTotalComisiones { get; set; }

    public virtual DbSet<vRemitoTotalConSaleRetail> vRemitoTotalConSaleRetail { get; set; }

    public virtual DbSet<vRemitoTotalHAsta20220901> vRemitoTotalHAsta20220901 { get; set; }

    public virtual DbSet<vRemitoTotalOriginal> vRemitoTotalOriginal { get; set; }

    public virtual DbSet<vReportReceiptApplied> vReportReceiptApplied { get; set; }

    public virtual DbSet<vReportReceiptAppliedHasta20240823> vReportReceiptAppliedHasta20240823 { get; set; }

    public virtual DbSet<vReportRemitoTotal> vReportRemitoTotal { get; set; }

    public virtual DbSet<vReportRemitoTotal20220120> vReportRemitoTotal20220120 { get; set; }

    public virtual DbSet<vReportRemitoTotalFamiliaMes> vReportRemitoTotalFamiliaMes { get; set; }

    public virtual DbSet<vReportRemitoTotalSinProducto> vReportRemitoTotalSinProducto { get; set; }

    public virtual DbSet<vReporteClientesTarot> vReporteClientesTarot { get; set; }

    public virtual DbSet<vSaleDelivery> vSaleDelivery { get; set; }

    public virtual DbSet<vSaleDeliveryItem> vSaleDeliveryItem { get; set; }

    public virtual DbSet<vSaleDeliveryNote> vSaleDeliveryNote { get; set; }

    public virtual DbSet<vSaleDeliveryNoteItem> vSaleDeliveryNoteItem { get; set; }

    public virtual DbSet<vSaleDeliveryNoteTotal> vSaleDeliveryNoteTotal { get; set; }

    public virtual DbSet<vSaleOrderApprovalDate> vSaleOrderApprovalDate { get; set; }

    public virtual DbSet<vSaleOrderDetail> vSaleOrderDetail { get; set; }

    public virtual DbSet<vSaleOrderDetail20240827> vSaleOrderDetail20240827 { get; set; }

    public virtual DbSet<vSaleOrderDetailHasta20240411> vSaleOrderDetailHasta20240411 { get; set; }

    public virtual DbSet<vSaleOrderItem_SaleDeliveryItem> vSaleOrderItem_SaleDeliveryItem { get; set; }

    public virtual DbSet<vSaleOrderTask> vSaleOrderTask { get; set; }

    public virtual DbSet<vSaleOrderTaskApprovals> vSaleOrderTaskApprovals { get; set; }

    public virtual DbSet<vSaleOrderTraceability> vSaleOrderTraceability { get; set; }

    public virtual DbSet<vSaleRetail> vSaleRetail { get; set; }

    public virtual DbSet<vSaleRetailItem> vSaleRetailItem { get; set; }

    public virtual DbSet<vSaleRetailItemGrouped> vSaleRetailItemGrouped { get; set; }

    public virtual DbSet<vSaleRetailValue> vSaleRetailValue { get; set; }

    public virtual DbSet<vStockActual> vStockActual { get; set; }

    public virtual DbSet<vStockActualValorizado> vStockActualValorizado { get; set; }

    public virtual DbSet<vStockActualVenta> vStockActualVenta { get; set; }

    public virtual DbSet<vStockAnalysis> vStockAnalysis { get; set; }

    public virtual DbSet<vStockCostoyVenta> vStockCostoyVenta { get; set; }

    public virtual DbSet<vTask> vTask { get; set; }

    public virtual DbSet<vTaskApprovals> vTaskApprovals { get; set; }

    public virtual DbSet<vThirdParty> vThirdParty { get; set; }

    public virtual DbSet<vThirdPartyFulltex> vThirdPartyFulltex { get; set; }

    public virtual DbSet<vThirdPartyTarot> vThirdPartyTarot { get; set; }

    public virtual DbSet<vTotalSaleDeliveryItem> vTotalSaleDeliveryItem { get; set; }

    public virtual DbSet<vTripItemsReport> vTripItemsReport { get; set; }

    public virtual DbSet<vTripReport> vTripReport { get; set; }

    public virtual DbSet<vUnReadMessage> vUnReadMessage { get; set; }

    public virtual DbSet<vUserMenu> vUserMenu { get; set; }

    public virtual DbSet<vUserMenuItems> vUserMenuItems { get; set; }

    public virtual DbSet<vVendorPayment> vVendorPayment { get; set; }

    public virtual DbSet<vVendorPaymentSumByCurrency> vVendorPaymentSumByCurrency { get; set; }

    public virtual DbSet<vVentasTaffeta> vVentasTaffeta { get; set; }

    public virtual DbSet<vVoucher> vVoucher { get; set; }

    public virtual DbSet<vWithdrawalOrderItem> vWithdrawalOrderItem { get; set; }

    public virtual DbSet<xCobranzaPorVendorFecha> xCobranzaPorVendorFecha { get; set; }

    public virtual DbSet<xCobranzaPorVendorPeriodo> xCobranzaPorVendorPeriodo { get; set; }

    public virtual DbSet<xReceiptDataStudio> xReceiptDataStudio { get; set; }

    public virtual DbSet<xReportPackingListDataStudio> xReportPackingListDataStudio { get; set; }

    public virtual DbSet<xReportRemitoTotalDataStudio> xReportRemitoTotalDataStudio { get; set; }

    public virtual DbSet<xStockActualValorizado> xStockActualValorizado { get; set; }

    public virtual DbSet<xVentasCobranzaPorVendorFecha> xVentasCobranzaPorVendorFecha { get; set; }

    public virtual DbSet<xVentasCobranzaPorVendorPeriodo> xVentasCobranzaPorVendorPeriodo { get; set; }

    public virtual DbSet<xVentasPorVendorFecha> xVentasPorVendorFecha { get; set; }

    public virtual DbSet<xVentasPorVendorPeriodo> xVentasPorVendorPeriodo { get; set; }

    public virtual DbSet<zDelete> zDelete { get; set; }

    public virtual DbSet<zRV> zRV { get; set; }

    public virtual DbSet<zViejavPurchaseOrderTotal> zViejavPurchaseOrderTotal { get; set; }

    public virtual DbSet<zvDeliveryItemStatusReportORIG> zvDeliveryItemStatusReportORIG { get; set; }

    public virtual DbSet<zvDeliveryStatusReportORIG> zvDeliveryStatusReportORIG { get; set; }

    public virtual DbSet<zvItemNotaDeCredito20180326> zvItemNotaDeCredito20180326 { get; set; }

    public virtual DbSet<zvNotaDeCredito20180326> zvNotaDeCredito20180326 { get; set; }

    public virtual DbSet<zvRemito20210224> zvRemito20210224 { get; set; }

    public virtual DbSet<zvRemitoTotal20191108> zvRemitoTotal20191108 { get; set; }

    public virtual DbSet<zvReportRemitoTotal20210224> zvReportRemitoTotal20210224 { get; set; }

    public virtual DbSet<zvStockActual20201110> zvStockActual20201110 { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountPayable>(entity =>
        {
            entity.HasKey(e => e.AccountPayableID).HasName("PK_AccountPayable_1");

            entity.Property(e => e.AccountPayableNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.ChannelID).HasComment("B.U.");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.OpenAmount).HasComment("");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.TotalAmount).HasComment("");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.AccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayable_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.AccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayable_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayable_Currency");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.AccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayable_DocumentType");
        });

        modelBuilder.Entity<AccountReceivable>(entity =>
        {
            entity.Property(e => e.AccountReceivableNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.OpenAmount).HasComment("");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
            entity.Property(e => e.TotalAmount).HasComment("");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.AccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivable_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.AccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivable_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivable_Currency");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.AccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivable_DocumentType");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.AccountReceivable).HasConstraintName("FK_AccountReceivable_PaymentCondition");
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.Property(e => e.AuditType).IsFixedLength();
        });

        modelBuilder.Entity<AuditDetail>(entity =>
        {
            entity.HasOne(d => d.Audit).WithMany(p => p.AuditDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditDetail_Audit");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.Property(e => e.BankID).HasComment("Código");
            entity.Property(e => e.BankName).HasComment("Nombre");
        });

        modelBuilder.Entity<BatchPayment>(entity =>
        {
            entity.Property(e => e.BatchPaymentID).HasComment("ID");
            entity.Property(e => e.BatchPaymentCode).HasComment("Referencia");
            entity.Property(e => e.BatchPaymentDate).HasComment("Fecha");
            entity.Property(e => e.BatchPaymentNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.DistributorReceiptID).HasComment("DistributorReceiptID");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.ReceiptID).HasComment("ReceiptID");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.BatchPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchPayment_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.BatchPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchPayment_Channel");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.BatchPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchPayment_OrganizationUnit");
        });

        modelBuilder.Entity<BatchPaymentValue>(entity =>
        {
            entity.Property(e => e.BatchPaymentID).HasComment("ID");
            entity.Property(e => e.BatchPaymentValueNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.EndorsableCompanyID).HasComment("EndorsableCompanyID");
            entity.Property(e => e.EndorsableCustomerID).HasComment("EndorsableCustomerID");
            entity.Property(e => e.SourceReceiptID).HasComment("ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.BatchPaymentValue).HasConstraintName("FK_BatchPaymentValue_Bank");

            entity.HasOne(d => d.BatchPayment).WithMany(p => p.BatchPaymentValue).HasConstraintName("FK_BatchPaymentValue_BatchPayment");

            entity.HasOne(d => d.CheckStatus).WithMany(p => p.BatchPaymentValue).HasConstraintName("FK_BatchPaymentValue_CheckStatus");

            entity.HasOne(d => d.Currency).WithMany(p => p.BatchPaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchPaymentValue_Currency");

            entity.HasOne(d => d.EndorsableCompany).WithMany(p => p.BatchPaymentValue).HasConstraintName("FK_BatchPaymentValue_EndorsableCompany");

            entity.HasOne(d => d.EndorsableCustomer).WithMany(p => p.BatchPaymentValue).HasConstraintName("FK_BatchPaymentValue_EndorsableCustomer");

            entity.HasOne(d => d.ValueType).WithMany(p => p.BatchPaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchPaymentValue_ValueType");
        });

        modelBuilder.Entity<BusinessUnit>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.BusinessUnitName).HasComment("Nombre");
            entity.Property(e => e.BusinessUnitTypeID).HasComment("Tipo");

            entity.HasOne(d => d.BusinessUnitType).WithMany(p => p.BusinessUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BusinessUnit_BusinessUnitType");
        });

        modelBuilder.Entity<BusinessUnitType>(entity =>
        {
            entity.Property(e => e.BusinessUnitTypeID).HasComment("Código");
            entity.Property(e => e.BusinessUnitTypeName).HasComment("Nombre");
        });

        modelBuilder.Entity<Carrier>(entity =>
        {
            entity.Property(e => e.CarrierID).HasComment("Código");
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CarrierName).HasComment("Nombre");
            entity.Property(e => e.Phone).HasComment("Teléfono");
        });

        modelBuilder.Entity<CashDesk>(entity =>
        {
            entity.Property(e => e.CashDeskID).HasComment("U.O.");
            entity.Property(e => e.CalculatedCloseAmountARS).HasComment("Pesos Cierre Calculado");
            entity.Property(e => e.CalculatedCloseAmountUSD).HasComment("Dolares Cierre Calculado");
            entity.Property(e => e.CalculatedOpenAmountARS).HasComment("Pesos Apertura Calculado");
            entity.Property(e => e.CalculatedOpenAmountUSD).HasComment("Dolares Apertura Calculado");
            entity.Property(e => e.CashDeskDate).HasComment("Nombre");
            entity.Property(e => e.CashDeskStatus).IsFixedLength();
            entity.Property(e => e.CloseCurrencyRateAmount).HasComment("Cotización Dolar Cierre");
            entity.Property(e => e.OpenCurrencyRateAmount).HasComment("Cotización Dolar Apertura");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.RealCloseAmountARS).HasComment("Pesos Cierre Real");
            entity.Property(e => e.RealCloseAmountUSD).HasComment("Dolares Cierre Real");
            entity.Property(e => e.RealOpenAmountARS).HasComment("Pesos Apertura Real");
            entity.Property(e => e.RealOpenAmountUSD).HasComment("Dolares Apertura Real");
            entity.Property(e => e.Remarks).HasComment("Comentarios");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.CashDesk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashDesk_OrganizationUnit");
        });

        modelBuilder.Entity<CashDeskValueType>(entity =>
        {
            entity.Property(e => e.CashDeskID).HasComment("U.O.");
            entity.Property(e => e.ValueTypeID).HasComment("Código");
            entity.Property(e => e.CloseAmount).HasComment("Dolares Cierre Calculado");
            entity.Property(e => e.OpenAmount).HasComment("Dolares Apertura Calculado");

            entity.HasOne(d => d.CashDesk).WithMany(p => p.CashDeskValueType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashDeskValueType_CashDesk");

            entity.HasOne(d => d.ValueType).WithMany(p => p.CashDeskValueType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashDeskValueType_ValueType");
        });

        modelBuilder.Entity<Channel>(entity =>
        {
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.ChannelName).HasComment("ID");
        });

        modelBuilder.Entity<Check>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.EndorsableCompanyID).HasComment("EndorsableCompanyID");
            entity.Property(e => e.EndorsableCustomerID).HasComment("EndorsableCustomerID");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.ReceiptID).HasComment("ID");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SourceReceiptID).HasComment("ID");
            entity.Property(e => e.VendorPaymentID).HasComment("ID");

            entity.HasOne(d => d.BatchPaymentValue).WithMany(p => p.Check).HasConstraintName("FK_Check_BatchPaymentValue");

            entity.HasOne(d => d.Channel).WithMany(p => p.Check)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Check_Channel");
        });

        modelBuilder.Entity<CheckStatus>(entity =>
        {
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.CheckStatusName).HasComment("Nombre");
            entity.Property(e => e.StageCode).HasComment("Etapa");
        });

        modelBuilder.Entity<ChequesEnCartera>(entity =>
        {
            entity.ToView("ChequesEnCartera");
        });

        modelBuilder.Entity<CommissionCalculated>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CommissionAmount).HasComment("");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.DocumentAmount).HasComment("");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
        });

        modelBuilder.Entity<CommissionPayable>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CommissionPayableNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.OpenAmount).HasComment("");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
            entity.Property(e => e.TotalAmount).HasComment("");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.CommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommissionPayable_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.CommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommissionPayable_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.CommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommissionPayable_Currency");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.CommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommissionPayable_DocumentType");

            entity.HasOne(d => d.SaleRepresentative).WithMany(p => p.CommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommissionPayable_User");
        });

        modelBuilder.Entity<Concept>(entity =>
        {
            entity.HasKey(e => e.ConceptID).HasName("PK_SettlementConcept");

            entity.Property(e => e.ConceptID).HasComment("Código");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.AlicuotaIVA).HasComment("Alicuota IVA");
            entity.Property(e => e.BaseCostoContable).HasComment("BaseCostoContable");
            entity.Property(e => e.BaseCostoReal).HasComment("BaseCostoReal");
            entity.Property(e => e.ConceptCode).HasComment("Código");
            entity.Property(e => e.ConceptGroupID).HasComment("Código");
            entity.Property(e => e.ConceptName).HasComment("Nombre");
            entity.Property(e => e.Formula).HasComment("Fórmula");
            entity.Property(e => e.InputOutput)
                .IsFixedLength()
                .HasComment("InputOutput");
            entity.Property(e => e.PercepcionIIBBARBA).HasComment("Percepción IIBB ARBA");
            entity.Property(e => e.PercepcionIIBBCABA).HasComment("Percepción IIBB CABA");
            entity.Property(e => e.PercepcionIVA).HasComment("Percepcion IVA");
            entity.Property(e => e.RetencionGanancias).HasComment("Retencion Ganancias");

            entity.HasOne(d => d.ConceptGroup).WithMany(p => p.Concept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Concept_ConceptGroup");
        });

        modelBuilder.Entity<ConceptGroup>(entity =>
        {
            entity.Property(e => e.ConceptGroupID).HasComment("Código");
            entity.Property(e => e.ConceptGroupName).HasComment("Nombre");
        });

        modelBuilder.Entity<ContactSource>(entity =>
        {
            entity.Property(e => e.ContactSourceID).HasComment("Código");
            entity.Property(e => e.ContactSourceName).HasComment("Nombre");
        });

        modelBuilder.Entity<CountOrder>(entity =>
        {
            entity.Property(e => e.AssginedName).HasComment("Asignado A");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.CountOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.CountOrderStatusID).HasComment("Estado");
            entity.Property(e => e.ProductFamilyID).HasComment("Familia");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedDate).HasComment("Fecha");
            entity.Property(e => e.WarehouseID).HasComment("Deposito");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.CountOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountOrder_BusinessUnit");

            entity.HasOne(d => d.CountOrderStatus).WithMany(p => p.CountOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountOrder_CountOrderStatus");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.CountOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountOrder_ProductFamily");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.CountOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountOrder_Warehouse");
        });

        modelBuilder.Entity<CountOrderItem>(entity =>
        {
            entity.Property(e => e.Actual).HasComment("mts / kilos foto");
            entity.Property(e => e.ActualUnits).HasComment("Unidades Foto");
            entity.Property(e => e.AvailableUnits).HasComment("Unidades en Stock al momento de Grabar");
            entity.Property(e => e.Counted).HasComment("Cantidad contada");
            entity.Property(e => e.CountedUnits).HasComment("Unidades Contadas");
            entity.Property(e => e.ProductID).HasComment("Producto");

            entity.HasOne(d => d.CountOrder).WithMany(p => p.CountOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountOrderItem_CountOrder");

            entity.HasOne(d => d.Product).WithMany(p => p.CountOrderItem).HasConstraintName("FK_CountOrderItem_Product");
        });

        modelBuilder.Entity<CountOrderStatus>(entity =>
        {
            entity.Property(e => e.CountOrderStatusID).HasComment("Código");
            entity.Property(e => e.CountOrderStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<Counterfoil>(entity =>
        {
            entity.HasKey(e => e.CounterfoilID).HasName("PK_ShipmentCompany");

            entity.Property(e => e.CounterfoilID).HasComment("ID");
            entity.Property(e => e.CAICode).HasComment("CAI");
            entity.Property(e => e.CAIDueDate).HasComment("VTO CAI");
            entity.Property(e => e.MaxNumber).HasComment("N° Máximo");
            entity.Property(e => e.MinNumber).HasComment("N° Mínimo");
            entity.Property(e => e.PrinterPeriod).HasComment("Fecha Impresion");
            entity.Property(e => e.PrinterRange).HasComment("Impreso del X al Z");
        });

        modelBuilder.Entity<CreditNote>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CreditNoteDate).HasComment("Fecha");
            entity.Property(e => e.CreditNoteNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número NC");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.DocumentStatusID).HasComment("Estado");
            entity.Property(e => e.DocumentSubTypeID).HasComment("SubTipo Documento");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.OrganizationUnitID).HasComment("O. U.");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.ReceiptID).HasComment("ID");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.SubCustomerCurrencyID).HasComment("Moneda Subcliente");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.TotalAmount).HasComment("Monto Total");
            entity.Property(e => e.TotalCommissionAmount).HasComment("Monto Total Comisión");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_Customer");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_DocumentStatus");

            entity.HasOne(d => d.DocumentSubType).WithMany(p => p.CreditNote).HasConstraintName("FK_CreditNote_DocumentSubType");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_OrganizationUnit");

            entity.HasOne(d => d.Receipt).WithMany(p => p.CreditNote).HasConstraintName("FK_CreditNote_Receipt");
        });

        modelBuilder.Entity<CreditNoteItem>(entity =>
        {
            entity.Property(e => e.CommissionPercent).HasComment("% Comisión");
            entity.Property(e => e.CreditNoteItemNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Quantity).HasComment("Solicitado");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitOtherPrice).HasComment("Precio Sub Cliente");
            entity.Property(e => e.UnitPrice).HasComment("Precio");
            entity.Property(e => e.Units).HasComment("Solicitado");
            entity.Property(e => e.WarehousePositionID).HasComment("Ubicación");

            entity.HasOne(d => d.CreditNote).WithMany(p => p.CreditNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNoteItem_CreditNote");

            entity.HasOne(d => d.Product).WithMany(p => p.CreditNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNoteItem_Product");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.CreditNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNoteItem_UnitOfMeasure");

            entity.HasOne(d => d.WarehousePosition).WithMany(p => p.CreditNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNoteItem_WarehousePosition");
        });

        modelBuilder.Entity<CurrencyRate>(entity =>
        {
            entity.HasOne(d => d.Currency).WithMany(p => p.CurrencyRate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrencyRate_Currency");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerID).HasComment("Código");
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CarrierID).HasComment("Transportista");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.ContactName).HasComment("Contacto");
            entity.Property(e => e.CreditLimit).HasComment("Límite de Crédito");
            entity.Property(e => e.CrossReferenceCode).HasComment("IIBB");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerClassID).HasComment("Clase de Cliente");
            entity.Property(e => e.CustomerGroupID).HasComment("Grupo de Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.CustomerName).HasComment("Nombre Fantasía");
            entity.Property(e => e.CustomerNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Código Interno");
            entity.Property(e => e.CustomerTypeID).HasComment("Tipo de Cliente");
            entity.Property(e => e.DeliveryInstruction).HasComment("Entrega");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Multiplier).HasComment("Multiplicador");
            entity.Property(e => e.ParentCustomerID).HasComment("Código");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.PriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.SaleDistrictID).HasComment("Distrito de Ventas");
            entity.Property(e => e.SaleGroupID).HasComment("Grupo de Ventas");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.Carrier).WithMany(p => p.Customer).HasConstraintName("FK_Customer_Carrier");

            entity.HasOne(d => d.Channel).WithMany(p => p.Customer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.Customer).HasConstraintName("FK_Customer_Currency");

            entity.HasOne(d => d.CustomerClass).WithMany(p => p.Customer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_CustomerClass");

            entity.HasOne(d => d.CustomerGroup).WithMany(p => p.Customer).HasConstraintName("FK_Customer_CustomerGroup");

            entity.HasOne(d => d.CustomerType).WithMany(p => p.Customer).HasConstraintName("FK_Customer_CustomerType1");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.Customer).HasConstraintName("FK_Customer_DeliveryZone");

            entity.HasOne(d => d.FiscalCodeType).WithMany(p => p.Customer).HasConstraintName("FK_Customer_FiscalCodeType");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.Customer).HasConstraintName("FK_Customer_PaymentCondition");

            entity.HasOne(d => d.PriceList).WithMany(p => p.Customer).HasConstraintName("FK_Customer_PriceList");

            entity.HasOne(d => d.SaleDistrict).WithMany(p => p.Customer).HasConstraintName("FK_Customer_SaleDistrict");

            entity.HasOne(d => d.SaleGroup).WithMany(p => p.Customer).HasConstraintName("FK_Customer_SaleGroup");

            entity.HasOne(d => d.State).WithMany(p => p.Customer).HasConstraintName("FK_Customer_State");
        });

        modelBuilder.Entity<CustomerBusinessUnit>(entity =>
        {
            entity.Property(e => e.CustomerID).HasComment("Código");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SaleRepresentativeID).HasComment("User Id");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.CustomerBusinessUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerBusinessUnit_BusinessUnit");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerBusinessUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerBusinessUnit_Customer");

            entity.HasOne(d => d.SaleRepresentative).WithMany(p => p.CustomerBusinessUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerBusinessUnit_User");
        });

        modelBuilder.Entity<CustomerClass>(entity =>
        {
            entity.Property(e => e.CustomerClassID).HasComment("Código");
            entity.Property(e => e.CustomerClassName).HasComment("Nombre");
        });

        modelBuilder.Entity<CustomerDeliveryAddress>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerDeliveryAddress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerDeliveryAddress_Customer");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.CustomerDeliveryAddress).HasConstraintName("FK_CustomerDeliveryAddress_DeliveryZone");

            entity.HasOne(d => d.FiscalCodeType).WithMany(p => p.CustomerDeliveryAddress).HasConstraintName("FK_CustomerDeliveryAddress_FiscalCodeType");

            entity.HasOne(d => d.State).WithMany(p => p.CustomerDeliveryAddress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerDeliveryAddress_State");
        });

        modelBuilder.Entity<CustomerGroup>(entity =>
        {
            entity.Property(e => e.CustomerGroupID).HasComment("Código");
            entity.Property(e => e.CustomerGroupName).HasComment("Nombre");
        });

        modelBuilder.Entity<CustomerType>(entity =>
        {
            entity.Property(e => e.CustomerTypeID).HasComment("Código");
            entity.Property(e => e.CustomerTypeName).HasComment("Nombre");
        });

        modelBuilder.Entity<DebitNote>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.DebitAmount).HasComment("Monto");
            entity.Property(e => e.DebitNoteDate).HasComment("Fecha");
            entity.Property(e => e.DebitNoteNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número NC");
            entity.Property(e => e.DocumentStatusID).HasComment("Estado");
            entity.Property(e => e.DocumentSubTypeID).HasComment("SubTipo Documento");
            entity.Property(e => e.ExpenseAmount).HasComment("Gastos");
            entity.Property(e => e.OrganizationUnitID).HasComment("O.U.");
            entity.Property(e => e.ReceiptID).HasComment("ID");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
            entity.Property(e => e.TotalAmount).HasComment("Monto Total");
            entity.Property(e => e.TotalCommissionAmount).HasComment("Monto Total Comisión");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_Customer");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_DocumentStatus");

            entity.HasOne(d => d.DocumentSubType).WithMany(p => p.DebitNote).HasConstraintName("FK_DebitNote_DocumentSubType");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.DebitNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNote_OrganizationUnit");

            entity.HasOne(d => d.Receipt).WithMany(p => p.DebitNote).HasConstraintName("FK_DebitNote_Receipt");

            entity.HasOne(d => d.SaleRepresentative).WithMany(p => p.DebitNote).HasConstraintName("FK_DebitNote_User");
        });

        modelBuilder.Entity<DebitNoteCheck>(entity =>
        {
            entity.Property(e => e.CheckStatusID).HasComment("Código");

            entity.HasOne(d => d.Check).WithMany(p => p.DebitNoteCheck)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCheck_Check");

            entity.HasOne(d => d.CheckStatus).WithMany(p => p.DebitNoteCheck).HasConstraintName("FK_DebitNoteCheck_CheckStatus");

            entity.HasOne(d => d.DebitNote).WithMany(p => p.DebitNoteCheck)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCheck_DebitNote");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.DocumentDate).HasComment("Fecha");
            entity.Property(e => e.DocumentNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número NC");
            entity.Property(e => e.DocumentStatusID).HasComment("Estado");
            entity.Property(e => e.DocumentTypeID).HasComment("Código");
            entity.Property(e => e.EntityID).HasComment("Cliente");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.TotalAmount).HasComment("Monto Total");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.Document)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.Document)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.Document)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Currency");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.Document)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_DocumentStatus");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.Document)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_DocumentType");
        });

        modelBuilder.Entity<DocumentClass>(entity =>
        {
            entity.Property(e => e.DocumentClassID).HasComment("Código");
            entity.Property(e => e.DocumentClassName).HasComment("Nombre");
        });

        modelBuilder.Entity<DocumentStatus>(entity =>
        {
            entity.Property(e => e.DocumentStatusID).HasComment("Código");
            entity.Property(e => e.DocumentStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<DocumentSubType>(entity =>
        {
            entity.Property(e => e.DocumentSubTypeID).HasComment("Código");
            entity.Property(e => e.DocumentSubTypeName).HasComment("Nombre");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.DocumentSubType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentSubType_DocumentType");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.Property(e => e.DocumentTypeID).HasComment("Código");
            entity.Property(e => e.DebitCredit)
                .IsFixedLength()
                .HasComment("Débito/Crédito");
            entity.Property(e => e.DocumentClassID).HasComment("Clase");
            entity.Property(e => e.DocumentTypeName).HasComment("Nombre");

            entity.HasOne(d => d.DocumentClass).WithMany(p => p.DocumentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentType_DocumentClass");
        });

        modelBuilder.Entity<Endorsable>(entity =>
        {
            entity.Property(e => e.EndorsableID).HasComment("ID");
            entity.Property(e => e.EndorsableName).HasComment("Nombre");
        });

        modelBuilder.Entity<EndorsableCompany>(entity =>
        {
            entity.Property(e => e.EndorsableCompanyID).HasComment("ID");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.Address).HasComment("Domicilio");
            entity.Property(e => e.EndorsableCompanyName).HasComment("Nombre");
            entity.Property(e => e.TaxCode).HasComment("CUIT");
        });

        modelBuilder.Entity<EndorsableCustomer>(entity =>
        {
            entity.Property(e => e.EndorsableCustomerID).HasComment("ID");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.Address).HasComment("Domicilio");
            entity.Property(e => e.EndorsableCustomerName).HasComment("Nombre");
            entity.Property(e => e.TaxCode).HasComment("CUIT");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.Property(e => e.EventID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ExpenseSubType>(entity =>
        {
            entity.Property(e => e.ExpenseSubTypeID).HasComment("Código");
            entity.Property(e => e.ExpenseSubTypeName).HasComment("Nombre");
            entity.Property(e => e.ExpenseTypeID).HasComment("Tipo Gasto");

            entity.HasOne(d => d.ExpenseType).WithMany(p => p.ExpenseSubType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseSubType_ExpenseType");
        });

        modelBuilder.Entity<ExpenseType>(entity =>
        {
            entity.Property(e => e.ExpenseTypeID).HasComment("Código");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.DebitCredit)
                .IsFixedLength()
                .HasComment("Tipo");
            entity.Property(e => e.ExpenseTypeName).HasComment("Nombre");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.ExpenseType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseType_BusinessUnit");
        });

        modelBuilder.Entity<FileType>(entity =>
        {
            entity.Property(e => e.FileTypeID).HasComment("Código");
            entity.Property(e => e.FileTypeName).HasComment("Nombre");
        });

        modelBuilder.Entity<FiscalCodeType>(entity =>
        {
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Código");
            entity.Property(e => e.FiscalCodeTypeName).HasComment("Nombre");
        });

        modelBuilder.Entity<Freight>(entity =>
        {
            entity.Property(e => e.Active).HasComment("Activo");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.Property(e => e.BatchName).HasComment("Lote");
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ExpirationDate).HasComment("Fecha VTO");
            entity.Property(e => e.HardCommitted).HasComment("Picking");
            entity.Property(e => e.HardCommittedUnits).HasComment("Picking");
            entity.Property(e => e.InventoryNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductionDate).HasComment("Fecha Producción");
            entity.Property(e => e.SafetyStock).HasComment("Stock de seguridad");
            entity.Property(e => e.SafetyStockUnits).HasComment("Stock de seguridad");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.Inventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_BusinessUnit");

            entity.HasOne(d => d.Product).WithMany(p => p.Inventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Product");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Inventory).HasConstraintName("FK_Inventory_Warehouse");

            entity.HasOne(d => d.WarehousePosition).WithMany(p => p.Inventory).HasConstraintName("FK_Inventory_WarehousePosition");
        });

        modelBuilder.Entity<InventoryBarCode>(entity =>
        {
            entity.Property(e => e.InventoryBarCodeID).HasComment("ID");
            entity.Property(e => e.DocumentID).HasComment("Documento");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.InventoryBarCodeStatusID).HasComment("Estado");
            entity.Property(e => e.LabelCode).HasComment("Etiqueta");
            entity.Property(e => e.OrganizationUnitID).HasComment("OU");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Quantity).HasComment("Cantidad");

            entity.HasOne(d => d.InventoryBarCodeStatus).WithMany(p => p.InventoryBarCode).HasConstraintName("FK_InventoryBarCode_InventoryBarCodeStatus");

            entity.HasOne(d => d.Product).WithMany(p => p.InventoryBarCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryBarCode_Product");
        });

        modelBuilder.Entity<InventoryMovement>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.HardCommitted).HasComment("Picking");
            entity.Property(e => e.HardCommittedUnits).HasComment("Picking");
        });

        modelBuilder.Entity<InventoryTransfer>(entity =>
        {
            entity.Property(e => e.InventoryTransferID).HasComment("ID");
            entity.Property(e => e.DestinationBusinessUnitID).HasComment("B.U. Destino");
            entity.Property(e => e.DestinationInventoryStatus).HasComment("Estado Destino");
            entity.Property(e => e.DestinationWarehousePositionID).HasComment("Posición Destino");
            entity.Property(e => e.InventoryTransferDate).HasComputedColumnSql("(CONVERT([date],[createdOn]))", false);
            entity.Property(e => e.InventoryTransferNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.InventoryTransferTypeID).HasComment("Código");
            entity.Property(e => e.InventoyTransferName).HasComment("Descripción");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Quantity).HasComment("Cantidad");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U. Origen");
            entity.Property(e => e.SourceInventoryStatus).HasComment("Estado Origen");
            entity.Property(e => e.SourceWarehousePositionID).HasComment("Posición Origen");
            entity.Property(e => e.Units).HasComment("Bultos");

            entity.HasOne(d => d.InventoryTransferType).WithMany(p => p.InventoryTransfer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransfer_InventoryTransferType");

            entity.HasOne(d => d.Product).WithMany(p => p.InventoryTransfer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransfer_Product");
        });

        modelBuilder.Entity<InventoryTransferType>(entity =>
        {
            entity.Property(e => e.InventoryTransferTypeID).HasComment("Código");
            entity.Property(e => e.InventoryTransferTypeName).HasComment("Nombre");
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.HasKey(e => e.JournalID).HasName("PK_Jounal");

            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.DocumentTypeID).HasComment("Tipo Documento");
            entity.Property(e => e.ExpenseSubTypeID).HasComment("Sub Concepto");
            entity.Property(e => e.ExpenseTypeID).HasComment("Concepto");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.ThirdPartyID).HasComment("Entidad");
            entity.Property(e => e.ValueCount).HasComment("Cantidad de Valores");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_Currency");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_DocumentType");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_OrganizationUnit");

            entity.HasOne(d => d.ValueType).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_ValueType");
        });

        modelBuilder.Entity<LabelType>(entity =>
        {
            entity.Property(e => e.LabelTypeID).HasComment("Canal");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.LabelTypeName).HasComment("ID");
        });

        modelBuilder.Entity<MemberType>(entity =>
        {
            entity.HasKey(e => e.MemberTypeID).HasName("PK__MemberTy__5D8AFD7F5B55346F");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.Property(e => e.MenuItemID).HasComment("ID");
            entity.Property(e => e.ControllerName).HasComment("ControllerName");
            entity.Property(e => e.DisplayOrder).HasComment("Orden");
            entity.Property(e => e.IsPage).HasComment("Es Página");
            entity.Property(e => e.MenuBarID).HasComment("Menu");
            entity.Property(e => e.MenuItemName).HasComment("Nombre");
            entity.Property(e => e.RouteName).HasComment("RouteName");
            entity.Property(e => e.TemplateUrl).HasComment("TemplateUrl");

            entity.HasOne(d => d.MenuBar).WithMany(p => p.MenuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuItem_MenuBar");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageID).HasName("PK__Message__C87C037CAD006300");

            entity.Property(e => e.UserID).HasComment("Sender");

            entity.HasOne(d => d.MessageGroup).WithMany(p => p.Message)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Message_MessageGroup");

            entity.HasOne(d => d.MessageStatus).WithMany(p => p.Message)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Message_MessageStatus");

            entity.HasOne(d => d.User).WithMany(p => p.Message)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Message_User");
        });

        modelBuilder.Entity<MessageCategory>(entity =>
        {
            entity.HasKey(e => e.MessageCategoryID).HasName("PK_UserMessageCategory");
        });

        modelBuilder.Entity<MessageGroup>(entity =>
        {
            entity.HasKey(e => e.MessageGroupID).HasName("PK__MessageG__B4A8F320ABADBA24");
        });

        modelBuilder.Entity<MessageGroupUser>(entity =>
        {
            entity.HasKey(e => new { e.MessageGroupID, e.UserID }).HasName("PK__MessageG__65D07FEAF16C3A69");

            entity.HasOne(d => d.MemberType).WithMany(p => p.MessageGroupUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageGroupUser_MemberType");

            entity.HasOne(d => d.MessageGroup).WithMany(p => p.MessageGroupUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageGroupUser_MessageGroup");

            entity.HasOne(d => d.User).WithMany(p => p.MessageGroupUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageGroupUser_User");
        });

        modelBuilder.Entity<MessageStatus>(entity =>
        {
            entity.HasKey(e => e.MessageStatusID).HasName("PK__MessageS__8FBEE6F49ECF0703");
        });

        modelBuilder.Entity<MessageUser>(entity =>
        {
            entity.HasKey(e => new { e.MessageID, e.UserID }).HasName("PK__MessageU__19048FB6787C4786");

            entity.HasOne(d => d.MessageCategory).WithMany(p => p.MessageUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageUser_MessageCategory");

            entity.HasOne(d => d.User).WithMany(p => p.MessageUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageUser_User");
        });

        modelBuilder.Entity<MoveOrder>(entity =>
        {
            entity.Property(e => e.MoveOrderID).HasComment("ID");
            entity.Property(e => e.DestinationOrganizationUnitID).HasComment("Contacto");
            entity.Property(e => e.MoveOrderDate).HasComment("Fecha");
            entity.Property(e => e.MoveOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.MoveOrderStatusID).HasComment("Código");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SourceOrganizationUnitID).HasComment("Sucursal");

            entity.HasOne(d => d.MoveOrderStatus).WithMany(p => p.MoveOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MoveOrder_MoveOrderStatus");
        });

        modelBuilder.Entity<MoveOrderItem>(entity =>
        {
            entity.HasKey(e => e.MoveOrderItemID).HasName("PK_MoverOrderItem");

            entity.Property(e => e.InventoryBarCodeID).HasComment("Etiqueta");
            entity.Property(e => e.MoveOrderID).HasComment("ID");
            entity.Property(e => e.Quantity).HasComment("Cantidad");
            entity.Property(e => e.Remarks).HasComment("Comentarios");

            entity.HasOne(d => d.MoveOrder).WithMany(p => p.MoveOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MoverOrderItem_MoveOrder");
        });

        modelBuilder.Entity<MoveOrderStatus>(entity =>
        {
            entity.Property(e => e.MoveOrderStatusID).HasComment("Código");
            entity.Property(e => e.MoveOrderStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<OrganizationUnit>(entity =>
        {
            entity.Property(e => e.OrganizationUnitID).HasComment("Código");
            entity.Property(e => e.OrganizationUnitName).HasComment("Nombre");
        });

        modelBuilder.Entity<OrganizationUnitContact>(entity =>
        {
            entity.HasIndex(e => e.TaxCode, "UQ_OrganizationUnitCOntact_TaxCOde")
                .IsUnique()
                .HasFilter("([TaxCode] IS NOT NULL AND [TaxCode]<>'')");

            entity.HasIndex(e => e.DocumentNumber, "UQ_OrganizationUnitContact_DocumentNumber")
                .IsUnique()
                .HasFilter("([DocumentNumber] IS NOT NULL AND [DocumentNumber]<>'')");

            entity.Property(e => e.OrganizationUnitContactID).HasComment("Código");
            entity.Property(e => e.Address).HasComment("Direccion");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.OrganizationUnitContactName).HasComment("Nombre");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.Phone).HasComment("Telefono");

            entity.HasOne(d => d.ContactSource).WithMany(p => p.OrganizationUnitContact).HasConstraintName("FK_OrganizationUnitContact_ContactSource");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.OrganizationUnitContact)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnitContact_OrganizationUnit");
        });

        modelBuilder.Entity<PaymentCondition>(entity =>
        {
            entity.Property(e => e.PaymentConditionID).HasComment("Código");
            entity.Property(e => e.Days).HasComment("Días");
            entity.Property(e => e.PaymentConditionName).HasComment("Nombre");
        });

        modelBuilder.Entity<PaymentDeclare>(entity =>
        {
            entity.Property(e => e.PaymentDeclareID).HasComment("Código");
            entity.Property(e => e.OrganizationUnitID).HasComment("O. U.");
            entity.Property(e => e.PaymentDeclareCommissionAmount).HasComment("Comisión");
            entity.Property(e => e.PaymentDeclareDate).HasComment("Fecha");
            entity.Property(e => e.PaymentDeclareTotalAmount).HasComment("Monto");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.ValueTypeID).HasComment("Tipo Valor");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.PaymentDeclare).HasConstraintName("FK_PaymentDeclare_OrganizationUnit");

            entity.HasOne(d => d.ValueType).WithMany(p => p.PaymentDeclare)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentDeclare_ValueType");
        });

        modelBuilder.Entity<PickingOrder>(entity =>
        {
            entity.Property(e => e.PickingOrderNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.PickingStatusID).HasComment("Código");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.WarehouseID).HasComment("Dock de carga");

            entity.HasOne(d => d.PickingStatus).WithMany(p => p.PickingOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickingOrder_PickingStatus");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.PickingOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickingOrder_SaleOrder");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.PickingOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickingOrder_Warehouse");
        });

        modelBuilder.Entity<PickingOrderItem>(entity =>
        {
            entity.Property(e => e.PickingQuantity).HasComment("Solicitado");
            entity.Property(e => e.PickingUnits).HasComment("Solicitado");

            entity.HasOne(d => d.PickingOrder).WithMany(p => p.PickingOrderItem).HasConstraintName("FK_PickingOrderItem_PickingOrder");

            entity.HasOne(d => d.SaleOrderItem).WithMany(p => p.PickingOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickingOrderItem_SaleOrderItem");
        });

        modelBuilder.Entity<PickingStatus>(entity =>
        {
            entity.Property(e => e.PickingStatusID).HasComment("Código");
            entity.Property(e => e.PickingStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<PriceList>(entity =>
        {
            entity.Property(e => e.PriceListID).HasComment("Código");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.PriceListName).HasComment("Nombre");
        });

        modelBuilder.Entity<PriceListProduct>(entity =>
        {
            entity.Property(e => e.PriceListID).HasComment("Código");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");

            entity.HasOne(d => d.Currency).WithMany(p => p.PriceListProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProduct_Currency");

            entity.HasOne(d => d.PriceList).WithMany(p => p.PriceListProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProduct_PriceList");

            entity.HasOne(d => d.Product).WithMany(p => p.PriceListProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProduct_Product");
        });

        modelBuilder.Entity<PriceListProductFamily>(entity =>
        {
            entity.Property(e => e.PriceListID).HasComment("Código");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");

            entity.HasOne(d => d.Currency).WithMany(p => p.PriceListProductFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProductFamily_Currency");

            entity.HasOne(d => d.PriceList).WithMany(p => p.PriceListProductFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProductFamily_PriceList");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.PriceListProductFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListProductFamily_ProductFamily");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.DefaultInputProductStatusID).HasComment("Estado de Ingreso");
            entity.Property(e => e.ProductBrandID).HasComment("Marca");
            entity.Property(e => e.ProductClassID).HasComment("Clase");
            entity.Property(e => e.ProductCode).HasComment("Código");
            entity.Property(e => e.ProductConditionID).HasComment("Condición");
            entity.Property(e => e.ProductFamilyID).HasComment("Familia");
            entity.Property(e => e.ProductName).HasComment("Nombre");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");

            entity.HasOne(d => d.DefaultInputProductStatus).WithMany(p => p.Product).HasConstraintName("FK_Product_ProductStatus");

            entity.HasOne(d => d.File).WithMany(p => p.Product).HasConstraintName("FK_Product_File");

            entity.HasOne(d => d.ProductBrand).WithMany(p => p.Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductBrand");

            entity.HasOne(d => d.ProductClass).WithMany(p => p.Product).HasConstraintName("FK_Product_ProductClass");

            entity.HasOne(d => d.ProductCondition).WithMany(p => p.Product).HasConstraintName("FK_Product_ProductCondition");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.Product).HasConstraintName("FK_Product_ProductFamily1");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.Product).HasConstraintName("FK_Product_UnitOfMeasure");
        });

        modelBuilder.Entity<ProductBOM>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.ProductBOM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBOM_Product");
        });

        modelBuilder.Entity<ProductBrand>(entity =>
        {
            entity.HasOne(d => d.Manufacturer).WithMany(p => p.ProductBrand)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBrand_Manufacturer");
        });

        modelBuilder.Entity<ProductBusinessUnit>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.ProductBusinessUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBusinessUnit_BusinessUnit");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductBusinessUnit).HasConstraintName("FK_ProductBusinessUnit_Product");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasOne(d => d.File).WithMany(p => p.ProductCategory).HasConstraintName("FK_ProductCategory_File");
        });

        modelBuilder.Entity<ProductClass>(entity =>
        {
            entity.Property(e => e.ProductClassID).HasComment("ID");
            entity.Property(e => e.ProductClassName).HasComment("Nombre");
        });

        modelBuilder.Entity<ProductCondition>(entity =>
        {
            entity.Property(e => e.ProductConditionID).HasComment("ID");
            entity.Property(e => e.ProductConditionName).HasComment("Nombre");
        });

        modelBuilder.Entity<ProductCustomDelivery>(entity =>
        {
            entity.ToView("ProductCustomDelivery");
        });

        modelBuilder.Entity<ProductFamily>(entity =>
        {
            entity.HasOne(d => d.ProductCategory).WithMany(p => p.ProductFamily).HasConstraintName("FK_ProductFamily_ProductCategory");

            entity.HasOne(d => d.ProductComposition).WithMany(p => p.ProductFamily).HasConstraintName("FK_ProductFamily_ProductComposition");

            entity.HasOne(d => d.ProductGroup).WithMany(p => p.ProductFamily).HasConstraintName("FK_ProductFamily_ProductGroup");

            entity.HasOne(d => d.ProductSeasonality).WithMany(p => p.ProductFamily).HasConstraintName("FK_ProductFamily_ProductSeasonality");

            entity.HasOne(d => d.ProductType).WithMany(p => p.ProductFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFamily_ProductType");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.ProductFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFamily_UnitOfMeasure");
        });

        modelBuilder.Entity<ProductFamilyCustomDeliveryCode>(entity =>
        {
            entity.Property(e => e.ProductFamilyCustomDeliveryCodeID).HasComment("Familia");
            entity.Property(e => e.CustomDeliveryCode).HasComment("Despacho");
            entity.Property(e => e.LabelTypeID).HasComment("Canal");
            entity.Property(e => e.ProductFamilyID).HasComment("Familia");

            entity.HasOne(d => d.LabelType).WithMany(p => p.ProductFamilyCustomDeliveryCode).HasConstraintName("FK_ProductFamilyCustomDeliveryCode_LabelType");

            entity.HasOne(d => d.ProductFamily).WithOne(p => p.ProductFamilyCustomDeliveryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFamilyCustomDeliveryCode_ProductFamily");
        });

        modelBuilder.Entity<ProductFamilyUnitOfMeasureConversion>(entity =>
        {
            entity.HasOne(d => d.ProductFamily).WithMany(p => p.ProductFamilyUnitOfMeasureConversion).HasConstraintName("FK_ProductFamilyUnitOfMeasureConversion_ProductFamily");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.ProductFamilyUnitOfMeasureConversion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFamilyUnitOfMeasureConversion_UnitOfMeasure");
        });

        modelBuilder.Entity<ProductStatus>(entity =>
        {
            entity.Property(e => e.ProductStatusID).HasComment("ID");
            entity.Property(e => e.ProductStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.Property(e => e.TagID).HasComment("User Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTag_Product");

            entity.HasOne(d => d.Tag).WithMany(p => p.ProductTag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTag_Tag");
        });

        modelBuilder.Entity<ProductUnitOfMeasureConversion>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.ProductUnitOfMeasureConversion).HasConstraintName("FK_ProductUnitOfMeasureConversion_Product");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.ProductUnitOfMeasureConversion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductUnitOfMeasureConversion_UnitOfMeasure");
        });

        modelBuilder.Entity<Production>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.Production)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Production_Product");

            entity.HasOne(d => d.ProductionStatus).WithMany(p => p.Production)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Production_ProductionStatus");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Production)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Production_Warehouse");
        });

        modelBuilder.Entity<PurchaseDelivery>(entity =>
        {
            entity.Property(e => e.ArrivalDate).HasComment("Fecha Arribo");
            entity.Property(e => e.CustomDeliveryCode).HasComment("Despacho de Aduana");
            entity.Property(e => e.DeliveryDate).HasComment("Fecha Entrega / Disponible");
            entity.Property(e => e.ForwarderCode).HasComment("DL Ref");
            entity.Property(e => e.PurchaseDeliveryDescription).HasComment("Descripción");
            entity.Property(e => e.PurchaseDeliveryName).HasComment("Nombre Contenedor\r\nNombre Contenedor");
            entity.Property(e => e.PurchaseDeliveryNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Nro Contenedor");
            entity.Property(e => e.PurchaseDeliveryStatusID).HasComment("Estado");
            entity.Property(e => e.PurchaseOrderID).HasComment("Orden de Compra");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SealCode).HasComment("SEAL");
            entity.Property(e => e.ShipmentDate).HasComment("Fecha Embarque");

            entity.HasOne(d => d.PurchaseDeliveryStatus).WithMany(p => p.PurchaseDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseDelivery_PurchaseDeliveryStatus");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseDelivery_PurchaseOrder");
        });

        modelBuilder.Entity<PurchaseDeliveryDetail>(entity =>
        {
            entity.Property(e => e.AlicuotaGanancias).HasComment("AlicuotaGanancias");
            entity.Property(e => e.AlicuotaIVA).HasComment("AlicuotaIVA");
            entity.Property(e => e.AlicuotaIVAAdicional).HasComment("AlicuotaIVAAdicional");
            entity.Property(e => e.DeliveredQuantity).HasComment("Enviado");
            entity.Property(e => e.DeliveredUnits).HasComment("Unidades Enviadas");
            entity.Property(e => e.Formula).HasComment("Fórmula");
            entity.Property(e => e.RealDeliveredQuantity).HasComment("Cantidad Real");
            entity.Property(e => e.RealDeliveredUnits).HasComment("Unidades Real");
            entity.Property(e => e.RealUnitFOBPrice).HasComment("Precio FOB Unitario Real");
            entity.Property(e => e.RightsPercent).HasComment("% Derechos");
            entity.Property(e => e.StatisticsPercent).HasComment("% Estadísticas");
            entity.Property(e => e.UnitFOBPrice).HasComment("Precio FOB Unitario");
            entity.Property(e => e.UnitPriceContable).HasComment("Precio Venta Contable");

            entity.HasOne(d => d.PurchaseDelivery).WithMany(p => p.PurchaseDeliveryDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseDeliveryDetail_PurchaseDelivery");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.PurchaseDeliveryDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseDeliveryDetail_UnitOfMeasure");
        });

        modelBuilder.Entity<PurchaseDeliveryItem>(entity =>
        {
            entity.Property(e => e.DeliveredQuantity).HasComment("Enviado");
            entity.Property(e => e.DeliveredUnits).HasComment("Unidades Enviadas");
            entity.Property(e => e.Remarks).HasComment("Comentarios");

            entity.HasOne(d => d.PurchaseDelivery).WithMany(p => p.PurchaseDeliveryItem).HasConstraintName("FK_PurchaseDeliveryItem_PurchaseDelivery");

            entity.HasOne(d => d.PurchaseOrderItem).WithMany(p => p.PurchaseDeliveryItem).HasConstraintName("FK_PurchaseDeliveryItem_PurchaseOrderItem");
        });

        modelBuilder.Entity<PurchaseDeliverySettlement>(entity =>
        {
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.AlicuotaIVA).HasComment("Alicuota IVA");
            entity.Property(e => e.BaseCostoContable).HasComment("BaseCostoContable");
            entity.Property(e => e.BaseCostoReal).HasComment("BaseCostoReal");
            entity.Property(e => e.ConceptCode).HasComment("Nombre");
            entity.Property(e => e.ConceptGroupID).HasComment("Código");
            entity.Property(e => e.ConceptID).HasComment("Código");
            entity.Property(e => e.ConceptName).HasComment("Nombre");
            entity.Property(e => e.Formula).HasComment("Fórmula");
            entity.Property(e => e.InputOutput)
                .IsFixedLength()
                .HasComment("InputOutput");
            entity.Property(e => e.PercepcionIIBBARBA).HasComment("Percepción IIBB ARBA");
            entity.Property(e => e.PercepcionIIBBCABA).HasComment("Percepción IIBB CABA");
            entity.Property(e => e.PercepcionIVA).HasComment("Percepcion IVA");
            entity.Property(e => e.RetencionGanancias).HasComment("Retencion Ganancias");

            entity.HasOne(d => d.PurchaseDelivery).WithMany(p => p.PurchaseDeliverySettlement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseDeliverySettlement_PurchaseDelivery");
        });

        modelBuilder.Entity<PurchaseInvoice>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.DocumentStatusID).HasComment("Estado");
            entity.Property(e => e.PaymentConditionID).HasComment("Código");
            entity.Property(e => e.PurchaseInvoiceCode).HasComment("Referencia");
            entity.Property(e => e.PurchaseInvoiceDate).HasComment("Fecha");
            entity.Property(e => e.PurchaseInvoiceNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número Factura");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.TotalAmount).HasComment("Monto Total");
            entity.Property(e => e.VendorID).HasComment("Proveedor");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.PurchaseInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_BusinessUnit");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchaseInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_Currency");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.PurchaseInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_DocumentStatus");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.PurchaseInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_PaymentCondition");

            entity.HasOne(d => d.Vendor).WithMany(p => p.PurchaseInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_Vendor");
        });

        modelBuilder.Entity<PurchaseInvoicePurchaseReception>(entity =>
        {
            entity.HasOne(d => d.PurchaseInvoice).WithMany(p => p.PurchaseInvoicePurchaseReception)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoicePurchaseReception_PurchaseInvoice");

            entity.HasOne(d => d.PurchaseReception).WithMany(p => p.PurchaseInvoicePurchaseReception)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoicePurchaseReception_PurchaseReception");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.Property(e => e.ArrivalDate).HasComment("Fecha");
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.PurchaseOrderName).HasComment("Nombre");
            entity.Property(e => e.PurchaseOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Orden de Compra");
            entity.Property(e => e.PurchaseOrderStatusID).HasComment("Estado");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedDate).HasComment("Fecha");
            entity.Property(e => e.SeasonID).HasComment("Temporada");
            entity.Property(e => e.VendorID).HasComment("Proveedor");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.PurchaseOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_BusinessUnit");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchaseOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Currency");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.PurchaseOrder).HasConstraintName("FK_PurchaseOrder_Manufacturer");

            entity.HasOne(d => d.PurchaseOrderStatus).WithMany(p => p.PurchaseOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_PurchaseOrderStatus");

            entity.HasOne(d => d.Season).WithMany(p => p.PurchaseOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Season");

            entity.HasOne(d => d.Vendor).WithMany(p => p.PurchaseOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Vendor");
        });

        modelBuilder.Entity<PurchaseOrderItem>(entity =>
        {
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.PurchaseOrderItemNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedQuantity).HasComment("Solicitado");
            entity.Property(e => e.RequestedUnits).HasComment("Solicitado");
            entity.Property(e => e.UnitFOBPrice).HasComment("Precio FOB Unitario");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");

            entity.HasOne(d => d.Product).WithMany(p => p.PurchaseOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderItem_Product");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderItem).HasConstraintName("FK_PurchaseOrderItem_PurchaseOrder");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.PurchaseOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderItem_UnitOfMeasure");
        });

        modelBuilder.Entity<PurchaseOrderStatus>(entity =>
        {
            entity.Property(e => e.PurchaseOrderStatusID).HasComment("Código");
            entity.Property(e => e.PurchaseOrderStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<PurchaseReception>(entity =>
        {
            entity.Property(e => e.CustomDeliveryCode).HasComment("Despacho de Aduana");
            entity.Property(e => e.PurchaseDeliveryID).HasComment("Envío");
            entity.Property(e => e.PurchaseOrderID).HasComment("Orden de Compra");
            entity.Property(e => e.PurchaseReceptionName).HasComment("Nombre");
            entity.Property(e => e.PurchaseReceptionNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Nro Contenedor");
            entity.Property(e => e.Remarks).HasComment("Comentarios");

            entity.HasOne(d => d.LabelType).WithMany(p => p.PurchaseReception).HasConstraintName("FK_PurchaseReception_LabelType");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.PurchaseReception).HasConstraintName("FK_PurchaseReception_Manufacturer");

            entity.HasOne(d => d.PurchaseDelivery).WithMany(p => p.PurchaseReception).HasConstraintName("FK_PurchaseReception_PurchaseDelivery");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseReception)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReception_PurchaseOrder");

            entity.HasOne(d => d.PurchaseReceptionStatus).WithMany(p => p.PurchaseReception)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReception_PurchaseReceptionStatus");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.PurchaseReception)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReception_Warehouse");
        });

        modelBuilder.Entity<PurchaseReceptionItem>(entity =>
        {
            entity.Property(e => e.BatchName).HasComment("Lote");
            entity.Property(e => e.ExpirationDate).HasComment("Fecha VTO");
            entity.Property(e => e.OpenQuantity).HasComment("ABierto");
            entity.Property(e => e.ProductStatusID).HasComment("ID");
            entity.Property(e => e.ProductionDate).HasComment("Fecha Producción");
            entity.Property(e => e.ReceivedQuantity).HasComment("Enviado");
            entity.Property(e => e.ReceivedUnits).HasComment("Unidades Enviadas");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.WarehousePositionID).HasComment("Posición");

            entity.HasOne(d => d.ProductStatus).WithMany(p => p.PurchaseReceptionItem).HasConstraintName("FK_PurchaseReceptionItem_ProductStatus");

            entity.HasOne(d => d.PurchaseReception).WithMany(p => p.PurchaseReceptionItem).HasConstraintName("FK_PurchaseReceptionItem_PurchaseReception");

            entity.HasOne(d => d.WarehousePosition).WithMany(p => p.PurchaseReceptionItem).HasConstraintName("FK_PurchaseReceptionItem_WarehousePosition");
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.Property(e => e.ReceiptID).HasComment("ID");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CustomerID).HasComment("Customer Id");
            entity.Property(e => e.DocumentStatusID).HasComment("ID");
            entity.Property(e => e.ExpenseSubTypeID).HasComment("Sub Concepto");
            entity.Property(e => e.ExpenseTypeID).HasComment("Concepto");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.PeriodID).HasComment("Período");
            entity.Property(e => e.ReceiptClassID).HasComment("Tipo de Recibo");
            entity.Property(e => e.ReceiptCode).HasComment("Referencia");
            entity.Property(e => e.ReceiptDate).HasComment("Date");
            entity.Property(e => e.ReceiptNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Receipt Number");
            entity.Property(e => e.Remarks).HasComment("Remarks");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.Receipt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Receipt_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.Receipt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Receipt_Channel");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.Receipt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Receipt_DocumentStatus");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.Receipt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Receipt_OrganizationUnit");
        });

        modelBuilder.Entity<ReceiptAccountReceivable>(entity =>
        {
            entity.Property(e => e.ReceiptAccountReceivableNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.ReceiptID).HasComment("ID");

            entity.HasOne(d => d.AccountReceivable).WithMany(p => p.ReceiptAccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptAccountReceivable_AccountReceivable");

            entity.HasOne(d => d.Receipt).WithMany(p => p.ReceiptAccountReceivable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptAccountReceivable_Receipt");
        });

        modelBuilder.Entity<ReceiptControlStatus>(entity =>
        {
            entity.Property(e => e.ReceiptControlStatusID).HasComment("ID");
            entity.Property(e => e.ReceiptControlStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<ReceiptFile>(entity =>
        {
            entity.HasKey(e => e.ReceiptFileID).HasName("PK_ReceiptFile_1");

            entity.Property(e => e.ReceiptFileID).HasComment("ID");
            entity.Property(e => e.FileTypeID).HasComment("Tipo");
            entity.Property(e => e.ReceiptID).HasComment("ID");

            entity.HasOne(d => d.File).WithMany(p => p.ReceiptFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptFile_File");

            entity.HasOne(d => d.FileType).WithMany(p => p.ReceiptFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptFile_FileType");

            entity.HasOne(d => d.Receipt).WithMany(p => p.ReceiptFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptFile_Receipt");
        });

        modelBuilder.Entity<ReceiptValue>(entity =>
        {
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.EndorsableCompanyID).HasComment("EndorsableCompanyID");
            entity.Property(e => e.EndorsableCustomerID).HasComment("EndorsableCustomerID");
            entity.Property(e => e.ReceiptID).HasComment("ID");
            entity.Property(e => e.ReceiptValueNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.SourceReceiptID).HasComment("ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.ReceiptValue).HasConstraintName("FK_ReceiptValue_Bank");

            entity.HasOne(d => d.BatchPaymentValue).WithMany(p => p.ReceiptValue).HasConstraintName("FK_ReceiptValue_BatchPaymentValue");

            entity.HasOne(d => d.Check).WithMany(p => p.ReceiptValue).HasConstraintName("FK_ReceiptValue_Check");

            entity.HasOne(d => d.Currency).WithMany(p => p.ReceiptValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptValue_Currency");

            entity.HasOne(d => d.Receipt).WithMany(p => p.ReceiptValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptValue_Receipt");

            entity.HasOne(d => d.ValueType).WithMany(p => p.ReceiptValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptValue_ValueType");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleID).HasComment("ID");
            entity.Property(e => e.RoleName).HasComment("Rol");
        });

        modelBuilder.Entity<RoleMenuItem>(entity =>
        {
            entity.HasOne(d => d.MenuItem).WithMany(p => p.RoleMenuItem).HasConstraintName("FK_RoleMenuItem_MenuItem");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleMenuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleMenuItem_Role");
        });

        modelBuilder.Entity<Rule>(entity =>
        {
            entity.Property(e => e.RuleID).HasComment("Código");
            entity.Property(e => e.RuleName).HasComment("Nombre");
        });

        modelBuilder.Entity<RuleField>(entity =>
        {
            entity.Property(e => e.RuleFieldID).HasComment("Código");
            entity.Property(e => e.ReferenceFieldName).HasComment("Campo");
            entity.Property(e => e.RuleFieldData).HasComment("Datos");
            entity.Property(e => e.RuleFieldHTML).HasComment("HTML");
            entity.Property(e => e.RuleFieldName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleDelivery>(entity =>
        {
            entity.HasKey(e => e.SaleDeliveryID).HasName("PK_DeliveryOrder");

            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DeliveryDate).HasComment("Fecha");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Multiplier).HasComment("Multiplicador");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.PriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleDeliveryDate).HasComputedColumnSql("(CONVERT([date],[CreatedOn]))", false);
            entity.Property(e => e.SaleDeliveryNoteDate).HasComment("Fecha real del remito");
            entity.Property(e => e.SaleDeliveryNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.SaleDeliveryStatusID).HasComment("Estado");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.SubCustomerID).HasComment("Cliente");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.WarehousePositionID).HasComment("Dock de carga");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDelivery_Customer");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.SaleDelivery).HasConstraintName("FK_SaleDelivery_DeliveryZone");

            entity.HasOne(d => d.SaleDeliveryOnTripStatus).WithMany(p => p.SaleDelivery).HasConstraintName("FK_SaleDelivery_SaleDeliveryOnTripStatus");

            entity.HasOne(d => d.SaleDeliveryRejectReason).WithMany(p => p.SaleDelivery).HasConstraintName("FK_SaleDelivery_SaleDeliveryRejectReason");

            entity.HasOne(d => d.SaleDeliveryStatus).WithMany(p => p.SaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryOrder_DeliveryOrderStatus");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.SaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryOrder_SaleOrder");

            entity.HasOne(d => d.Trip).WithMany(p => p.SaleDelivery).HasConstraintName("FK_SaleDelivery_Trip");

            entity.HasOne(d => d.WarehousePosition).WithMany(p => p.SaleDelivery).HasConstraintName("FK_SaleDelivery_WarehousePosition");
        });

        modelBuilder.Entity<SaleDeliveryItem>(entity =>
        {
            entity.Property(e => e.DeliveredQuantity).HasComment("Solicitado");
            entity.Property(e => e.DeliveredUnits).HasComment("Solicitado");
            entity.Property(e => e.InventoryID).HasComment("Posición Origen Producto");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleDeliveryItemNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");

            entity.HasOne(d => d.Inventory).WithMany(p => p.SaleDeliveryItem).HasConstraintName("FK_SaleDeliveryItem_Inventory");

            entity.HasOne(d => d.SaleDelivery).WithMany(p => p.SaleDeliveryItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryItem_SaleDelivery");

            entity.HasOne(d => d.SaleOrderItem).WithMany(p => p.SaleDeliveryItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryItem_SaleOrderItem");
        });

        modelBuilder.Entity<SaleDeliveryNote>(entity =>
        {
            entity.HasKey(e => e.SaleDeliveryNoteID).HasName("PK_SaleDocument");

            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.SaleDeliveryNoteNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.SaleDeliveryNoteStatusID).HasComment("Estado");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SubCustomerID).HasComment("Sub Cliente");
            entity.Property(e => e.TotalAmount).HasComment("");
            entity.Property(e => e.TotalCommissionAmount).HasComment("");
            entity.Property(e => e.UrgencyID).HasComment("Urgencia");
            entity.Property(e => e.WarehouseID).HasComment("Dock de carga");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNote_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNote_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNote_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNote_Customer");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.SaleDeliveryNote).HasConstraintName("FK_SaleDeliveryNote_PaymentCondition");

            entity.HasOne(d => d.SaleDelivery).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDocument_SaleDelivery");

            entity.HasOne(d => d.SaleDeliveryNoteStatus).WithMany(p => p.SaleDeliveryNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNote_SaleDeliveryNoteStatus");

            entity.HasOne(d => d.Urgency).WithMany(p => p.SaleDeliveryNote).HasConstraintName("FK_SaleDeliveryNote_Urgency");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.SaleDeliveryNote).HasConstraintName("FK_SaleDeliveryNote_Warehouse");
        });

        modelBuilder.Entity<SaleDeliveryNoteHistory>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DeliveryDate).HasComment("Fecha");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Multiplier).HasComment("Multiplicador");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.PriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleDeliveryID).HasComment("Cliente");
            entity.Property(e => e.SaleDeliveryNoteDate).HasComment("Fecha real del remito");
            entity.Property(e => e.SaleDeliveryNumber).HasComment("Cliente");
            entity.Property(e => e.SaleOrderNumber).HasComment("Cliente");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.SubCustomerID).HasComment("Cliente");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.WarehousePositionID).HasComment("Dock de carga");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.Channel).WithMany(p => p.SaleDeliveryNoteHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNoteHistory_Channel");
        });

        modelBuilder.Entity<SaleDeliveryNoteHistoryItem>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.CommissionPercent).HasComment("% Comisión");
            entity.Property(e => e.DeliveredQuantity).HasComment("Solicitado");
            entity.Property(e => e.DeliveredUnits).HasComment("Solicitado");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitPrice).HasComment("Precio");

            entity.HasOne(d => d.SaleDeliveryNoteHistory).WithMany(p => p.SaleDeliveryNoteHistoryItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNoteHistoryItem_SaleDeliveryNoteHistory");
        });

        modelBuilder.Entity<SaleDeliveryNoteItem>(entity =>
        {
            entity.Property(e => e.CommissionPercent).HasComment("% Comisión");
            entity.Property(e => e.CustomDeliveryCode).HasComment("Despacho de Aduana");
            entity.Property(e => e.DeliveredQuantity).HasComment("Solicitado");
            entity.Property(e => e.DeliveredUnits).HasComment("Solicitado");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitPrice).HasComment("Precio");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleDeliveryNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNoteItem_Product");

            entity.HasOne(d => d.SaleDeliveryNote).WithMany(p => p.SaleDeliveryNoteItem).HasConstraintName("FK_SaleDeliveryNoteItem_SaleDeliveryNote1");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.SaleDeliveryNoteItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDeliveryNoteItem_UnitOfMeasure");
        });

        modelBuilder.Entity<SaleDeliveryNoteStatus>(entity =>
        {
            entity.Property(e => e.SaleDeliveryNoteStatusID).HasComment("Código");
            entity.Property(e => e.SaleDeliveryNoteStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleDeliveryStatus>(entity =>
        {
            entity.HasKey(e => e.SaleDeliveryStatusID).HasName("PK_DeliveryOrderStatus");

            entity.Property(e => e.SaleDeliveryStatusID).HasComment("Código");
            entity.Property(e => e.SaleDeliveryStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleDistrict>(entity =>
        {
            entity.Property(e => e.SaleDistrictID).HasComment("Código");
            entity.Property(e => e.SaleDistrictName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleGroup>(entity =>
        {
            entity.Property(e => e.SaleGroupID).HasComment("Código");
            entity.Property(e => e.SaleGroupName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleOrder>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Multiplier).HasComment("Multiplicador");
            entity.Property(e => e.OtherSaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.PriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedDate).HasComment("Fecha");
            entity.Property(e => e.SaleOrderDate).HasComputedColumnSql("(CONVERT([date],[CreatedOn]))", false);
            entity.Property(e => e.SaleOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.SaleOrderStatusID).HasComment("Estado");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.SubCustomerID).HasComment("Cliente");
            entity.Property(e => e.SubCustomerPriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.UrgencyID).HasComment("Urgencia");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.Carrier).WithMany(p => p.SaleOrder).HasConstraintName("FK_SaleOrder_Carrier");

            entity.HasOne(d => d.Channel).WithMany(p => p.SaleOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrder_Channel");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrder_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrder_Customer");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.SaleOrder).HasConstraintName("FK_SaleOrder_DeliveryZone");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.SaleOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrder_PaymentCondition");

            entity.HasOne(d => d.PriceList).WithMany(p => p.SaleOrder).HasConstraintName("FK_SaleOrder_PriceList");

            entity.HasOne(d => d.ProductCondition).WithMany(p => p.SaleOrder).HasConstraintName("FK_SaleOrder_ProductCondition");

            entity.HasOne(d => d.SaleOrderStatus).WithMany(p => p.SaleOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrder_SaleOrderStatus");

            entity.HasOne(d => d.Urgency).WithMany(p => p.SaleOrder).HasConstraintName("FK_SaleOrder_Urgency");
        });

        modelBuilder.Entity<SaleOrderItem>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.CommissionPercent).HasComment("% Comisión");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedQuantity).HasComment("Solicitado");
            entity.Property(e => e.RequestedUnits).HasComment("Solicitado");
            entity.Property(e => e.SaleOrderItemNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.UnitListPrice).HasComment("Precio Lista");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitOtherPrice).HasComment("Precio Subcliente");
            entity.Property(e => e.UnitPrice).HasComment("Precio");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.SaleOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleOrderItem_SaleOrder");
        });

        modelBuilder.Entity<SaleOrderStatus>(entity =>
        {
            entity.Property(e => e.SaleOrderStatusID).HasComment("Código");
            entity.Property(e => e.SaleOrderStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleOrderTaskStatus>(entity =>
        {
            entity.Property(e => e.SaleOrderTaskStatusID).HasComment("Código");
            entity.Property(e => e.SaleOrderTaskStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<SaleRepresentative>(entity =>
        {
            entity.ToView("SaleRepresentative");
        });

        modelBuilder.Entity<SaleRepresentativePayment>(entity =>
        {
            entity.Property(e => e.SaleRepresentativePaymentID).HasComment("ID");
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.CurrencyRateAmount).HasComment("Cotización Dolar");
            entity.Property(e => e.DocumentStatusID).HasComment("ID");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.Remarks).HasComment("Remarks");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Customer Id");
            entity.Property(e => e.SaleRepresentativePaymentCode).HasComment("Referencia");
            entity.Property(e => e.SaleRepresentativePaymentDate).HasComment("Date");
            entity.Property(e => e.SaleRepresentativePaymentNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Receipt Number");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.SaleRepresentativePayment).HasConstraintName("FK_SaleRepresentativePayment_BusinessUnit");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.SaleRepresentativePayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePayment_DocumentStatus");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.SaleRepresentativePayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePayment_OrganizationUnit");

            entity.HasOne(d => d.SaleRepresentative).WithMany(p => p.SaleRepresentativePayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePayment_User");
        });

        modelBuilder.Entity<SaleRepresentativePaymentCommissionPayable>(entity =>
        {
            entity.Property(e => e.SaleRepresentativePaymentID).HasComment("ID");

            entity.HasOne(d => d.CommissionPayable).WithMany(p => p.SaleRepresentativePaymentCommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePaymentCommissionPayable_CommissionPayable");

            entity.HasOne(d => d.SaleRepresentativePayment).WithMany(p => p.SaleRepresentativePaymentCommissionPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePaymentCommissionPayable_SaleRepresentativePayment");
        });

        modelBuilder.Entity<SaleRepresentativePaymentValue>(entity =>
        {
            entity.Property(e => e.SaleRepresentativePaymentID).HasComment("ID");
            entity.Property(e => e.SaleRepresentativePaymentNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Bank).WithMany(p => p.SaleRepresentativePaymentValue).HasConstraintName("FK_SaleRepresentativePaymentValue_Bank");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleRepresentativePaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePaymentValue_Currency");

            entity.HasOne(d => d.Journal).WithMany(p => p.SaleRepresentativePaymentValue).HasConstraintName("FK_SaleRepresentativePaymentValue_Journal");

            entity.HasOne(d => d.SaleRepresentativePayment).WithMany(p => p.SaleRepresentativePaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePaymentValue_SaleRepresentativePayment");

            entity.HasOne(d => d.ValueType).WithMany(p => p.SaleRepresentativePaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRepresentativePaymentValue_ValueType");
        });

        modelBuilder.Entity<SaleRetail>(entity =>
        {
            entity.Property(e => e.SaleRetailID).HasComment("ID");
            entity.Property(e => e.Amount).HasComment("Monto");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.OrganizationUnitContactID).HasComment("Contacto");
            entity.Property(e => e.OrganizationUnitID).HasComment("Sucursal");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleRetailDate).HasComment("Fecha");
            entity.Property(e => e.SaleRetailNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleRetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetail_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleRetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetail_Customer");

            entity.HasOne(d => d.OrganizationUnitContact).WithMany(p => p.SaleRetail).HasConstraintName("FK_SaleRetail_OrganizationUnitContact");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.SaleRetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetail_OrganizationUnit");

            entity.HasOne(d => d.Trip).WithMany(p => p.SaleRetail).HasConstraintName("FK_SaleRetail_Trip");
        });

        modelBuilder.Entity<SaleRetailCredit>(entity =>
        {
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.OpenAmount).HasComment("Saldo");
            entity.Property(e => e.OrganizationUnitContactID).HasComment("Contacto");
            entity.Property(e => e.OrganizationUnitID).HasComment("Sucursal");
            entity.Property(e => e.SaleRetailCreditNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.SourceSaleRetailID).HasComment("Venta Origen");
            entity.Property(e => e.TotalAmount).HasComment("Monto");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleRetailCredit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailCredit_Currency");

            entity.HasOne(d => d.OrganizationUnitContact).WithMany(p => p.SaleRetailCredit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailCredit_OrganizationUnitContact");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.SaleRetailCredit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailCredit_OrganizationUnit");
        });

        modelBuilder.Entity<SaleRetailItem>(entity =>
        {
            entity.Property(e => e.InventoryBarCodeID).HasComment("Etiqueta");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Quantity).HasComment("Cantidad");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.SaleRetailID).HasComment("ID");
            entity.Property(e => e.UnitPrice).HasComment("Precio");

            entity.HasOne(d => d.InventoryBarCode).WithMany(p => p.SaleRetailItem).HasConstraintName("FK_SaleRetailItem_InventoryBarCode");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleRetailItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailItem_Product");

            entity.HasOne(d => d.SaleRetail).WithMany(p => p.SaleRetailItem).HasConstraintName("FK_SaleRetailItem_SaleRetail");
        });

        modelBuilder.Entity<SaleRetailValue>(entity =>
        {
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.EndorsableCompanyID).HasComment("EndorsableCompanyID");
            entity.Property(e => e.EndorsableCustomerID).HasComment("EndorsableCustomerID");
            entity.Property(e => e.SaleRetailID).HasComment("ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_Bank");

            entity.HasOne(d => d.Check).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_Check");

            entity.HasOne(d => d.CheckStatus).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_CheckStatus");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleRetailValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailValue_Currency");

            entity.HasOne(d => d.EndorsableCompany).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_EndorsableCompany");

            entity.HasOne(d => d.EndorsableCustomer).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_EndorsableCustomer");

            entity.HasOne(d => d.SaleRetailCredit).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_SaleRetailCredit");

            entity.HasOne(d => d.SaleRetail).WithMany(p => p.SaleRetailValue).HasConstraintName("FK_SaleRetailValue_SaleRetail");

            entity.HasOne(d => d.ValueType).WithMany(p => p.SaleRetailValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleRetailValue_ValueType");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.Property(e => e.ScheduleID).HasComment("Código");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.ScheduleCode).HasComment("");
            entity.Property(e => e.ScheduleName).HasComment("Nombre");
        });

        modelBuilder.Entity<SqlScript>(entity =>
        {
            entity.Property(e => e.SqlScriptID).HasComment("ID");
            entity.Property(e => e.SqlScriptName).HasComment("Nombre");
            entity.Property(e => e.SqlScriptText).HasComment("Texto");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.StateID).HasComment("Código ISO 3166-2");
            entity.Property(e => e.CountryID).HasComment("País");
            entity.Property(e => e.StateName).HasComment("Nombre");

            entity.HasOne(d => d.Country).WithMany(p => p.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_State_Country");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.Property(e => e.TagID).HasComment("User Id");
            entity.Property(e => e.TagName).HasComment("Código");
        });

        modelBuilder.Entity<ViajesERPModel.Model.Task>(entity =>
        {
            entity.Property(e => e.TableKey).HasComment("PK");
            entity.Property(e => e.TableName).HasComment("Table");
            entity.Property(e => e.TaskConditionID).HasComment("Condición");
            entity.Property(e => e.TaskStatusID).HasComment("Estado");
            entity.Property(e => e.TaskTypeID).HasComment("Tipo");
            entity.Property(e => e.TeamID).HasComment("Código");

            entity.HasOne(d => d.TaskCondition).WithMany(p => p.Task)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Task_TaskCondition");

            entity.HasOne(d => d.TaskStatus).WithMany(p => p.Task)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Task_TaskStatus");

            entity.HasOne(d => d.TaskType).WithMany(p => p.Task)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Task_TaskType");

            entity.HasOne(d => d.Team).WithMany(p => p.Task).HasConstraintName("FK_Task_Team");
        });

        modelBuilder.Entity<TaskClass>(entity =>
        {
            entity.Property(e => e.TaskClassID).HasComment("Código");
            entity.Property(e => e.TaskClassName).HasComment("Nombre");
        });

        modelBuilder.Entity<TaskCondition>(entity =>
        {
            entity.Property(e => e.TaskConditionID).HasComment("Código");
            entity.Property(e => e.TaskConditionName).HasComment("Nombre");
        });

        modelBuilder.Entity<TaskLog>(entity =>
        {
            entity.HasOne(d => d.TaskLogStatus).WithMany(p => p.TaskLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskLog_TaskLogStatus");

            entity.HasOne(d => d.TaskType).WithMany(p => p.TaskLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskLog_TaskType");
        });

        modelBuilder.Entity<TaskLogStatus>(entity =>
        {
            entity.Property(e => e.TaskLogStatusID).HasComment("Código");
            entity.Property(e => e.TaskLogStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<ViajesERPModel.Model.TaskStatus>(entity =>
        {
            entity.Property(e => e.TaskStatusID).HasComment("Código");
            entity.Property(e => e.TaskStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<TaskType>(entity =>
        {
            entity.Property(e => e.TaskTypeID).HasComment("Código");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.ExecutionOrder).HasComment("Orden");
            entity.Property(e => e.ScheduleID).HasComment("Agenda");
            entity.Property(e => e.TaskClassID).HasComment("Clase");
            entity.Property(e => e.TaskTypeName).HasComment("Nombre");

            entity.HasOne(d => d.Schedule).WithMany(p => p.TaskType).HasConstraintName("FK_TaskType_Schedule");

            entity.HasOne(d => d.TaskClass).WithMany(p => p.TaskType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskType_TaskClass");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.Property(e => e.TeamID).HasComment("Código");
            entity.Property(e => e.TeamName).HasComment("Nombre");
        });

        modelBuilder.Entity<TeamUser>(entity =>
        {
            entity.Property(e => e.TeamID).HasComment("Código");
            entity.Property(e => e.UserID).HasComment("User Id");

            entity.HasOne(d => d.Team).WithMany(p => p.TeamUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamUser_Team");

            entity.HasOne(d => d.User).WithMany(p => p.TeamUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamUser_User");
        });

        modelBuilder.Entity<ThirdPartyBusinessUnit>(entity =>
        {
            entity.Property(e => e.BusinessUnitID).HasComment("B.U.");
        });

        modelBuilder.Entity<TransferOrder>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyID).HasComment("Moneda");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.Multiplier).HasComment("Multiplicador");
            entity.Property(e => e.PaymentConditionID).HasComment("Condición de Pago");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.PriceListID).HasComment("Lista de Precios");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedDate).HasComment("Fecha");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.SubCustomerID).HasComment("SubCliente");
            entity.Property(e => e.TransferOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.TransferOrderStatusID).HasComment("Estado");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_BusinessUnit");

            entity.HasOne(d => d.Carrier).WithMany(p => p.TransferOrder).HasConstraintName("FK_TransferOrder_Carrier");

            entity.HasOne(d => d.Currency).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_Customer");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_PaymentCondition");

            entity.HasOne(d => d.PriceList).WithMany(p => p.TransferOrder).HasConstraintName("FK_TransferOrder_PriceList");

            entity.HasOne(d => d.PurchaseDelivery).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_PurchaseDelivery");

            entity.HasOne(d => d.TransferOrderStatus).WithMany(p => p.TransferOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrder_TransferOrderStatus");
        });

        modelBuilder.Entity<TransferOrderItem>(entity =>
        {
            entity.Property(e => e.CommissionPercent).HasComment("% Comisión");
            entity.Property(e => e.GrossQuantity).HasComment("Solicitado");
            entity.Property(e => e.NetQuantity).HasComment("Solicitado");
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.UnitListPrice).HasComment("Precio Lista");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitPrice).HasComment("Precio");
            entity.Property(e => e.Units).HasComment("Solicitado");

            entity.HasOne(d => d.Product).WithMany(p => p.TransferOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderItem_Product");

            entity.HasOne(d => d.TransferOrder).WithMany(p => p.TransferOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderItem_TransferOrder");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.TransferOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderItem_UnitOfMeasure");
        });

        modelBuilder.Entity<TransferOrderStatus>(entity =>
        {
            entity.Property(e => e.TransferOrderStatusID).HasComment("Código");
            entity.Property(e => e.TransferOrderStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.Property(e => e.DriverName).HasComment("Conductor");
            entity.Property(e => e.FreightID).HasComment("Flete");
            entity.Property(e => e.PlateName).HasComment("Chapa");
            entity.Property(e => e.TripCostAmount).HasComment("Costo Viaje");
            entity.Property(e => e.TripStatusID).HasComment("Estado");
            entity.Property(e => e.VehicleTypeID).HasComment("Vehiculo");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.Trip).HasConstraintName("FK_Trip_DeliveryZone");

            entity.HasOne(d => d.Freight).WithMany(p => p.Trip).HasConstraintName("FK_Trip_Freight");

            entity.HasOne(d => d.TripStatus).WithMany(p => p.Trip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trip_TripStatus");

            entity.HasOne(d => d.TripType).WithMany(p => p.Trip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trip_TripType");

            entity.HasOne(d => d.WarehouseGroup).WithMany(p => p.Trip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trip_WarehouseGroup");
        });

        modelBuilder.Entity<TripEvent>(entity =>
        {
            entity.HasKey(e => e.TripEventID).HasName("PK_TripFile");

            entity.HasOne(d => d.Event).WithMany(p => p.TripEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripEvent_Event");

            entity.HasOne(d => d.File).WithMany(p => p.TripEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripFile_File");

            entity.HasOne(d => d.SaleDelivery).WithMany(p => p.TripEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripFile_SaleDelivery");

            entity.HasOne(d => d.Trip).WithMany(p => p.TripEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripFile_Trip");
        });

        modelBuilder.Entity<TripSaleDelivery>(entity =>
        {
            entity.HasOne(d => d.SaleDelivery).WithMany(p => p.TripSaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSaleDelivery_SaleDelivery");

            entity.HasOne(d => d.SaleDeliveryOnTripStatus).WithMany(p => p.TripSaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSaleDelivery_SaleDeliveryOnTripStatus");

            entity.HasOne(d => d.SaleDeliveryRejectReason).WithMany(p => p.TripSaleDelivery).HasConstraintName("FK_TripSaleDelivery_SaleDeliveryRejectReason");

            entity.HasOne(d => d.Trip).WithMany(p => p.TripSaleDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSaleDelivery_Trip");
        });

        modelBuilder.Entity<TripSaleRetail>(entity =>
        {
            entity.HasOne(d => d.SaleRetail).WithMany(p => p.TripSaleRetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSaleRetail_SaleRetail");

            entity.HasOne(d => d.Trip).WithMany(p => p.TripSaleRetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSaleRetail_Trip");
        });

        modelBuilder.Entity<TripWithdrawalOrder>(entity =>
        {
            entity.HasOne(d => d.Trip).WithMany(p => p.TripWithdrawalOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripWithdrawalOrder_Trip");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserID).HasComment("User Id");
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.Email).HasComment("E Mail");
            entity.Property(e => e.FirstName).HasComment("Nombre");
            entity.Property(e => e.ForceChangePassword).HasComment("Forzar Cambio Contraseña");
            entity.Property(e => e.LastLogon).HasComment("Último Login");
            entity.Property(e => e.LastName).HasComment("Apellido");
            entity.Property(e => e.Password).HasComment("Password");
            entity.Property(e => e.ReceiveNotification).HasComment("Recibe Notificaciones");
            entity.Property(e => e.UserName).HasComment("Login");

            entity.HasOne(d => d.SaleChannel).WithMany(p => p.User).HasConstraintName("FK_User_SaleChannel");
        });

        modelBuilder.Entity<UserDataView>(entity =>
        {
            entity.Property(e => e.UserID).HasComment("User Id");
        });

        modelBuilder.Entity<UserMenuItem>(entity =>
        {
            entity.Property(e => e.UserID).HasComment("User Id");
            entity.Property(e => e.MenuItemID).HasComment("ID");

            entity.HasOne(d => d.MenuItem).WithMany(p => p.UserMenuItem).HasConstraintName("FK_UserMenuItem_MenuItem");

            entity.HasOne(d => d.User).WithMany(p => p.UserMenuItem).HasConstraintName("FK_UserMenuItem_User");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserID, e.RoleID }).HasName("PK_ApplicationUserRole");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationUserRole_ApplicationRole");

            entity.HasOne(d => d.User).WithMany(p => p.UserRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationUserRole_ApplicationUser");
        });

        modelBuilder.Entity<ValueStatus>(entity =>
        {
            entity.Property(e => e.ValueStatusID).HasComment("Código");
            entity.Property(e => e.ValueStatusName).HasComment("Nombre");
        });

        modelBuilder.Entity<ViajesERPModel.Model.ValueType>(entity =>
        {
            entity.Property(e => e.ValueTypeID).HasComment("Código");
            entity.Property(e => e.InValueStatusID).HasComment("Estado Ingreso");
            entity.Property(e => e.OutValueStatusID).HasComment("Estado Egreso");
            entity.Property(e => e.ValueTypeGroupID).HasComment("Código");
            entity.Property(e => e.ValueTypeName).HasComment("Nombre");

            entity.HasOne(d => d.ValueTypeGroup).WithMany(p => p.ValueType).HasConstraintName("FK_ValueType_ValueTypeGroup");
        });

        modelBuilder.Entity<ValueTypeGroup>(entity =>
        {
            entity.Property(e => e.ValueTypeGroupID).HasComment("Código");
            entity.Property(e => e.ValueTypeGroupName).HasComment("Nombre");
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.Property(e => e.Active).HasComment("Activo");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.ContactName).HasComment("Contacto");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.PaymentConditionID).HasComment("Código");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.VendorNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Código Interno");

            entity.HasOne(d => d.Country).WithMany(p => p.Vendor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_Country");

            entity.HasOne(d => d.PaymentCondition).WithMany(p => p.Vendor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_PaymentCondition");
        });

        modelBuilder.Entity<VendorPayment>(entity =>
        {
            entity.Property(e => e.VendorPaymentID).HasComment("ID");
            entity.Property(e => e.BusinessUnitID).HasComment("Código");
            entity.Property(e => e.ChannelID).HasComment("Canal");
            entity.Property(e => e.CurrencyRateAmount).HasComment("Cotización Dolar");
            entity.Property(e => e.DocumentStatusID).HasComment("ID");
            entity.Property(e => e.ExpenseSubTypeID).HasComment("Sub Concepto");
            entity.Property(e => e.ExpenseTypeID).HasComment("Concepto");
            entity.Property(e => e.OrganizationUnitID).HasComment("U.O.");
            entity.Property(e => e.PeriodID).HasComment("Período");
            entity.Property(e => e.Remarks).HasComment("Remarks");
            entity.Property(e => e.SourceBusinessUnitID).HasComment("B.U.");
            entity.Property(e => e.VendorID).HasComment("Customer Id");
            entity.Property(e => e.VendorPaymentClassID).HasComment("Tipo de Pago");
            entity.Property(e => e.VendorPaymentCode).HasComment("Referencia");
            entity.Property(e => e.VendorPaymentDate).HasComment("Date");
            entity.Property(e => e.VendorPaymentNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Receipt Number");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.VendorPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPayment_BusinessUnit");

            entity.HasOne(d => d.Channel).WithMany(p => p.VendorPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPayment_Channel");

            entity.HasOne(d => d.DocumentStatus).WithMany(p => p.VendorPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPayment_DocumentStatus");

            entity.HasOne(d => d.ExpenseSubType).WithMany(p => p.VendorPayment).HasConstraintName("FK_VendorPayment_ExpenseSubType");

            entity.HasOne(d => d.ExpenseType).WithMany(p => p.VendorPayment).HasConstraintName("FK_VendorPayment_ExpenseType");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.VendorPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPayment_OrganizationUnit");
        });

        modelBuilder.Entity<VendorPaymentAccountPayable>(entity =>
        {
            entity.Property(e => e.VendorPaymentID).HasComment("ID");

            entity.HasOne(d => d.AccountPayable).WithMany(p => p.VendorPaymentAccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPaymentAccountPayable_AccountPayable");

            entity.HasOne(d => d.VendorPayment).WithMany(p => p.VendorPaymentAccountPayable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPaymentAccountPayable_VendorPayment");
        });

        modelBuilder.Entity<VendorPaymentValue>(entity =>
        {
            entity.Property(e => e.CheckStatusID).HasComment("Código");
            entity.Property(e => e.EndorsableCompanyID).HasComment("EndorsableCompanyID");
            entity.Property(e => e.EndorsableCustomerID).HasComment("EndorsableCustomerID");
            entity.Property(e => e.VendorPaymentID).HasComment("ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.VendorPaymentValue).HasConstraintName("FK_VendorPaymentValue_Bank");

            entity.HasOne(d => d.Currency).WithMany(p => p.VendorPaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPaymentValue_Currency");

            entity.HasOne(d => d.ValueType).WithMany(p => p.VendorPaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPaymentValue_ValueType");

            entity.HasOne(d => d.VendorPayment).WithMany(p => p.VendorPaymentValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorPaymentValue_VendorPayment");
        });

        modelBuilder.Entity<WarehousePosition>(entity =>
        {
            entity.Property(e => e.Active).HasComment("Activo");
            entity.Property(e => e.Aisle).HasComment("Pasillo");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.Floor).HasComment("Piso");
            entity.Property(e => e.IncludeInCount).HasComment("Incluida en Cuenta Stock");
            entity.Property(e => e.InputPosition).HasComment("Para Ingreso");
            entity.Property(e => e.Module).HasComment("Módulo");
            entity.Property(e => e.OutputPosition).HasComment("Para Egreso");
            entity.Property(e => e.Shelf).HasComment("Estante");
            entity.Property(e => e.WarehouseID).HasComment("Depósito");
            entity.Property(e => e.WarehousePositionName).HasComment("Nombre");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehousePosition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousePosition_Warehouse");
        });

        modelBuilder.Entity<WithdrawalOrder>(entity =>
        {
            entity.Property(e => e.Address).HasComment("Dirección");
            entity.Property(e => e.CarrierID).HasComment("Transportitsta");
            entity.Property(e => e.CustomerID).HasComment("Cliente");
            entity.Property(e => e.CustomerLegalName).HasComment("Razón Social");
            entity.Property(e => e.DistrictName).HasComment("Localidad");
            entity.Property(e => e.FiscalCode).HasComment("CUIT");
            entity.Property(e => e.FiscalCodeTypeID).HasComment("Condición IVA");
            entity.Property(e => e.Phone).HasComment("Teléfono");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedDate).HasComment("Fecha");
            entity.Property(e => e.SaleRepresentativeID).HasComment("Vendedor");
            entity.Property(e => e.StateID).HasComment("Provincia");
            entity.Property(e => e.TaxCode).HasComment("IIBB");
            entity.Property(e => e.WithdrawalOrderNumber)
                .ValueGeneratedOnAdd()
                .HasComment("Número");
            entity.Property(e => e.WithdrawalOrderStatusID).HasComment("Estado");
            entity.Property(e => e.ZipCode).HasComment("Código Postal");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_BusinessUnit");

            entity.HasOne(d => d.Carrier).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_Carrier");

            entity.HasOne(d => d.Customer).WithMany(p => p.WithdrawalOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WithdrawalOrder_Customer");

            entity.HasOne(d => d.DeliveryZone).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_DeliveryZone");

            entity.HasOne(d => d.FiscalCodeType).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_FiscalCodeType");

            entity.HasOne(d => d.SaleDeliveryRejectReason).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_SaleDeliveryRejectReason");

            entity.HasOne(d => d.State).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_State");

            entity.HasOne(d => d.Trip).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_Trip");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WithdrawalOrder).HasConstraintName("FK_WithdrawalOrder_Warehouse");

            entity.HasOne(d => d.WithdrawalOrderStatus).WithMany(p => p.WithdrawalOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WithdrawalOrder_WithdrawalOrderStatus");
        });

        modelBuilder.Entity<WithdrawalOrderItem>(entity =>
        {
            entity.Property(e => e.ProductID).HasComment("Producto");
            entity.Property(e => e.Remarks).HasComment("Comentarios");
            entity.Property(e => e.RequestedQuantity).HasComment("Solicitado");
            entity.Property(e => e.RequestedUnits).HasComment("Solicitado");
            entity.Property(e => e.UnitListPrice).HasComment("Precio Lista");
            entity.Property(e => e.UnitOfMeasureID).HasComment("Medida");
            entity.Property(e => e.UnitPrice).HasComment("Precio");
            entity.Property(e => e.WithdrawalOrderItemNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Currency).WithMany(p => p.WithdrawalOrderItem).HasConstraintName("FK_WithdrawalOrderItem_Currency");

            entity.HasOne(d => d.Product).WithMany(p => p.WithdrawalOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WithdrawalOrderItem_Product");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.WithdrawalOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WithdrawalOrderItem_UnitOfMeasure");

            entity.HasOne(d => d.WithdrawalOrder).WithMany(p => p.WithdrawalOrderItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WithdrawalOrderItem_WithdrawalOrder");
        });

        modelBuilder.Entity<Workflow>(entity =>
        {
            entity.Property(e => e.WorkflowID).HasComment("Código");
            entity.Property(e => e.WorkflowJSON).HasComment("JSON");
            entity.Property(e => e.WorkflowName).HasComment("Nombre");
            entity.Property(e => e.WorkflowXML).HasComment("XML");
        });

        modelBuilder.Entity<vAllDocument>(entity =>
        {
            entity.ToView("vAllDocument");
        });

        modelBuilder.Entity<vBarCodeInventory>(entity =>
        {
            entity.ToView("vBarCodeInventory");
        });

        modelBuilder.Entity<vBasePriceAndProductCommission>(entity =>
        {
            entity.ToView("vBasePriceAndProductCommission");
        });

        modelBuilder.Entity<vBatchPayment>(entity =>
        {
            entity.ToView("vBatchPayment");
        });

        modelBuilder.Entity<vBatchPaymentTarot>(entity =>
        {
            entity.ToView("vBatchPaymentTarot");
        });

        modelBuilder.Entity<vCheck>(entity =>
        {
            entity.ToView("vCheck");
        });

        modelBuilder.Entity<vClientesVendedores>(entity =>
        {
            entity.ToView("vClientesVendedores");
        });

        modelBuilder.Entity<vClientesYaquira>(entity =>
        {
            entity.ToView("vClientesYaquira");
        });

        modelBuilder.Entity<vCuernina>(entity =>
        {
            entity.ToView("vCuernina");
        });

        modelBuilder.Entity<vCurrencyRate>(entity =>
        {
            entity.ToView("vCurrencyRate");
        });

        modelBuilder.Entity<vCurrencyRateAvg>(entity =>
        {
            entity.ToView("vCurrencyRateAvg");
        });

        modelBuilder.Entity<vDeliveryItemStatusReport>(entity =>
        {
            entity.ToView("vDeliveryItemStatusReport");
        });

        modelBuilder.Entity<vDeliveryStatusReport>(entity =>
        {
            entity.ToView("vDeliveryStatusReport");
        });

        modelBuilder.Entity<vDetallePedidosFulltex>(entity =>
        {
            entity.ToView("vDetallePedidosFulltex");
        });

        modelBuilder.Entity<vDetallePedidosTarot>(entity =>
        {
            entity.ToView("vDetallePedidosTarot");
        });

        modelBuilder.Entity<vDeudaDirectos>(entity =>
        {
            entity.ToView("vDeudaDirectos");
        });

        modelBuilder.Entity<vDeudaTarot>(entity =>
        {
            entity.ToView("vDeudaTarot");
        });

        modelBuilder.Entity<vDeudaTarotComma>(entity =>
        {
            entity.ToView("vDeudaTarotComma");
        });

        modelBuilder.Entity<vDolarIntermedio>(entity =>
        {
            entity.ToView("vDolarIntermedio");
        });

        modelBuilder.Entity<vIntransitToOrganizationUnit>(entity =>
        {
            entity.ToView("vIntransitToOrganizationUnit");
        });

        modelBuilder.Entity<vItemNotaDeCredito>(entity =>
        {
            entity.ToView("vItemNotaDeCredito");
        });

        modelBuilder.Entity<vItemNotaDeCredito20220120>(entity =>
        {
            entity.ToView("vItemNotaDeCredito20220120");
        });

        modelBuilder.Entity<vItemNotaDeCredito20230721>(entity =>
        {
            entity.ToView("vItemNotaDeCredito20230721");
        });

        modelBuilder.Entity<vItemRemito>(entity =>
        {
            entity.ToView("vItemRemito");
        });

        modelBuilder.Entity<vMinoristaFamilia>(entity =>
        {
            entity.ToView("vMinoristaFamilia");
        });

        modelBuilder.Entity<vNotaDeCredito>(entity =>
        {
            entity.ToView("vNotaDeCredito");
        });

        modelBuilder.Entity<vNotaDeCredito20220120>(entity =>
        {
            entity.ToView("vNotaDeCredito20220120");
        });

        modelBuilder.Entity<vOrganizationUnitForMoveOrder>(entity =>
        {
            entity.ToView("vOrganizationUnitForMoveOrder");
        });

        modelBuilder.Entity<vPackingList>(entity =>
        {
            entity.ToView("vPackingList");
        });

        modelBuilder.Entity<vPayment>(entity =>
        {
            entity.ToView("vPayment");
        });

        modelBuilder.Entity<vPriceList>(entity =>
        {
            entity.ToView("vPriceList");
        });

        modelBuilder.Entity<vPriceListForStock>(entity =>
        {
            entity.ToView("vPriceListForStock");
        });

        modelBuilder.Entity<vPriceListForVenta>(entity =>
        {
            entity.ToView("vPriceListForVenta");
        });

        modelBuilder.Entity<vProductAvailableForPicking>(entity =>
        {
            entity.ToView("vProductAvailableForPicking");
        });

        modelBuilder.Entity<vProductBusinessUnitInventoryAndSoftCommitted>(entity =>
        {
            entity.ToView("vProductBusinessUnitInventoryAndSoftCommitted");
        });

        modelBuilder.Entity<vProductBusinessUnitSoftCommitted>(entity =>
        {
            entity.ToView("vProductBusinessUnitSoftCommitted");
        });

        modelBuilder.Entity<vProductFamilyActive>(entity =>
        {
            entity.ToView("vProductFamilyActive");
        });

        modelBuilder.Entity<vProductGroup>(entity =>
        {
            entity.ToView("vProductGroup");
        });

        modelBuilder.Entity<vProductInventoryAndSoftCommitted>(entity =>
        {
            entity.ToView("vProductInventoryAndSoftCommitted");
        });

        modelBuilder.Entity<vProductLabelTypeCustomerDeliveryCode>(entity =>
        {
            entity.ToView("vProductLabelTypeCustomerDeliveryCode");
        });

        modelBuilder.Entity<vProductSoftCommitted>(entity =>
        {
            entity.ToView("vProductSoftCommitted");
        });

        modelBuilder.Entity<vProductSoftCommittedDetail>(entity =>
        {
            entity.ToView("vProductSoftCommittedDetail");
        });

        modelBuilder.Entity<vProductWareHouseInventoryAndSoftCommitted>(entity =>
        {
            entity.ToView("vProductWareHouseInventoryAndSoftCommitted");
        });

        modelBuilder.Entity<vProductWithBOM>(entity =>
        {
            entity.ToView("vProductWithBOM");
        });

        modelBuilder.Entity<vPurchaseOrderTotal>(entity =>
        {
            entity.ToView("vPurchaseOrderTotal");
        });

        modelBuilder.Entity<vReceipt>(entity =>
        {
            entity.ToView("vReceipt");
        });

        modelBuilder.Entity<vReceiptApplied>(entity =>
        {
            entity.ToView("vReceiptApplied");
        });

        modelBuilder.Entity<vReceiptAppliedAux>(entity =>
        {
            entity.ToView("vReceiptAppliedAux");
        });

        modelBuilder.Entity<vReceiptAppliedInCurrency>(entity =>
        {
            entity.ToView("vReceiptAppliedInCurrency");
        });

        modelBuilder.Entity<vReceiptSumByCurrency>(entity =>
        {
            entity.ToView("vReceiptSumByCurrency");
        });

        modelBuilder.Entity<vReceiptSumByCurrencyHasta20240905>(entity =>
        {
            entity.ToView("vReceiptSumByCurrencyHasta20240905");
        });

        modelBuilder.Entity<vReceiptValue>(entity =>
        {
            entity.ToView("vReceiptValue");
        });

        modelBuilder.Entity<vReceiptValuePart>(entity =>
        {
            entity.ToView("vReceiptValuePart");
        });

        modelBuilder.Entity<vRemito>(entity =>
        {
            entity.ToView("vRemito");
        });

        modelBuilder.Entity<vRemitoTotal>(entity =>
        {
            entity.ToView("vRemitoTotal");
        });

        modelBuilder.Entity<vRemitoTotal20210514>(entity =>
        {
            entity.ToView("vRemitoTotal20210514");
        });

        modelBuilder.Entity<vRemitoTotal20220826>(entity =>
        {
            entity.ToView("vRemitoTotal20220826");
        });

        modelBuilder.Entity<vRemitoTotal20220923>(entity =>
        {
            entity.ToView("vRemitoTotal20220923");
        });

        modelBuilder.Entity<vRemitoTotal20230529>(entity =>
        {
            entity.ToView("vRemitoTotal20230529");
        });

        modelBuilder.Entity<vRemitoTotalComisiones>(entity =>
        {
            entity.ToView("vRemitoTotalComisiones");
        });

        modelBuilder.Entity<vRemitoTotalConSaleRetail>(entity =>
        {
            entity.ToView("vRemitoTotalConSaleRetail");
        });

        modelBuilder.Entity<vRemitoTotalHAsta20220901>(entity =>
        {
            entity.ToView("vRemitoTotalHAsta20220901");
        });

        modelBuilder.Entity<vRemitoTotalOriginal>(entity =>
        {
            entity.ToView("vRemitoTotalOriginal");
        });

        modelBuilder.Entity<vReportReceiptApplied>(entity =>
        {
            entity.ToView("vReportReceiptApplied");
        });

        modelBuilder.Entity<vReportReceiptAppliedHasta20240823>(entity =>
        {
            entity.ToView("vReportReceiptAppliedHasta20240823");
        });

        modelBuilder.Entity<vReportRemitoTotal>(entity =>
        {
            entity.ToView("vReportRemitoTotal");

            entity.Property(e => e.FechaPedido).IsFixedLength();
            entity.Property(e => e.FechaRemito).IsFixedLength();
        });

        modelBuilder.Entity<vReportRemitoTotal20220120>(entity =>
        {
            entity.ToView("vReportRemitoTotal20220120");

            entity.Property(e => e.FechaPedido).IsFixedLength();
            entity.Property(e => e.FechaRemito).IsFixedLength();
        });

        modelBuilder.Entity<vReportRemitoTotalFamiliaMes>(entity =>
        {
            entity.ToView("vReportRemitoTotalFamiliaMes");
        });

        modelBuilder.Entity<vReportRemitoTotalSinProducto>(entity =>
        {
            entity.ToView("vReportRemitoTotalSinProducto");

            entity.Property(e => e.FechaPedido).IsFixedLength();
            entity.Property(e => e.FechaRemito).IsFixedLength();
        });

        modelBuilder.Entity<vReporteClientesTarot>(entity =>
        {
            entity.ToView("vReporteClientesTarot");
        });

        modelBuilder.Entity<vSaleDelivery>(entity =>
        {
            entity.ToView("vSaleDelivery");
        });

        modelBuilder.Entity<vSaleDeliveryItem>(entity =>
        {
            entity.ToView("vSaleDeliveryItem");
        });

        modelBuilder.Entity<vSaleDeliveryNote>(entity =>
        {
            entity.ToView("vSaleDeliveryNote");
        });

        modelBuilder.Entity<vSaleDeliveryNoteItem>(entity =>
        {
            entity.ToView("vSaleDeliveryNoteItem");
        });

        modelBuilder.Entity<vSaleDeliveryNoteTotal>(entity =>
        {
            entity.ToView("vSaleDeliveryNoteTotal");
        });

        modelBuilder.Entity<vSaleOrderApprovalDate>(entity =>
        {
            entity.ToView("vSaleOrderApprovalDate");
        });

        modelBuilder.Entity<vSaleOrderDetail>(entity =>
        {
            entity.ToView("vSaleOrderDetail");
        });

        modelBuilder.Entity<vSaleOrderDetail20240827>(entity =>
        {
            entity.ToView("vSaleOrderDetail20240827");
        });

        modelBuilder.Entity<vSaleOrderDetailHasta20240411>(entity =>
        {
            entity.ToView("vSaleOrderDetailHasta20240411");
        });

        modelBuilder.Entity<vSaleOrderItem_SaleDeliveryItem>(entity =>
        {
            entity.ToView("vSaleOrderItem_SaleDeliveryItem");
        });

        modelBuilder.Entity<vSaleOrderTask>(entity =>
        {
            entity.ToView("vSaleOrderTask");
        });

        modelBuilder.Entity<vSaleOrderTaskApprovals>(entity =>
        {
            entity.ToView("vSaleOrderTaskApprovals");
        });

        modelBuilder.Entity<vSaleOrderTraceability>(entity =>
        {
            entity.ToView("vSaleOrderTraceability");
        });

        modelBuilder.Entity<vSaleRetail>(entity =>
        {
            entity.ToView("vSaleRetail");
        });

        modelBuilder.Entity<vSaleRetailItem>(entity =>
        {
            entity.ToView("vSaleRetailItem");
        });

        modelBuilder.Entity<vSaleRetailItemGrouped>(entity =>
        {
            entity.ToView("vSaleRetailItemGrouped");
        });

        modelBuilder.Entity<vSaleRetailValue>(entity =>
        {
            entity.ToView("vSaleRetailValue");
        });

        modelBuilder.Entity<vStockActual>(entity =>
        {
            entity.ToView("vStockActual");
        });

        modelBuilder.Entity<vStockActualValorizado>(entity =>
        {
            entity.ToView("vStockActualValorizado");
        });

        modelBuilder.Entity<vStockActualVenta>(entity =>
        {
            entity.ToView("vStockActualVenta");
        });

        modelBuilder.Entity<vStockAnalysis>(entity =>
        {
            entity.ToView("vStockAnalysis");
        });

        modelBuilder.Entity<vStockCostoyVenta>(entity =>
        {
            entity.ToView("vStockCostoyVenta");
        });

        modelBuilder.Entity<vTask>(entity =>
        {
            entity.ToView("vTask");
        });

        modelBuilder.Entity<vTaskApprovals>(entity =>
        {
            entity.ToView("vTaskApprovals");
        });

        modelBuilder.Entity<vThirdParty>(entity =>
        {
            entity.ToView("vThirdParty");
        });

        modelBuilder.Entity<vThirdPartyFulltex>(entity =>
        {
            entity.ToView("vThirdPartyFulltex");
        });

        modelBuilder.Entity<vThirdPartyTarot>(entity =>
        {
            entity.ToView("vThirdPartyTarot");
        });

        modelBuilder.Entity<vTotalSaleDeliveryItem>(entity =>
        {
            entity.ToView("vTotalSaleDeliveryItem");
        });

        modelBuilder.Entity<vTripItemsReport>(entity =>
        {
            entity.ToView("vTripItemsReport");
        });

        modelBuilder.Entity<vTripReport>(entity =>
        {
            entity.ToView("vTripReport");
        });

        modelBuilder.Entity<vUnReadMessage>(entity =>
        {
            entity.ToView("vUnReadMessage");
        });

        modelBuilder.Entity<vUserMenu>(entity =>
        {
            entity.ToView("vUserMenu");
        });

        modelBuilder.Entity<vUserMenuItems>(entity =>
        {
            entity.ToView("vUserMenuItems");
        });

        modelBuilder.Entity<vVendorPayment>(entity =>
        {
            entity.ToView("vVendorPayment");
        });

        modelBuilder.Entity<vVendorPaymentSumByCurrency>(entity =>
        {
            entity.ToView("vVendorPaymentSumByCurrency");
        });

        modelBuilder.Entity<vVentasTaffeta>(entity =>
        {
            entity.ToView("vVentasTaffeta");
        });

        modelBuilder.Entity<vVoucher>(entity =>
        {
            entity.ToView("vVoucher");
        });

        modelBuilder.Entity<vWithdrawalOrderItem>(entity =>
        {
            entity.ToView("vWithdrawalOrderItem");
        });

        modelBuilder.Entity<xCobranzaPorVendorFecha>(entity =>
        {
            entity.ToView("xCobranzaPorVendorFecha");
        });

        modelBuilder.Entity<xCobranzaPorVendorPeriodo>(entity =>
        {
            entity.ToView("xCobranzaPorVendorPeriodo");
        });

        modelBuilder.Entity<xReceiptDataStudio>(entity =>
        {
            entity.ToView("xReceiptDataStudio");
        });

        modelBuilder.Entity<xReportRemitoTotalDataStudio>(entity =>
        {
            entity.Property(e => e.FechaPedido).IsFixedLength();
            entity.Property(e => e.FechaRemito).IsFixedLength();
        });

        modelBuilder.Entity<xVentasCobranzaPorVendorFecha>(entity =>
        {
            entity.ToView("xVentasCobranzaPorVendorFecha");

            entity.Property(e => e.Fecha).IsFixedLength();
        });

        modelBuilder.Entity<xVentasCobranzaPorVendorPeriodo>(entity =>
        {
            entity.ToView("xVentasCobranzaPorVendorPeriodo");
        });

        modelBuilder.Entity<xVentasPorVendorFecha>(entity =>
        {
            entity.ToView("xVentasPorVendorFecha");

            entity.Property(e => e.Fecha).IsFixedLength();
        });

        modelBuilder.Entity<xVentasPorVendorPeriodo>(entity =>
        {
            entity.ToView("xVentasPorVendorPeriodo");
        });

        modelBuilder.Entity<zDelete>(entity =>
        {
            entity.ToView("zDelete");
        });

        modelBuilder.Entity<zRV>(entity =>
        {
            entity.ToView("zRV");
        });

        modelBuilder.Entity<zViejavPurchaseOrderTotal>(entity =>
        {
            entity.ToView("zViejavPurchaseOrderTotal");
        });

        modelBuilder.Entity<zvDeliveryItemStatusReportORIG>(entity =>
        {
            entity.ToView("zvDeliveryItemStatusReportORIG");
        });

        modelBuilder.Entity<zvDeliveryStatusReportORIG>(entity =>
        {
            entity.ToView("zvDeliveryStatusReportORIG");
        });

        modelBuilder.Entity<zvItemNotaDeCredito20180326>(entity =>
        {
            entity.ToView("zvItemNotaDeCredito20180326");
        });

        modelBuilder.Entity<zvNotaDeCredito20180326>(entity =>
        {
            entity.ToView("zvNotaDeCredito20180326");
        });

        modelBuilder.Entity<zvRemito20210224>(entity =>
        {
            entity.ToView("zvRemito20210224");
        });

        modelBuilder.Entity<zvRemitoTotal20191108>(entity =>
        {
            entity.ToView("zvRemitoTotal20191108");
        });

        modelBuilder.Entity<zvReportRemitoTotal20210224>(entity =>
        {
            entity.ToView("zvReportRemitoTotal20210224");

            entity.Property(e => e.FechaPedido).IsFixedLength();
            entity.Property(e => e.FechaRemito).IsFixedLength();
        });

        modelBuilder.Entity<zvStockActual20201110>(entity =>
        {
            entity.ToView("zvStockActual20201110");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
