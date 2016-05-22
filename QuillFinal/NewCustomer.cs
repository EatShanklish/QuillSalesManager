using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuillFinal
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        // sets values and passes them to "existing customer" form
        private void button1_Click(object sender, EventArgs e)
        {
            string _Bname = cNameTB.Text;
            string _Baddress = addressTB.Text;

            BusinessInformation new_client = new BusinessInformation(_Bname, _Baddress);

            existingcustomer new_customer = new existingcustomer(_Bname, _Baddress);
            new_customer.Show();
        }
    }
}
