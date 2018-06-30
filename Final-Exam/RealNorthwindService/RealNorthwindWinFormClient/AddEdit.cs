using RealNorthwindWinFormClient.ProductServiceRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealNorthwindWinFormClient
{
    public partial class AddEdit : Form
    {
        public Product Product { get; set; }
        public bool EditMode { get; set; }
        public AddEdit(Product product, bool editMode)
        {
            InitializeComponent();
            this.Product = product;
            EditMode = editMode;
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {
            buttonContext.Text = "Save";
            labelProductId.Text = Product.ProductID.ToString();
            textBoxProductName.Text = Product.ProductName;
            textBoxQuanityPerUnit.Text = Product.QuantityPerUnit;
            textBoxUnitPerPrice.Text = Product.UnitPrice.ToString();
        }

        private void buttonContext_Click(object sender, EventArgs e)
        {
            Product = new Product { ProductID = this.Product.ProductID, ProductName =  textBoxProductName.Text.Trim(), UnitPrice = decimal.Parse(textBoxUnitPerPrice.Text), QuantityPerUnit = textBoxQuanityPerUnit.Text};
            this.Close();
        }
    }
}
