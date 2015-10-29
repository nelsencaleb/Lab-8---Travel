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
        public Form2Map()
        {
            InitializeComponent();
        }

        // Form2Map f2 = new Form2Map();
        Main f1 = new Main();

        // list of regions 
        List<string> RegionsPickedList = new List<string>();

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
            // for each check box checked add them in order 
            foreach (var cbRegion in this.Controls.OfType<CheckBox>())
            {
                if (cbRegion.Checked == true)
                {
                    RegionsPickedList.Add(cbRegion.Name.ToString());
                }
            }
                    
            if (RegionsPickedList.Count == 0)
                        {
                            MessageBox.Show("Please check a region to travel to ", " No Selection ");
                            groupBoxCheckBoxPlacesToVisit.BackColor = Color.Red;
                        }

                        else
                        {
                            //set the tagged information to be passed back to main. 
                            this.Tag = RegionsPickedList;

                            string items = "";
 
                            foreach (string place in RegionsPickedList)
                            {
                                items += place; 
                            }
	                        // maybe implement a dictionary with set values for each possible region location available

                            MessageBox.Show("List Of regions selected " + items);
                        }
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




