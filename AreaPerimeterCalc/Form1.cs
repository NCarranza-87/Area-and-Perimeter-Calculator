using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimeterCalc
{
    public partial class Form1 : Form
    {

        /******************************************
         * This program will have a user to enter 
         * a value for length and width. With the
         * length and width entered from the user;
         * the program will calculate the area 
         * and perimeter.
         *****************************************/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /******************************************
             * When the program loads, upon start up
             * the txtArea and txtPerimeter will not
             * allow a user to enter input. It will
             * only display the values calculated from
             * txtLength and txtWidth
             ******************************************/

            //  txtArea and txtPerimeter will
            //  invoke method ReadOnly
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /***********************************
             * The Calculate button will get
             * the input from the txtLength
             * txtWidth and display the results
             * in the txtArea and txt Perimeter
             ***********************************/

            // get the length from user length 
            // variable will be named lengthVal
            decimal lengthVal = Convert.ToDecimal(txtLength.Text);

            
            if (lengthVal < 0)
            {                   // validate for negative input
                MessageBox.Show("please enter a positive number!");
                return;
            }

            // get the width from user width
            // variable will be name widthVal
            decimal widthVal = Convert.ToDecimal(txtWidth.Text);

            
            if(widthVal < 0)
            {                   // validate for negative input
                MessageBox.Show("please enter a positive number!");
                return;
            }

            //calculate lengthVal and widthVal to get the area
            //and set as a result variable AreaResult
            double AreaResult = Convert.ToDouble(widthVal * lengthVal);

            //calculate lengthVal and widthVal to get the area
            //and set as a result variable PerimeterResult
            double PerimeterResult = Convert.ToDouble((2 * lengthVal) + (2 * widthVal));

            //display the AreaResult
            //formatted to 2 decimal places
            txtArea.Text = AreaResult.ToString("f2");

            //display the PerimeterResult
            //formateed to 2 decimal places
            txtPerimeter.Text = PerimeterResult.ToString("f2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            /*
             * when clicked the Reset button will
             * remove all values from txtLength,
             * txtWidth, txtPerimeter and txtArea;
             * then begin with the input cursor
             * set back to txtLength for input
             */

            //all textboxes are cleared
            txtLength.Text = "";
            txtWidth.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            //txtLength invokes
            //Focus method to reenter
            //input from user
            txtLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*********************************
             * When Exit button is click
             * the user is done with entering
             * length and width input
             *********************************/

            // end program and close form
            this.Close();
        }
    }
}
