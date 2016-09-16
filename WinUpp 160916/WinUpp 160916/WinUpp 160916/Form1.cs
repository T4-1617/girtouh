using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUpp_160916
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            //Setting start screen to neutral
            Availablecarpnl.Visible = false;
            Responselbl.Text = string.Empty;
            Responselbl2.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;

        }

        //Opens Show panel
        private void Showcarbtn_Click(object sender, EventArgs e)
        {
            Availablecarpnl.Visible = true;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;


        }

        //Opens Add panel
        private void Addcarbtn_Click(object sender, EventArgs e)
        {
            Addcarpnl.Visible = true;
            Availablecarpnl.Visible = false;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Returncarpnl.Visible = false;

        }

        //Opens Return panel
        private void Returncarbtn_Click(object sender, EventArgs e)
        {
            Returncarpnl.Visible = true;
            Availablecarpnl.Visible = false;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Addcarpnl.Visible = false;

        }

        //Confirmed booking
        private void Bookbtn_Click(object sender, EventArgs e)
        {
            Responselbl2.Text = "Car booked.";
            Responselbl.Text = "Thank you for your booking!";

        }

        //Confirming add car
        private void Confirmaddcarbtn_Click(object sender, EventArgs e)
        {
            Responselbl.Text = "Car added!";

        }

        //Confirming return car
        private void Returnconfirmbtn_Click(object sender, EventArgs e)
        {
            Responselbl2.Text = "Car returned.";
            Responselbl.Text = "Thank you for your buisness!";
        }
    }
}
