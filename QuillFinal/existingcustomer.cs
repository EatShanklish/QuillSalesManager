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
    public partial class existingcustomer : Form
    {
        public string pName;
        public string pAddress;

        // Initializes component and sets values of text labels
        public existingcustomer(string dName, string dAddress)
        {
            InitializeComponent();

            bnamelbl.Text = dName;
            addresslbl.Text = dAddress;
            accnumlbl.Text = "Account Number: 32321";
        }                       

        //Initiates an item and changes appropriate text
        private void Search_Click(object sender, EventArgs e)
        {
            ItemNameLbl.Visible = true;
            itemPB.Visible = true;
            AddItemButton.Visible = true;

            int x = int.Parse(itemnumberTB.Text);

            string itemname = ItemGenerator(x);

            ItemNameLbl.Text = itemname;
        }

        //Generates random item
        public string ItemGenerator(int x)
        {
            string itemname="";
           

            if (x > 1000 && x <= 2000)
            {
                itemname = "Nadler office Chair";
                itemPB.Image = Image.FromFile("chair.jpg");               
            }

            else if (x >= 2000 && x <= 3000)
            {
                itemname = "HP OfficeJet";
                itemPB.Image = Image.FromFile("printer.jpg");
            }

            else if (x >= 3000 && x <= 4000)
            {
                itemname = "Samsung LED Monitor";
                itemPB.Image = Image.FromFile("monitor.jpg");
            }
           
            else if (x >= 4000 && x <= 5000)
            {
                itemname = "Crosscut Shredder";
                itemPB.Image = Image.FromFile("shredder.jpg");
            }

            else if (x >= 5000 && x <= 6000)
            {
                itemname = "Logitech M30 Wireless Mouse";
                itemPB.Image = Image.FromFile("mouse.jpg");
            }

            else if (x >= 6000 && x <= 7000)
            {
                itemname = "HP Slim Desktop PC";
                itemPB.Image = Image.FromFile("desktop.jpg");
            }

            return itemname;

        }

        //Adds selected item to the customer purchase list
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(itemnumberTB.Text);

            string itemname = ItemGenerator(x);

            ListboxItems.Items.Add(itemname);

            Random rand = new Random();
            int y = rand.Next(100,400);
            PriceListBox.Items.Add(y.ToString());
        }
       
        // Add total value of items and calculcates total
        private void button1_Click(object sender, EventArgs e)
        {          
            int total = 0;

            for (int i =0; i < PriceListBox.Items.Count; i++)
            {                
                total += Convert.ToInt32(PriceListBox.Items[i].Text);               
            }

            label5.Text = Convert.ToString(total);

            Random rand = new Random();
            string x = rand.Next(20).ToString();
            label8.Text = x + "%";

            double taxtotal = (total * 0.06);
            label6.Text = taxtotal.ToString();

            label7.Text = (total - (total * 0.06)).ToString();
        }

        // Loads "Recipt" and passes parameters to next form.
        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseComplete purcom = new PurchaseComplete(double.Parse(label7.Text), bnamelbl.Text, addresslbl.Text);
            purcom.Show();
        }
    }
    }

