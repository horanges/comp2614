using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class MainForm : Form
    {
        ToolTip toolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;

            toolTip.ShowAlways = true;

            labelMessage.Text = string.Empty;
        }

        // if the date is valid, the message will be green 'Valid' and if invalid, the message will be red 'Invalid'
        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            if (DateValidator.Validate(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text))
            {
                labelMessage.Text = "Valid";
                labelMessage.ForeColor = Color.Green;
                toolTip.SetToolTip(this.labelMessage, "Entered Date is Valid");
            }
            else
            {
                labelMessage.Text = "Invalid";
                labelMessage.ForeColor = Color.Red;
                toolTip.SetToolTip(this.labelMessage, "Entered Date is NOT Valid");
            }
        }
        
        // selects all text when tabbed
        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            textBoxYear.SelectAll();
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            textBoxMonth.SelectAll();
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            textBoxDay.SelectAll();
        }
    }
}
