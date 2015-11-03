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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /* THIS PROGRAM WILL AID IN PLANNING YOU TRAVEL 
         
         * * IT CAN SUGGEST WEATHER 
         *      SUGGEST LIST OF ITEMS TO BRING
         *      EMERGENCY ROAD SIDE ASSITANCE NUMBER 
         *  //RADAR GIF -- EXTRA FEATURE 
         *  
         * // MAP -- ALREADY DONE 
         * 
         * // HOTEL -- DRAWN FROM LIST BY REGION. 
         * 
         * // GAS CALCULATOR 
         * 
         * // MILEAGE LOG 
         /*
         * /
        */

        
       
        // public values ( might later be added to structure of class) 
 
       public DateTime dateout;
       public DateTime dateIn;


        
       private void btnMap_Click(object sender, EventArgs e)
       {

           Form2Map f2 = new Form2Map();
           f2.Enabled = true; 
           f2.Show();
           

           // show dialog box. 

           this.Hide(); 
          
       }

        // closes the main window 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //todo when this button is clicked record the arrival and departure date for the trip 
        private void btnEnterDates_Click(object sender, EventArgs e)
        {
            // set these two days first then test them 
          

            MessageBox.Show(dateTimePickerDeparture.Value + "\n" + dateTimePickerReturnDate.Value);

        if  (validateDateInput(dateTimePickerDeparture.Value, dateTimePickerReturnDate.Value))
        {
            // call the methods to find the departure and return date 
            getSetPickedTripDates(dateTimePickerDeparture, dateTimePickerReturnDate);

            listBoxTripDatesOrData.Items.Add("Depature Date: " + dateTimePickerDeparture.Value + "Return Date:" + dateTimePickerReturnDate.Value);
            // pass down dept and comeback so that to a single method to determine both. 

           progressBar1.Value = (10); 
        }
        }


        // first write a method to validate data input based off of current date 

        // this method requires the data to be set already when passed in. 
        public bool validateDateInput(DateTime deptartureDate, DateTime returnDateTime)
        {
            try
            {
          


                if (deptartureDate.CompareTo(DateTime.Now.AddDays(-1)) == -1)
                {
                    // then do this 
                    MessageBox.Show("Check your dates you cannot depart back in time", " Hey McFly!");

                    // throw the flag 
                    return false;
                }
                else if (returnDateTime.CompareTo(deptartureDate) == -1)
                {
                    MessageBox.Show("You cannot return before you depart. \n" + deptartureDate + " after " + returnDateTime, "How?");
                    // throw the flag 
                    return false;
                }
                return true;
            }
            // catch any crazy errors. 
            catch (Exception ex)
            {
                MessageBox.Show("Something went terribly wrong here while trying to retrieve the current date and time." + ex.Message + "Strack Trace:" + ex.StackTrace, "Uh, Oh");
            }

            // return true on all paths and hope of the best ! 
            return true; 

        }

        // next write the method to set date and time
        public void getSetPickedTripDates(DateTimePicker go, DateTimePicker comeback)
        {
            //verbose
             dateout =  Convert.ToDateTime(go.Value);
             dateIn = Convert.ToDateTime(comeback.Value);
        }

        private void Main_Load(object sender, EventArgs e)
        {
           //todo figure out why this isn't working 
            dateTimePickerReturnDate.Value = DateTime.Now.AddDays(1);
        }


        // when this button is clicked bring up a seperate form for the gas calculator 
        private void buttonGasCalc_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        //Do i need to create a tag to recieve Form 2 state selection? 
        
        
        //todo write a random weather picker.

        //todo hardcode data for weather and weather icons. Get weather icons. 

        }

    }

        
    
        