using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class Customer
    {
        private string companyName;
        private string city;
        private string province;
        private string postalCode;
        private bool? creditHold;

        public Customer (string companyName, string city, string province, string postalCode, bool? creditHold)
        {
            this.companyName = companyName;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
            this.creditHold = creditHold;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
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

        public bool? CreditHold
        {
            get { return creditHold; }
            set { creditHold = value; }
        }
    }
}
