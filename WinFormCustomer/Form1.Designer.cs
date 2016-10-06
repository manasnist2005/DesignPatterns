namespace WinFormCustomer
{
    partial class Form1
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
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhNumber = new System.Windows.Forms.TextBox();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.ddltype = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(354, 65);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(223, 20);
            this.txtCustName.TabIndex = 0;
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(354, 140);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(223, 20);
            this.txtBillAmt.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(354, 223);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 109);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhNumber
            // 
            this.txtPhNumber.Location = new System.Drawing.Point(70, 140);
            this.txtPhNumber.Name = "txtPhNumber";
            this.txtPhNumber.Size = new System.Drawing.Size(223, 20);
            this.txtPhNumber.TabIndex = 3;
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(70, 223);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtBillDate.TabIndex = 4;
            // 
            // ddltype
            // 
            this.ddltype.FormattingEnabled = true;
            this.ddltype.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.ddltype.Location = new System.Drawing.Point(70, 65);
            this.ddltype.Name = "ddltype";
            this.ddltype.Size = new System.Drawing.Size(121, 21);
            this.ddltype.TabIndex = 5;
            this.ddltype.SelectedIndexChanged += new System.EventHandler(this.ddltype_SelectedIndexChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(70, 309);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "button1";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.ddltype);
            this.Controls.Add(this.dtBillDate);
            this.Controls.Add(this.txtPhNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBillAmt);
            this.Controls.Add(this.txtCustName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhNumber;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.ComboBox ddltype;
        private System.Windows.Forms.Button btnValidate;
    }
}

