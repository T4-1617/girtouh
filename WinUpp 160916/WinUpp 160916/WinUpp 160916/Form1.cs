﻿using System;
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
        System.Collections.ArrayList Cars;
        int CarinList = new int();


        public Form1()
        {
            InitializeComponent();

            //Adding Cars arraylist
            Cars = new System.Collections.ArrayList();

            Car c = new Car();
            c.CarMaker = "Volvo";
            c.CarModel = "V70";
            c.CarColour = "Black";
            c.CarNumber = "001";
            Cars.Add(c);

            Car f = new Car();
            f.CarMaker = "BMW";
            f.CarModel = "K";
            f.CarColour = "Green";
            f.CarNumber = "002";
            Cars.Add(f);

            Car d = new Car();
            d.CarMaker = "Suzuki";
            d.CarModel = "1222994a0087efd";
            d.CarColour = "Red";
            d.CarNumber = "003";
            Cars.Add(d);


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

            Updatecarlist();

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
            //Adding car 
            Car d = new Car();
            d.CarMaker = "Suzuki";
            d.CarModel = "1222994a0087efd";
            d.CarColour = "Red";
            d.CarNumber = "003";
            Cars.Add(d);


        }

        //Confirming return car
        private void Returnconfirmbtn_Click(object sender, EventArgs e)
        {
            Responselbl2.Text = "Car returned.";
            Responselbl.Text = "Thank you for your buisness!";
        }

        //Function to update the list of available cars (Under coding)
        public void Updatecarlist()
        {
            Avaiblecarlst.Items.Clear();
            foreach (Car item in Cars)
            {
                Avaiblecarlst.Items.Add(item.CarNameAndNumber());
            }
            CarinList = Avaiblecarlst.Items.Count;

            CarAvaiblelbl.Text=string.Format("We have {0} cars available.", CarinList);


        }
    }
}
