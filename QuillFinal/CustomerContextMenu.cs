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
    public partial class CustomerContextMenu : Form
    {
              
        public CustomerContextMenu()
        {
            InitializeComponent();
        }

        private void ConfirmAccountButton_Click(object sender, EventArgs e)
        {
            string g = BussinessName();
                    
            existingcustomer exists = new existingcustomer(g, "8437 Orchard Lane");
            exists.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            NewCustomer newcustomer = new NewCustomer();
            newcustomer.Show();
        }

        //Generates random business name
        public static string BussinessName()
        {
            Random rand = new Random();
            int x = rand.Next(5);
            string busname = "";


            switch (x)
            {
                case 0:
                    busname = "Jay's Food Shoppe";
                    break;

                case 1:
                    busname = "Motel 6";
                    break;

                case 2:
                    busname = "Falcon Inn";
                    break;

                case 3:
                    busname = "Hyde Family Dental";
                    break;

                case 4:
                    busname = "ETech Solutions";
                    break;

                case 5:
                    busname = "Advanced Eye Solutions";
                    break;
            }

            return busname;

        }
    }
}
  



 

