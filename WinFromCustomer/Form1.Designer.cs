namespace WinFromCustomer
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
            this.ddlCustType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlCustType
            // 
            this.ddlCustType.FormattingEnabled = true;
            this.ddlCustType.Location = new System.Drawing.Point(72, 53);
            this.ddlCustType.Name = "ddlCustType";
            this.ddlCustType.Size = new System.Drawing.Size(121, 21);
            this.ddlCustType.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.CausesValidation = false;
            this.Type.Location = new System.Drawing.Point(28, 60);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 348);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ddlCustType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCustType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Type;
    }
}

