using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calAnswer(); //calculate results
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        /*the populate function sets text boxes to default setting 0.  
         * Could have used txtLength.Clear() instead*/
        private void populate()
        {
            txtLength.Text = "0"; 
            txtWidth.Text = "0";
            txtHeight.Text = "0";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtVolume.Text = "";

            txtLength.Focus();
        }
        /* calAnswer is the function that processes input.   
         * This function is where I would do data validation and exception handling
         */
        private void calAnswer()
        {
            decimal length = Convert.ToDecimal(txtLength.Text); //change Length to decimal
            decimal width = Convert.ToDecimal(txtWidth.Text);   //change width to decimal
            decimal height = Convert.ToDecimal(txtHeight.Text);   //change depth to decimal

            decimal area = length * width;                      //calculate area
            decimal perimeter = 2 * (length + width);           //calculate perimeter
            
                        
            if (height !=0){                                     //check if a value for depth has been entered (ie, object is 3d)
                decimal volume = area * height;                  //calculate volume
                txtVolume.Text = Convert.ToString(volume);      //display volume

                perimeter = (4 * length) + (4 * width) + (4 * height); //calculate perimeter of 3d object
                area = 2 * ((length * width) + (length * height) + (width * height));// calculate area of 3d object
            }
            txtArea.Text = Convert.ToString(area);              //display area
            txtPerimeter.Text = Convert.ToString(perimeter);    //display perimeter
            btnAC.Focus();

        }
        private void btnExit_Click(object sender, EventArgs e)  //Exit program (also works using ESC)
        {
            this.Close();
        }
        private void btnAC_Click(object sender, EventArgs e)    //AC=All Clear.  Clears all fields for next set of values
        {
            populate();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
