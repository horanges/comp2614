using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>  
    ///  Invoice class  
    /// </summary>
    class Invoice
    {
        private string invoiceNumber;
        private DateTime invoiceDate;
        private int discountPercentage;
        private int discountPeriodDays;
        private List<Item> items;

        const decimal GST = 0.05M;
        const decimal PST = 0.07M;
        const int CONVERT_PERCENT = 100;

        /// <summary>  
        ///  Constructor for Invoice class 
        /// </summary> 
        public Invoice(string invoiceNumber, DateTime invoiceDate, int discountPercentage, int discountPeriodDays, List<Item> items)
        {
            this.invoiceNumber = invoiceNumber;
            this.invoiceDate = invoiceDate;
            this.discountPercentage = discountPercentage;
            this.discountPeriodDays = discountPeriodDays;
            this.items = new List<Item> (items);
        }

        /// <summary>  
        ///  Invoice number for the invoice
        /// </summary> 
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

        /// <summary>  
        ///  Invoice date for the invoice
        /// </summary> 
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        /// <summary>  
        ///  Discount percentage for the invoice (max 9)
        /// </summary> 
        public int DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }

        /// <summary>  
        ///  Discount period for the invoice in days (min 10)
        /// </summary> 
        public int DiscountPeriodDays
        {
            get { return discountPeriodDays; }
            set { discountPeriodDays = value; }
        }

        /// <summary>  
        ///  List of items for the invoice
        /// </summary> 
        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        /// <summary>  
        ///  Get the discount date by adding invoice date with discount period
        /// </summary> 
        public DateTime DiscountDate
        {
            get { return invoiceDate.AddDays(discountPeriodDays); }
        }

        /// <summary>  
        ///  Get the subtotal by adding extended price from items
        /// </summary> 
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0;
                foreach (Item item in items)
                {
                    subtotal += item.ExtendedPrice;
                }
                return subtotal;
            }
        }

        /// <summary>  
        ///  Calculates the GST
        /// </summary> 
        public decimal Gst
        {
            get { return Subtotal * GST; }
        }

        /// <summary>  
        ///  Calculates the PST if taxable is true
        /// </summary> 
        public decimal Pst
        {
            get
            {
                decimal pst = 0;
                foreach (Item item in items)
                {
                    if (item.Taxable)
                    {
                        pst += (item.ExtendedPrice * PST);
                    }
                }
                return pst;
            }
        }

        /// <summary>  
        ///  Calculates total price
        /// </summary> 
        public decimal Total
        {
            get { return Subtotal + Gst + Pst; }
        }

        /// <summary>  
        ///  Calculates discount amount
        /// </summary>  
        public decimal Discount
        {
            get { return ((decimal)discountPercentage / CONVERT_PERCENT) * Total; }
        }

        /// <summary>  
        ///  Overrides ToString() 
        /// </summary>  
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", 
                   this.invoiceNumber, this.invoiceDate, this.discountPercentage, this.discountPeriodDays, this.items);
        }

    }
}
