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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Reveals and Hides certain control elements
        {
            SignInButton.Visible = false;
            SourceCodeTB.Visible = false;
            label1.Visible = true;
            CityPB.Visible = true;

            ProfilePB.Visible = true;
            WelcomeBackLBL.Visible = true;
            PasswordTB.Visible = true;
            loginconfirmButton.Visible = true;

            string Fname = NameGenerator();

            WelcomeBackLBL.Text = Fname ;

        }

        public string NameGenerator()
        {
            Random rand = new Random();
            int x = rand.Next(5);
            string name = "";

            switch (x)
            {
                case 0:
                    name = "Stephanie";             
                    break;
                case 1:
                    name = "Joey";
                    break;
                case 2:
                    name = "Tammy";
                    break;
                case 3:
                    name = "Travis";
                    break;
                case 4:
                    name = "Samantha";
                    break;
                case 5:
                    name = "Bob";
                    break;
            }
            return name;
        }  // Generates a random name

        private void loginconfirmButton_Click(object sender, EventArgs e) // Launches Next Form
        {
            CustomerContextMenu cuss = new CustomerContextMenu();
            cuss.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SignInButton.BringToFront();
            SourceCodeTB.BringToFront();

        } // Rearranges control elements

                 
    }
        } 
    


