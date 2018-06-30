using CustomerFormsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFormsClient
{
    
    public partial class AddForm : Form
    {
        MainForm obj = (MainForm)Application.OpenForms["MainForm"];
        public AddForm()
        {
            InitializeComponent();
           
        }

        private void buttonDeleteConfirm_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Customer a = new Customer();

            a.CustomerId = Convert.ToInt32(textBoxCustomerId.Text);
            a.CustomerName = textBoxCustomerName.Text;
            a.Address = textBoxAddress.Text;
            a.Email = textBoxEmail.Text;

            client.InsertCustomer(a);
            obj.loaddata();
     


            this.Close();
        }
    }
}
