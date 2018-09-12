using System;
using System.Collections.Generic;

namespace DebeHaber.API
{
    /// <summary>
    /// Use this class to send your data.
    /// </summary>
    public class Send
    {
        /// <summary>
        /// Send to.
        /// </summary>
        public enum SendTo { 
            /// <summary>
            /// The production.
            /// </summary>
            Production, 
            /// <summary>
            /// The playground.
            /// </summary>
            Playground 
        }

        private string API { get; set; }

        private string Url { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DebeHaber.API.Send"/> class.
        /// </summary>
        /// <param name="SendTo">URL.</param>
        /// <param name="API_Key">API key.</param>
        public Send(SendTo SendTo, string API_Key)
        {
            API = API_Key;
            Url = SendTo == SendTo.Production ? "https://www.debehaber.com" : "https://test.debehaber.com";
        }

        /// <summary>
        /// Invoices the specified Sales.
        /// </summary>
        /// <returns>List of Invoices with information of successful sync.</returns>
        /// <param name="Invoices">List of Invoices which can include Sales, Purchases, Credit Notes, and Debit Notes.</param>
        public List<Models.Invoice> Invoices(List<Models.Invoice> Invoices)
        {

            return Invoices;
        }

        /// <summary>
        /// Accounts the movements.
        /// </summary>
        /// <returns>The movements.</returns>
        /// <param name="AccountMovements">Purchases.</param>
        public List<Models.Invoice> AccountMovements(List<Models.Invoice> AccountMovements)
        {

            return AccountMovements;
        }
    }
}
