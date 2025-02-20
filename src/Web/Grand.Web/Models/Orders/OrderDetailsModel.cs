﻿using Grand.Infrastructure.Models;
using Grand.Web.Models.Common;
using Grand.Web.Models.Media;

namespace Grand.Web.Models.Orders
{
    public class OrderDetailsModel : BaseEntityModel
    {
        public OrderDetailsModel()
        {
            TaxRates = new List<TaxRate>();
            GiftVouchers = new List<GiftVoucher>();
            Items = new List<OrderItemModel>();
            OrderNotes = new List<OrderNote>();
            Shipments = new List<ShipmentBriefModel>();

            BillingAddress = new AddressModel();
            ShippingAddress = new AddressModel();
            PickupAddress = new AddressModel();
            CustomValues = new Dictionary<string, object>();
        }

        public bool PrintMode { get; set; }
        public bool PdfInvoiceDisabled { get; set; }

        public bool UserCanCancelUnpaidOrder { get; set; }

        public DateTime CreatedOn { get; set; }

        public string OrderStatus { get; set; }

        public bool IsReOrderAllowed { get; set; }

        public bool IsMerchandiseReturnAllowed { get; set; }

        public bool IsShippable { get; set; }
        public bool PickUpInStore { get; set; }
        public AddressModel PickupAddress { get; set; }
        public string ShippingStatus { get; set; }
        public AddressModel ShippingAddress { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingAdditionDescription { get; set; }
        public IList<ShipmentBriefModel> Shipments { get; set; }

        public AddressModel BillingAddress { get; set; }

        public string VatNumber { get; set; }
        public int OrderNumber { get; set; }
        public string OrderCode { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodStatus { get; set; }
        public bool CanRePostProcessPayment { get; set; }
        public Dictionary<string, object> CustomValues { get; set; }

        public string OrderSubtotal { get; set; }
        public string OrderSubTotalDiscount { get; set; }
        public string OrderShipping { get; set; }
        public string PaymentMethodAdditionalFee { get; set; }
        public string CheckoutAttributeInfo { get; set; }

        public bool PricesIncludeTax { get; set; }
        public string Tax { get; set; }
        public IList<TaxRate> TaxRates { get; set; }
        public bool DisplayTax { get; set; }
        public bool DisplayTaxRates { get; set; }

        public string OrderTotalDiscount { get; set; }
        public int RedeemedLoyaltyPoints { get; set; }
        public string RedeemedLoyaltyPointsAmount { get; set; }
        public string OrderTotal { get; set; }

        public IList<GiftVoucher> GiftVouchers { get; set; }

        public bool ShowSku { get; set; }
        public IList<OrderItemModel> Items { get; set; }

        public IList<OrderNote> OrderNotes { get; set; }

        public bool ShowAddOrderNote { get; set; }

        #region Nested Classes

        public class OrderItemModel : BaseEntityModel
        {
            public OrderItemModel()
            {
                Picture = new PictureModel();
            }
            public Guid OrderItemGuid { get; set; }
            public string Sku { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public PictureModel Picture { get; set; }
            public string UnitPrice { get; set; }
            public double UnitPriceValue { get; set; }
            public string UnitPriceWithoutDiscount { get; set; }
            public double UnitPriceWithoutDiscountValue { get; set; }
            public string SubTotal { get; set; }
            public string Discount { get; set; }
            public int Quantity { get; set; }
            public string AttributeInfo { get; set; }
            public string RentalInfo { get; set; }

            //downloadable product properties
            public string DownloadId { get; set; }
            public string LicenseId { get; set; }
        }

        public class TaxRate : BaseModel
        {
            public string Rate { get; set; }
            public string Value { get; set; }
        }

        public class GiftVoucher : BaseModel
        {
            public string CouponCode { get; set; }
            public string Amount { get; set; }
        }

        public class OrderNote : BaseEntityModel
        {
            public bool HasDownload { get; set; }
            public string Note { get; set; }
            public DateTime CreatedOn { get; set; }
            public string OrderId { get; set; }
        }

        public class ShipmentBriefModel : BaseEntityModel
        {
            public string TrackingNumber { get; set; }
            public int ShipmentNumber { get; set; }
            public DateTime? ShippedDate { get; set; }
            public DateTime? DeliveryDate { get; set; }
        }
        #endregion
    }
}