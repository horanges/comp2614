using BusinessLib.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
    public partial class ClientEditDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }

        public ClientEditDialog()
        {
            InitializeComponent();
        }

        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }

        private void setBindings()
        {
            maskedTextBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            maskedTextBoxProvince.DataBindings.Add("Text", ClientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            maskedTextBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYtdSales.DataBindings.Add("Text", ClientVM, "YtdSales", false, DataSourceUpdateMode.OnValidation, "");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorMessage;

            errorProvider.SetError(buttonOk, "");

            if (ClientValidation.Validate(ClientVM.GetDisplayClient()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                errorMessage = ClientValidation.ErrorMessage;
                errorProvider.SetError(buttonOk, errorMessage);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
