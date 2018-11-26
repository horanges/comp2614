using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
    // For displays clients
    public class ClientViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClientViewModel()
        {

        }

        public ClientViewModel(ClientCollection clients)
        {
            this.Clients = clients;
        }

        public string ClientCode
        {
            get { return clientCode; }
            set
            {
                clientCode = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged();
            }
        }

        public string Address1
        {
            get { return address1; }
            set
            {
                address1 = value;
                OnPropertyChanged();
            }
        }

        public string Address2
        {
            get { return address2; }
            set
            {
                address2 = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        public string Province
        {
            get { return province; }
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                postalCode = value;
                OnPropertyChanged();
            }
        }

        public decimal YtdSales
        {
            get { return ytdSales; }
            set
            {
                ytdSales = value;
                OnPropertyChanged();
            }
        }

        public bool CreditHold
        {
            get { return creditHold; }
            set
            {
                creditHold = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        public ClientCollection Clients { get; set; }

        public void SetDisplayClient(Client client)
        {
            this.clientCode = client.ClientCode;
            this.CompanyName = client.CompanyName;
            this.Address1 = client.Address1;
            this.Address2 = client.Address2;
            this.City = client.City;
            this.Province = client.Province;
            this.PostalCode = client.PostalCode;
            this.YtdSales = client.YtdSales;
            this.CreditHold = client.CreditHold;
            this.Notes = client.Notes;
        }

        public Client GetDisplayClient()
        {
            return new Client { ClientCode = this.ClientCode
                              , CompanyName = this.CompanyName
                              , Address1 = this.Address1
                              , Address2 = this.Address2
                              , City = this.City
                              , Province = this.Province
                              , PostalCode = this.PostalCode
                              , YtdSales = this.YtdSales
                              , CreditHold = this.CreditHold
                              , Notes = this.Notes};
        }

        public Client SaveClient(int collectionIndex)
        {
            this.Clients[collectionIndex].ClientCode = this.ClientCode;
            this.Clients[collectionIndex].CompanyName = this.CompanyName;
            this.Clients[collectionIndex].Address1 = this.Address1;
            this.Clients[collectionIndex].Address2 = this.Address2;
            this.Clients[collectionIndex].City = this.City;
            this.Clients[collectionIndex].Province = this.Province;
            this.Clients[collectionIndex].PostalCode = this.PostalCode;
            this.Clients[collectionIndex].YtdSales = this.YtdSales;
            this.Clients[collectionIndex].CreditHold = this.CreditHold;
            this.Clients[collectionIndex].Notes = this.Notes;

            return this.Clients[collectionIndex];
        }
    }
}
