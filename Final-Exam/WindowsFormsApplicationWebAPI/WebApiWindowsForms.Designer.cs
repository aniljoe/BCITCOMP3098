namespace WindowsFormsApplicationWebAPI
{
    partial class WebApiWindowsForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxDiscontinue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(28, 31);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(72, 13);
            this.ProductName.TabIndex = 4;
            this.ProductName.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "QuantityPerUnit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UnitPrice";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(131, 28);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 8;
            // 
            // textBoxQuantityPerUnit
            // 
            this.textBoxQuantityPerUnit.Location = new System.Drawing.Point(131, 53);
            this.textBoxQuantityPerUnit.Name = "textBoxQuantityPerUnit";
            this.textBoxQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantityPerUnit.TabIndex = 9;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(131, 79);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitPrice.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(131, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxDiscontinue
            // 
            this.checkBoxDiscontinue.AutoSize = true;
            this.checkBoxDiscontinue.Location = new System.Drawing.Point(131, 110);
            this.checkBoxDiscontinue.Name = "checkBoxDiscontinue";
            this.checkBoxDiscontinue.Size = new System.Drawing.Size(88, 17);
            this.checkBoxDiscontinue.TabIndex = 13;
            this.checkBoxDiscontinue.Text = "Discontinued";
            this.checkBoxDiscontinue.UseVisualStyleBackColor = true;
            // 
            // WebApiWindowsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.checkBoxDiscontinue);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxQuantityPerUnit);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WebApiWindowsForms";
            this.Text = "WinFormsUsingAPI";
            this.Load += new System.EventHandler(this.WebApiWindowsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantityPerUnit;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxDiscontinue;
    }
}

