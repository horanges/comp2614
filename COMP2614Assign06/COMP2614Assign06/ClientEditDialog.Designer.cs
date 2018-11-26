namespace COMP2614Assign06
{
    partial class ClientEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.maskedTextBoxClientCode = new System.Windows.Forms.MaskedTextBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.maskedTextBoxProvince = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxYtdSales = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelYtdSales = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(182, 291);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 19;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(285, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // maskedTextBoxClientCode
            // 
            this.maskedTextBoxClientCode.Location = new System.Drawing.Point(125, 20);
            this.maskedTextBoxClientCode.Mask = ">AAAAA";
            this.maskedTextBoxClientCode.Name = "maskedTextBoxClientCode";
            this.maskedTextBoxClientCode.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxClientCode.TabIndex = 1;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(28, 23);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(64, 13);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "C&lient Code:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(28, 49);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "C&ompany Name:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(28, 75);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "Address&1:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(125, 46);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(235, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(125, 72);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(235, 20);
            this.textBoxAddress1.TabIndex = 5;
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(28, 101);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 6;
            this.labelAddress2.Text = "Address&2:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(125, 98);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(235, 20);
            this.textBoxAddress2.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(125, 124);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(117, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(28, 127);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "&City:";
            // 
            // maskedTextBoxProvince
            // 
            this.maskedTextBoxProvince.Location = new System.Drawing.Point(125, 150);
            this.maskedTextBoxProvince.Mask = ">AA";
            this.maskedTextBoxProvince.Name = "maskedTextBoxProvince";
            this.maskedTextBoxProvince.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBoxProvince.TabIndex = 11;
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(125, 176);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxPostalCode.TabIndex = 13;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(28, 153);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "&Province:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(28, 179);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 12;
            this.labelPostalCode.Text = "Po&stal Code:";
            // 
            // textBoxYtdSales
            // 
            this.textBoxYtdSales.Location = new System.Drawing.Point(125, 202);
            this.textBoxYtdSales.Name = "textBoxYtdSales";
            this.textBoxYtdSales.Size = new System.Drawing.Size(74, 20);
            this.textBoxYtdSales.TabIndex = 15;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(125, 228);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(235, 20);
            this.textBoxNotes.TabIndex = 17;
            // 
            // labelYtdSales
            // 
            this.labelYtdSales.AutoSize = true;
            this.labelYtdSales.Location = new System.Drawing.Point(28, 205);
            this.labelYtdSales.Name = "labelYtdSales";
            this.labelYtdSales.Size = new System.Drawing.Size(61, 13);
            this.labelYtdSales.TabIndex = 14;
            this.labelYtdSales.Text = "&YTD Sales:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(28, 231);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 16;
            this.labelNotes.Text = "&Notes:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(125, 255);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 18;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ClientEditDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(385, 335);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelYtdSales);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxYtdSales);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.maskedTextBoxProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelClientCode);
            this.Controls.Add(this.maskedTextBoxClientCode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientEditDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Edit Dialog";
            this.Load += new System.EventHandler(this.ClientEditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientCode;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProvince;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxYtdSales;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelYtdSales;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}