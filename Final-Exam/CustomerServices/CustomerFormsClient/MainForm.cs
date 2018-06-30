using CustomerFormsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using CustomerQuartzScheduler;

namespace CustomerFormsClient
{
    public partial class MainForm : Form
    {
        private LoggingJob job;

        public MainForm()
        {
            InitializeComponent();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
           
            var customers = client.GetCustomers();
            var customersList = customers.ToList();
            dataGridClient.DataSource = customers;
            textBoxCustomerId.ReadOnly = true;

            if (customersList.Count != 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridClient.Rows[0];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxAddress.Text = row.Cells[0].Value.ToString();
                textBoxCustomerId.Text = row.Cells[1].Value.ToString();
                textBoxCustomerName.Text = row.Cells[2].Value.ToString();
                textBoxEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            dataGridClient.DataSource = client.GetCustomers();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {

           var addForm = new AddForm();
           addForm.Show();

        }

        public void loaddata()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            dataGridClient.DataSource = client.GetCustomers();
        }


        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.DeleteCustomer(Convert.ToInt32(textBoxCustomerId.Text));
            MessageBox.Show("Customer Deleted Sucessfully");
            dataGridClient.DataSource = client.GetCustomers();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Customer a = new Customer();

            a.CustomerId = Convert.ToInt32(textBoxCustomerId.Text);
            a.CustomerName = textBoxCustomerName.Text;
            a.Address = textBoxAddress.Text;
            a.Email = textBoxEmail.Text;

            client.UpdateCustomer(a);
            dataGridClient.DataSource = client.GetCustomers();

        }

        private void dataGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridClient.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxAddress.Text = row.Cells[0].Value.ToString();
                textBoxCustomerId.Text = row.Cells[1].Value.ToString();
                textBoxCustomerName.Text = row.Cells[2].Value.ToString();
                textBoxEmail.Text = row.Cells[3].Value.ToString();
              
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            job = new LoggingJob();
            job.Execute(5);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (job != null)
            {
                job.Destroy();
            }
        }
    }
}
