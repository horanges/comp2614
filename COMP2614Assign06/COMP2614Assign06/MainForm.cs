using System;
using BusinessLib.Business;
using BusinessLib.Common;
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
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clientVM = new ClientViewModel(ClientValidation.GetClient());
            setBindings();
            setupDataGridView();
            totalYtdSales();
            creditHoldCount();
        }

        private void setBindings()
        {
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        private void setupDataGridView()
        {
            // Configure for read-only
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // Add columns
            DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn();
            clientCode.Name = "clientCode";
            clientCode.DataPropertyName = "ClientCode";
            clientCode.HeaderText = "ClientCode";
            clientCode.Width = 80;
            clientCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            clientCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(clientCode);

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "CompanyName";
            companyName.Width = 120;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address1";
            address1.Width = 110;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address2";
            address2.Width = 70;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 80;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 70;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "PostalCode";
            postalCode.Width = 80;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
            ytdSales.Name = "ytdSales";
            ytdSales.DataPropertyName = "YtdSales";
            ytdSales.HeaderText = "YtdSales";
            ytdSales.Width = 70;
            ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewTextBoxColumn creditHold = new DataGridViewTextBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "CreditHold";
            creditHold.Width = 70;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);


            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 150;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            clientVM.SetDisplayClient(clientVM.Clients[index]);

            ClientEditDialog dlg = new ClientEditDialog();
            dlg.ClientVM = clientVM;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                clientVM.SaveClient(index);
                clientVM.Clients.ResetItem(index);
            }

            dlg.Dispose();

            totalYtdSales();
            creditHoldCount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());

            ClientEditDialog dlg = new ClientEditDialog();
            dlg.ClientVM = clientVM;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ClientValidation.AddClient(clientVM.GetDisplayClient());
                clientVM.Clients = ClientValidation.GetClient();
                dataGridViewClients.DataSource = clientVM.Clients;
            }

            dlg.Dispose();

            totalYtdSales();
            creditHoldCount();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkBoxConfirmDeletion.Checked)
            {
                if (MessageBox.Show("Are you sure you want to delete this client?","Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteClient();
                }
            }
            else
            {
                deleteClient();
            }

        }

        private void deleteClient()
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                ClientValidation.DeleteClient(clientVM.Clients[index]);

                clientVM.Clients = ClientValidation.GetClient();
                dataGridViewClients.DataSource = clientVM.Clients;
                totalYtdSales();
                creditHoldCount();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalYtdSales()
        {
            decimal totalYtdSales = clientVM.Clients.TotalYtdSales;
            labelYtdSalesTotal.Text = "Total YTD Sales: $ " + totalYtdSales.ToString("N");
        }

        private void creditHoldCount()
        {
            int creditHoldCount = clientVM.Clients.CreditHoldCount;
            labelCreditHoldCount.Text = "Credit Hold Count: " + creditHoldCount.ToString("D");
        }
    }
}
