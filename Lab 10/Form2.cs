using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
   

    public partial class Form2Map : Form
    {

        public bool accept = false;
        public Form2Map()
        {
            InitializeComponent();
        }

        // Form2Map f2 = new Form2Map();
        Main f1 = new Main();

       
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            
            gobackToMain();

        }

        private void gobackToMain()
        {
            this.Hide();
            f1.Show();
            f1.Enabled = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (accept == false)
            {
                this.Tag = "You have chosen to pay with cash.";
                gobackToMain();
            }
            else if (accept == true)
            {
                this.Tag = "You have choosen to pay with a credit card.";
                gobackToMain();
            }

        }

        private void Form2Map_Load(object sender, EventArgs e)
        {

        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            txtCreditCard.ReadOnly = true;
            txtExpires.ReadOnly = true;
            accept = false;

        }

        private void rdoCredit_CheckedChanged(object sender, EventArgs e)
        {
            txtCreditCard.ReadOnly = false;
            txtExpires.ReadOnly = false;
            accept = true;
        }
                }
            }
      
//public enum regions 
//{ 0 = 0 ; // if it equals zero then no region selected throw an error message
//    1 = "West" 
//2 = "SouthWest" 
//3 = "Midwest" 
//4 = "SouthEast" 
//5 = "Northeast" 
//}




