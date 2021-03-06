﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUpp140916
{
    public partial class Form1 : Form
    {
        //Saving cars
        List<Cars> CarStats = new List<Cars>();

        public Form1()
        {
            //Avaible cars
            InitializeComponent();

            //Setting start screen to neutral
            InfoField.Visible = false;
            EditField.Visible = false;
            Colourlbl.Visible = false;
            Reglbl.Visible = false;


        }

        //Button click adds a car
        private void Addbtn_Click(object sender, EventArgs e)
        {

            Cars c1 = new Cars() { CarName = "New car" };
            CarStats.Add(c1);
            Carlist.Items.Add(c1.CarName);

        }

        //Pressing car opens specified detail field.
        private void Carlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Showing Detail field/InfoField
            InfoField.Visible = true;
            Carnamelbl.Text = CarStats[Carlist.SelectedIndex].CarName;
            Colourlbl.Text = CarStats[Carlist.SelectedIndex].CarColour;
            Reglbl.Text = CarStats[Carlist.SelectedIndex].CarNumber;


        }

        //Edit button functions
        private void EditBtn_Click(object sender, EventArgs e)
        {
            //Showing edit field, hiding detail field
            InfoField.Visible = false;
            EditField.Visible = true;
        }

        //Cancle button functions
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            //Reverses Edit button
            EditField.Visible = false;
            InfoField.Visible = true;
        }

        //Save button functions
        private void Savebtn_Click(object sender, EventArgs e)
        {

            Cars AddingCars = new Cars();
            //Removing currently selected car
            CarStats.Remove(CarStats[Carlist.SelectedIndex]);

            //Adding new/changedcar to system when saved
            AddingCars.CarName = Typetxt.Text;
            AddingCars.CarColour = Colourtxt.Text;
            AddingCars.CarNumber = Regtxt.Text;
            CarStats.Add(AddingCars);
            //Adding information to detail field/InfoField
            Carnamelbl.Text = Typetxt.Text;
            Colourlbl.Text = Colourtxt.Text;
            Reglbl.Text = Regtxt.Text;
            Colourlbl.Visible = true;
            Reglbl.Visible = true;

            //Exits edit screen
            EditField.Visible = false;
            InfoField.Visible = true;
            //Clearing carlist from old files
            Carlist.Items.Clear();
            Colourtxt.Text = string.Empty;
            Typetxt.Text = string.Empty;
            Regtxt.Text = string.Empty;

            //Adding new cars into the list
            foreach (Cars item in CarStats)
            {
                Carlist.Items.Add(item.Bilnamn());
            }

        }

        //Added delete button to remove cars
        private void Deletebtn_Click(object sender, EventArgs e)
        {

            //If the list is empty
            if (Carlist.Items.Count == 0 || Carlist.Items.Count ==-1)
            {
                MessageBox.Show("No cars to remove");
            }

            //If no car is selected
            if (Carlist.Items.Count>0 && Carlist.SelectedItem ==null)
            {
                MessageBox.Show("Please select a car");

                Carlist.Items.Clear();
                foreach (Cars item in CarStats)
                {
                    Carlist.Items.Add(item.Bilnamn());
                }

            }

            //If a car is selected
            else
            {
                Carlist.Items.Clear();
                CarStats.Remove(CarStats[Carlist.SelectedIndex]);
                foreach (Cars item in CarStats)
                {
                    Carlist.Items.Add(item.Bilnamn());
                }

            }

        }


    }
}
