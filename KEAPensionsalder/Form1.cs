using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAPensionsalder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        int age, result, pension = 68;
        string name, msg;
        

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try // Error text if wrong input - i.e. digits#
            {
                age = Convert.ToInt32(textBoxAge.Text); // Converts input in textbox to number
                name = textBoxName.Text;
                
            }
            catch
            {
                labelAgeError.Text = "Only use numbers."; // error
            }
            result = pension - age;


            // Composite formatting:
            //string msg = string.Format("Hi {0}! You've got {1} years until you can go on pension.",name, age);

            // String interpolation:
            string msg = string.Format($"Hi {name}! You've got {result} years until you can go on pension.");

            textBoxResult.Text = msg;

        }
    }
}
