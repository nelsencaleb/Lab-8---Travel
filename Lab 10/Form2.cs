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
        // http://www.dotnetperls.com/tag
        class ListTag
        {
            public string _a;
            public string _b;
            public string _c;
            public string _d;
            public string _e;
            public ListTag(string a = "", string b = "", string c = "", string d = "", string e = "")
            {
                this._a = a;
                this._b = b;
                this._c = c;
                this._d = d;
                this._e = e;

            }
            public override string ToString()
            {
                return string.Format("Tag a={0}, b={1}, c={2}, d={3}, e={4}", this._a, this._b, this._c, this._d, this._e);
            }
        }
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
            string aa = "";
            string bb = "";
            string cc = "";
            string dd = "";
            string ee = "";

            if (NorthEast.Checked)
            {
                aa = NorthEast.Name;
            }
            if (MidWest.Checked)
            {
                bb = MidWest.Name;
            }
            if (West.Checked)
            {
                cc = West.Name;
            }
            if (SouthEast.Checked)
            {
                dd = SouthEast.Name;
            }
            if (SouthWest.Checked)
            {
                ee = SouthWest.Name;
            }
            this.Tag = new ListTag(aa, bb, cc, dd, ee);
            gobackToMain();

        }

        private void Form2Map_Load(object sender, EventArgs e)
        {

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




