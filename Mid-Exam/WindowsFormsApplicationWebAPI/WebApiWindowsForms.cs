using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationWebAPI
{
    public partial class WebApiWindowsForms : Form
    {
        public WebApiWindowsForms()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private async void GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:52862/api/products"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        dataGridView1.DataSource = JsonConvert.DeserializeObject<Product[]>(productJsonString).ToList();

                    }
                }
            }
        }


       


        private void WebApiWindowsForms_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private async void AddProduct()
        {
            Product p = new Product();
            p.ProductName = textBoxProductName.Text;
            p.QuantityPerUnit = textBoxQuantityPerUnit.Text;
            p.UnitPrice = decimal.Parse(textBoxUnitPrice.Text);
            p.Discontinued = checkBoxDiscontinue.Checked;
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(p);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("http://localhost:52862/api/products/add", content);
            }
            GetAllProducts();
        }
    }
}
