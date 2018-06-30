namespace RealNorthwindWinFormClient
{
    partial class ProductSearch
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
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.labelPName = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(77, 101);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(76, 20);
            this.textBoxProductId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Id:";
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(159, 99);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(58, 23);
            this.buttonProductSearch.TabIndex = 3;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPName.Location = new System.Drawing.Point(22, 57);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(127, 20);
            this.labelPName.TabIndex = 4;
            this.labelPName.Text = "Product Name:";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(548, 219);
            this.dataGridViewProducts.TabIndex = 5;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            this.dataGridViewProducts.DoubleClick += new System.EventHandler(this.dataGridViewProducts_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(404, 367);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.dataGridViewProducts_DoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(485, 367);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(323, 367);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product ID:";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(134, 32);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(83, 20);
            this.labelProductID.TabIndex = 10;
            this.labelProductID.Text = "<<<id>>>";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(155, 57);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(160, 20);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "<<Product name>>";
            // 
            // ProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 405);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelPName);
            this.Controls.Add(this.buttonProductSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductId);
            this.Name = "ProductSearch";
            this.Text = "ProductDisplayForm";
            this.Load += new System.EventHandler(this.ProductSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelProductName;
    }
}

