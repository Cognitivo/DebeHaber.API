using System;
namespace DebeHaber.API.Models
{
    public class FixedAsset
    {

        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int Local_ID { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int Cloud_ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the taxpayer tax identifier.
        /// </summary>
        /// <value>The taxpayer tax identifier.</value>
        public string TaxpayerTaxID { get; set; }

        /// <summary>
        /// Gets or sets the name of the taxpayer.
        /// </summary>
        /// <value>The name of the taxpayer.</value>
        public string TaxpayerName { get; set; }

        /// <summary>
        /// Gets or sets the item code.
        /// </summary>
        /// <value>The item code.</value>
        public string ItemCode { get; set; }

        /// <summary>
        /// Gets or sets the manufacture date.
        /// </summary>
        /// <value>The manufacture date.</value>
        public string ManufactureDate { get; set; }

        /// <summary>
        /// Gets or sets the purchase date.
        /// </summary>
        /// <value>The purchase date.</value>
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets the quantity, default will be one.
        /// </summary>
        /// <value>The quantity.</value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the purchase value.
        /// </summary>
        /// <value>The purchase value.</value>
        public decimal PurchaseValue { get; set; }

        /// <summary>
        /// Gets or sets the current value.
        /// </summary>
        /// <value>The current value.</value>
        public decimal CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the asset group.
        /// </summary>
        /// <value>The asset group.</value>
        public string AssetGroup { get; set; }

        /// <summary>
        /// Gets or sets the life span before depreciating to zero value.
        /// </summary>
        /// <value>The life span.</value>
        public decimal? LifeSpan { get; set; }

    }
}
