using System;
namespace DebeHaber.API.Models
{
    public class AccountMovement
    {
        public enum AccountTypes { AccountPayable = 1, AccountReceivable = 2, Sales = 3 }
        public enum PaymentTypes { AccountPayable = 1, AccountReceivable = 2, Sales = 3 }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public AccountTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the payment.
        /// </summary>
        /// <value>The type of the payment.</value>
        public PaymentTypes PaymentType { get; set; }

        /// <summary>
        /// Gets or sets the local identifier.
        /// </summary>
        /// <value>The local identifier.</value>
        public int LocalID { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        public int CloudID { get; set; }

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
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the reference invoice.
        /// </summary>
        /// <value>The reference invoice.</value>
        public string ReferenceInvoice { get; set; }

        /// <summary>
        /// Gets or sets the reference invoice identifier.
        /// </summary>
        /// <value>The reference invoice identifier.</value>
        public int? ReferenceInvoiceID { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        public decimal CurrencyRate { get; set; }

        /// <summary>
        /// Gets or sets the debit.
        /// </summary>
        /// <value>The debit.</value>
        public decimal Debit { get; set; }

        /// <summary>
        /// Gets or sets the credit.
        /// </summary>
        /// <value>The credit.</value>
        public decimal Credit { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }
    }
}
