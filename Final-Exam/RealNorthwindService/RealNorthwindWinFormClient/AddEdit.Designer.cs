namespace RealNorthwindWinFormClient
{
    partial class AddEdit
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxQuanityPerUnit = new System.Windows.Forms.TextBox();
            this.textBoxUnitPerPrice = new System.Windows.Forms.TextBox();
            this.buttonContext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDiscontinued = new System.Windows.Forms.CheckBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(112, 86);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(262, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // textBoxQuanityPerUnit
            // 
            this.textBoxQuanityPerUnit.Location = new System.Drawing.Point(112, 112);
            this.textBoxQuanityPerUnit.Name = "textBoxQuanityPerUnit";
            this.textBoxQuanityPerUnit.Size = new System.Drawing.Size(262, 20);
            this.textBoxQuanityPerUnit.TabIndex = 1;
            // 
            // textBoxUnitPerPrice
            // 
            this.textBoxUnitPerPrice.Location = new System.Drawing.Point(112, 138);
            this.textBoxUnitPerPrice.Name = "textBoxUnitPerPrice";
            this.textBoxUnitPerPrice.Size = new System.Drawing.Size(262, 20);
            this.textBoxUnitPerPrice.TabIndex = 2;
            // 
            // buttonContext
            // 
            this.buttonContext.Location = new System.Drawing.Point(214, 197);
            this.buttonContext.Name = "buttonContext";
            this.buttonContext.Size = new System.Drawing.Size(87, 23);
            this.buttonContext.TabIndex = 4;
            this.buttonContext.Text = "<<button>>";
            this.buttonContext.UseVisualStyleBackColor = true;
            this.buttonContext.Click += new System.EventHandler(this.buttonContext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "QuantityPerUnit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UnitPrice";
            // 
            // checkBoxDiscontinued
            // 
            this.checkBoxDiscontinued.AutoSize = true;
            this.checkBoxDiscontinued.Location = new System.Drawing.Point(112, 165);
            this.checkBoxDiscontinued.Name = "checkBoxDiscontinued";
            this.checkBoxDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.checkBoxDiscontinued.TabIndex = 8;
            this.checkBoxDiscontinued.Text = "Discontinued";
            this.checkBoxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductId.Location = new System.Drawing.Point(109, 40);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(69, 24);
            this.labelProductId.TabIndex = 9;
            this.labelProductId.Text = "<<id>>";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(112, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddEdit
            // 
            this.AcceptButton = this.buttonContext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(389, 255);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.checkBoxDiscontinued);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonContext);
            this.Controls.Add(this.textBoxUnitPerPrice);
            this.Controls.Add(this.textBoxQuanityPerUnit);
            this.Controls.Add(this.textBoxProductName);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.AddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuanityPerUnit;
        private System.Windows.Forms.TextBox textBoxUnitPerPrice;
        private System.Windows.Forms.Button buttonContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDiscontinued;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Button buttonCancel;
    }
}