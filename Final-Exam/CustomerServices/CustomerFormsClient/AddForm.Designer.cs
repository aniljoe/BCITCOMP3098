namespace CustomerFormsClient
{
    partial class AddForm
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
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.buttonDeleteConfirm = new System.Windows.Forms.Button();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(272, 38);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(277, 22);
            this.textBoxCustomerId.TabIndex = 0;
            // 
            // buttonDeleteConfirm
            // 
            this.buttonDeleteConfirm.Location = new System.Drawing.Point(261, 334);
            this.buttonDeleteConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteConfirm.Name = "buttonDeleteConfirm";
            this.buttonDeleteConfirm.Size = new System.Drawing.Size(188, 28);
            this.buttonDeleteConfirm.TabIndex = 1;
            this.buttonDeleteConfirm.Text = "OK";
            this.buttonDeleteConfirm.UseVisualStyleBackColor = true;
            this.buttonDeleteConfirm.Click += new System.EventHandler(this.buttonDeleteConfirm_Click);
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(33, 38);
            this.labelCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(83, 17);
            this.labelCustomerId.TabIndex = 2;
            this.labelCustomerId.Text = "Customer Id";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(272, 97);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(277, 22);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(272, 164);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(277, 22);
            this.textBoxCustomerName.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(272, 230);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(277, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(36, 97);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(36, 164);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(109, 17);
            this.labelCustomerName.TabIndex = 7;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(39, 234);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 388);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.buttonDeleteConfirm);
            this.Controls.Add(this.textBoxCustomerId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.Text = "Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button buttonDeleteConfirm;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelEmail;
    }
}