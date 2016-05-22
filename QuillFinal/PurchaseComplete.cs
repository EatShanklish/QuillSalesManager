using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuillFinal
{
    public partial class PurchaseComplete : Form
    {
        public PurchaseComplete(double total, string bName, string address)
        {
            InitializeComponent();

            totallabel.Text = "$" + total.ToString();
            BusNameLbl.Text = bName;
            AddressLbl.Text = address;
            label4.Text = "$"+(total * 0.28).ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelWrite sheet = new ExcelWrite(totallabel.Text, BusNameLbl.Text, AddressLbl.Text);
            
        }       
    }
}
