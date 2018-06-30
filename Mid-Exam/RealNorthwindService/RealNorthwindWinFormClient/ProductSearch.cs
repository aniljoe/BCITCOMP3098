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
    public partial class ProductSearch : Form
    {
        private List<Product> products;

        public ProductSearch()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            ProductServiceClient product = new ProductServiceClient();
            if (!string.IsNullOrWhiteSpace(textBoxProductId.Text))
            {
                int id;
                int.TryParse(textBoxProductId.Text, out id);

                labelPName.Text = product.GetProduct((id)).ProductName;
                products = new List<Product> { product.GetProduct((id)) };
                dataGridViewProducts.DataSource = products;
                UpdateLables();
            }
        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.ReadOnly = true;
            ProductServiceClient product = new ProductServiceClient();
            products = product.GetAllProducts().ToList();
            dataGridViewProducts.DataSource = products;
            UpdateLables();


        }

        private void dataGridViewProducts_DoubleClick(object sender, EventArgs e)
        {
            ProductServiceClient product = new ProductServiceClient();
            Product productToChange = products[dataGridViewProducts.CurrentRow.Index];
            using(AddEdit edit = new AddEdit(productToChange, true))
            {
                
                edit.ShowDialog();
                    products[dataGridViewProducts.CurrentRow.Index] = edit.Product;
                    product.UpdateProduct(products[dataGridViewProducts.CurrentRow.Index]);
                    dataGridViewProducts.Refresh();
                UpdateLables();
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductServiceClient product = new ProductServiceClient();
            Product productToChange = new Product();
            using (AddEdit edit = new AddEdit(productToChange, false))
            {
                edit.ShowDialog();
                    product.AddProduct(edit.Product);
                    products = product.GetAllProducts().ToList();
                    dataGridViewProducts.DataSource = products;
                    dataGridViewProducts.Refresh();
                    UpdateLables();

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ProductServiceClient product = new ProductServiceClient();
            Product productToDelete = products[dataGridViewProducts.CurrentRow.Index];
            product.DeleteProduct(productToDelete);
            products = product.GetAllProducts().ToList();
            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.Refresh();
            UpdateLables();

        }

        private void UpdateLables()
        {
            labelProductID.Text = products[dataGridViewProducts.CurrentRow.Index].ProductID.ToString();
            labelProductName.Text = products[dataGridViewProducts.CurrentRow.Index].ProductName.ToString();

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLables();
        }
    }
}
