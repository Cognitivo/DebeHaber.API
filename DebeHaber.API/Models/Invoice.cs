using System;
using System.Collections.Generic;

namespace DebeHaber.API.Models
{
    /// <summary>
    /// Invoice types.
    /// </summary>
    public enum InvoiceTypes 
    { 
        /// <summary>
        /// The purchase.
        /// </summary>
        Purchase = 1, 
        /// <summary>
        /// The purchase return.
        /// </summary>
        PurchaseReturn = 3, 
        /// <summary>
        /// The sales.
        /// </summary>
        Sales = 4, 
        /// <summary>
        /// The sales return.
        /// </summary>
        SalesReturn = 5 
    }

    /// <summary>
    /// Businees center.
    /// </summary>
    public enum BusinesCenter 
    { 
        /// <summary>
        /// Options means that item sold is a service, and thus 100% of income is considered profit.
        /// </summary>
        RevenueByService = 1, 
        /// <summary>
        /// Option means that item sold had an inventory value, and will discount the cost (Cost of Goods Sold) to calculate the profit.
        /// </summary>
        RevenueByInventory = 2, 
        /// <summary>
        /// Options means that item sold is a fixed asset (ex Property, Car, Furniture, etc). This will remove the fixed asset from your system.
        /// </summary>
        FixedAsset = 3 
    }

    public class Invoice
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public InvoiceTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int Local_id { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int? Cloud_id { get; set; }

        /// <summary>
        /// Gets or sets the customer tax identifier.
        /// </summary>
        /// <value>The customer tax identifier.</value>
        public string CustomerTaxID { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the supplier tax identifier.
        /// </summary>
        /// <value>The supplier tax identifier.</value>
        public string SupplierTaxID { get; set; }

        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>The name of the supplier.</value>
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the code expiry in "yyyy-MM-dd" format. This is country specific hence nullable if not required.
        /// </summary>
        /// <value>Date the Code should expire.</value>
        public string CodeExpiry { get; set; }

        /// <summary>
        /// Gets or sets the payment condition.
        /// </summary>
        /// <value>The payment condition.</value>
        public int PaymentCondition { get; set; }

        /// <summary>
        /// Gets or sets the currency code. All currency codes are set to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217 standard.</a>
        /// </summary>
        /// <value>The currency code.</value>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        public decimal CurrencyRate { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>The details.</value>
        public ICollection<InvoiceDetail> Details { get; set; }
    }

        /// <summary>
        /// Invoice detail.
        /// </summary>
    public class InvoiceDetail
    {
            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
        public BusinesCenter Type { get; set; }

            /// <summary>
            /// Gets or sets the VATP ercentage.
            /// </summary>
            /// <value>The VATP ercentage.</value>
        public Int32 VATPercentage { get; set; }

            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            /// <value>The value.</value>
        public decimal Value { get; set; }

            /// <summary>
            /// Gets or sets the cost.
            /// </summary>
            /// <value>The cost.</value>
        public decimal Cost { get; set; }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
        public string Name { get; set; }
    }
}
