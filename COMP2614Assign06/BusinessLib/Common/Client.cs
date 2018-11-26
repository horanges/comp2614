using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common
{
    // Client attributes
    public class Client
    {
        private string clientCode;
        private string companyName;
        private string address1;
        private string address2;
        private string city;
        private string province;
        private string postalCode;
        private decimal ytdSales;
        private bool creditHold;
        private string notes;

        public Client()
        {

        }

        public Client(string clientCode,
                        string companyName,
                        string address1,
                        string address2,
                        string city,
                        string province,
                        string postalCode,
                        decimal ytdSales,
                        bool creditHold,
                        string notes)
        {
            this.clientCode = clientCode;
            this.companyName = companyName;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
            this.ytdSales = ytdSales;
            this.creditHold = creditHold;
            this.notes = notes;
        }

        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public decimal YtdSales
        {
            get { return ytdSales; }
            set { ytdSales = value; }
        }

        public bool CreditHold
        {
            get { return creditHold; }
            set { creditHold = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
    }
}
