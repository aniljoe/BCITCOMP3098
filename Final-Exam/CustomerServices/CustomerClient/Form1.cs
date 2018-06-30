using CustomerClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class CustomerClient : Form
    {
        public CustomerClient()
        {
            InitializeComponent();
        }

        private void CustomerClient_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
            
        }

        private async void GetAllCustomers()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:12576/api/Customer")) 
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        dataGridViewCustomers.DataSource = JsonConvert.DeserializeObject<Customer[]>(productJsonString).ToList();

                    }
                }
            }
        }

        private async void AddCustomer()
        {
            Customer cus = new Customer();
            cus.CustomerId = Convert.ToInt32(textBoxCustomerId.Text);
            cus.CustomerName = textBoxCustomerName.Text;
            cus.Address= textBoxAddress.Text;
            cus.Email = textBoxEmail.Text;
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(cus);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("http://localhost:12576/api/customer/insert", content);
            }
            GetAllCustomers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
    }
}
