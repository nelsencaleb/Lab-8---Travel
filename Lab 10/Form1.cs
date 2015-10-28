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

        //todo will need to tie in hardcoded data or enum for region weather information. 
       
        // public values ( might later be added to structure of class) 
 
       public DateTime dateout;
       public DateTime dateIn;


        //todo get form2 to display 
       private void btnMap_Click(object sender, EventArgs e)
       {

            Form2Map f2 = new Form2Map();
            f2.Enabled = true; 
           f2.Show();
           

           // show dialog box. 

           this.Hide(); 
          
       }

        //todo add code and design the dialog window. 
        // this window in particular is the map to have checkboxes to select a region. 
        //private void callPopUPWindow()
        //{
        //     throw new NotImplementedException();
        //}


        // closes the main window 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //todo when this button is clicked record the arrival and departure date for the trip 
        private void btnEnterDates_Click(object sender, EventArgs e)
        {
            // set these two days first then test them 
            DateTime dept  = dateTimePickerDeparture.Value;
            
            DateTime comeBack = dateTimePickerReturnDate.Value;

        if  (validateDateInput(dept, comeBack)  == true)
        {
            // call the methods to find the departure and return date 
            getSetPickedTripDates(dateTimePickerDeparture, dateTimePickerReturnDate);

           listBoxTripDatesOrData.Items.Add("Depature Date: " + dept.ToShortDateString() + "Return Date:" + comeBack.ToShortDateString());
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
                // set the current dateTime to most recent value 
                DateTime thisCurrentRunningSessionDateAndtime = DateTime.Now;


                if (deptartureDate >= thisCurrentRunningSessionDateAndtime)
                {
                    // then do this 
                    MessageBox.Show("Check your dates you cannot depart back in time", " Hey McFly!");

                    // throw the flag 
                    return false;
                }
                else if (returnDateTime.AddSeconds(10) <= deptartureDate)
                {
                    MessageBox.Show("You cannot return before you depart. \n How? \n how do you expect to accomplish this ?", "How?");
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
          dateTimePickerReturnDate.Value =  dateTimePickerReturnDate.Value.AddDays(1); 
        }


                
        }

    }

        
    
        