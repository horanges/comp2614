using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>  
    ///  Item class  
    /// </summary>  
    class Item
    {
        private int quantity;
        private string sku;
        private string description;
        private decimal price;
        private bool taxable;
        
        /// <summary>  
        ///  Constructor for Item class 
        /// </summary>  
        public Item(int quantity, string sku, string description, decimal price, bool taxable)
        {
            this.quantity = quantity;
            this.sku = sku;
            this.description = description;
            this.price = price;
            this.taxable = taxable;
        }

        /// <summary>  
        ///  Quantity of the item  
        /// </summary>  
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>  
        ///  SKU of the item  
        /// </summary>  
        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>  
        ///  Description of the item  
        /// </summary>  
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>  
        ///  Price of the item  
        /// </summary>  
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>  
        ///  Whether or not the item is taxable  
        /// </summary>  
        public bool Taxable
        {
            get { return taxable; }
            set { taxable = value; }
        }

        /// <summary>  
        ///  Extended price of the item (quantity * price)  
        /// </summary>  
        public decimal ExtendedPrice
        {
            get { return quantity * price; }
        }

        /// <summary>  
        ///  Overrides ToString() 
        /// </summary>  
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", this.quantity, this.sku, this.description, this.price, this.taxable, ExtendedPrice);
        }
    }
}
