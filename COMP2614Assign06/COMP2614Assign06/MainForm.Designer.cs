namespace COMP2614Assign06
{
    partial class MainForm
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelYtdSalesTotal = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxConfirmDeletion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(24, 26);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(943, 270);
            this.dataGridViewClients.TabIndex = 1;
            this.dataGridViewClients.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(885, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "&Edit Record";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // labelYtdSalesTotal
            // 
            this.labelYtdSalesTotal.AutoSize = true;
            this.labelYtdSalesTotal.Location = new System.Drawing.Point(21, 317);
            this.labelYtdSalesTotal.Name = "labelYtdSalesTotal";
            this.labelYtdSalesTotal.Size = new System.Drawing.Size(0, 13);
            this.labelYtdSalesTotal.TabIndex = 0;
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Location = new System.Drawing.Point(193, 317);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(0, 13);
            this.labelCreditHoldCount.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(780, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Add Record";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(690, 312);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "&Delete Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBoxConfirmDeletion
            // 
            this.checkBoxConfirmDeletion.AutoSize = true;
            this.checkBoxConfirmDeletion.Location = new System.Drawing.Point(581, 316);
            this.checkBoxConfirmDeletion.Name = "checkBoxConfirmDeletion";
            this.checkBoxConfirmDeletion.Size = new System.Drawing.Size(103, 17);
            this.checkBoxConfirmDeletion.TabIndex = 3;
            this.checkBoxConfirmDeletion.Text = "&Confirm Deletion";
            this.checkBoxConfirmDeletion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 347);
            this.Controls.Add(this.checkBoxConfirmDeletion);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.labelYtdSalesTotal);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "COMP2614Assign06";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelYtdSalesTotal;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxConfirmDeletion;
    }
}

