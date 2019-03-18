using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop_location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location, workshop;
            int fee, days, hotel;
            fee = 0;
            days = 0;
            hotel = 0;
            if ((locationBox2.SelectedIndex != -1) && (classBox1.SelectedIndex != -1));
            {
                workshop = classBox1.SelectedItem.ToString().Substring(0, 3);
                location = locationBox2.SelectedItem.ToString().Substring(0, 3);

                switch (workshop)
                {
                    case "Int": days = 5; fee = 1000; break; 
                    case "Gra": days = 7; fee = 800; break;
                    case "Soc": days = 3; fee = 1500; break;
                    case "Dat": days = 5; fee = 1300; break;
                    case "How": days = 1; fee = 500; break;
                }

                switch (location)
                {   case "Swe": hotel = 550; break;
                    case "Nor": hotel = 425; break;
                    case "Ice": hotel = 775; break;
                    case "Ire": hotel = 500; break;
                    case "Eng": hotel = 175; break;
                    case "Gre": hotel = 350; break;               
                }

                label3.Text = "Registration: $" + fee + "\n" +
                              "Hotel: $" + hotel + " x " +  days  + " days = $ " +  hotel  *  days + "\n" +
                              "Total Cost: $" + (fee + hotel * days);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
