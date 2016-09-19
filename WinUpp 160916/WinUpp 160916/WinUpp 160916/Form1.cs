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
        System.Collections.ArrayList CustomersAndCars;
        System.Collections.ArrayList Cars;
        int CarinList = new int();


        public Form1()
        {
            InitializeComponent();

            //Adding Cars arraylist
            Cars = new System.Collections.ArrayList();
            CustomersAndCars = new System.Collections.ArrayList();


            Car c = new Car();
            c.CarMaker = "Volvo";
            c.CarModel = "V70";
            c.CarColour = "Black";
            c.CarNumber = "001";
            c.booked = false;
            Cars.Add(c);

            Car f = new Car();
            f.CarMaker = "BMW";
            f.CarModel = "K";
            f.CarColour = "Green";
            f.CarNumber = "002";
            f.booked = false;
            Cars.Add(f);

            Car d = new Car();
            d.CarMaker = "Suzuki";
            d.CarModel = "MVP";
            d.CarColour = "Red";
            d.CarNumber = "003";
            d.booked = false;
            Cars.Add(d);


            //Setting start screen to neutral
            Availablecarpnl.Visible = false;
            Responselbl.Text = string.Empty;
            Responselbl2.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;
            ConfirmBookpnl.Visible = false;


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
            UppdateReturnlist();

        }

        //Confirmed booking button
        private void Bookbtn_Click(object sender, EventArgs e)
        {

            ConfirmBookpnl.Visible = true;

        }

        private void ConfirmBookbtn_Click(object sender, EventArgs e)
        {
            //Adding safe to booking
            if (Avaiblecarlst.SelectedIndex > -1)
            {

                Customer h = new Customer();
                h.Firstname = FirstNametxt.Text;
                h.Lastname = LastNametxt.Text;
                CustomersAndCars.Add(h);


                Responselbl2.Text = "Car booked.";
                Responselbl.Text = "Thank you for your booking!";
                //Setting car status to Booked
                Car x = (Car)Avaiblecarlst.SelectedItem;
                x.hiredBy = h;
                x.booked = true;


            }
            else
            {

                Responselbl2.Text = "No car selected.";
                Responselbl.Text = "Please select a car to book.";

            }
            ConfirmBookpnl.Visible = false;
            Updatecarlist();


        }

        //Confirming add car button
        private void Confirmaddcarbtn_Click(object sender, EventArgs e)
        {
            Responselbl.Text = "Car added!";
            //Adding car 
            Car b = new Car();
            b.CarMaker = CarMakertxt.Text;
            b.CarModel = CarModeltxt.Text;
            b.CarColour = CarColourtxt.Text;
            b.CarNumber = CarNumbertxt.Text;
            Cars.Add(b);

            //Clearing text boxes for next use
            CarMakertxt.Text = string.Empty;
            CarModeltxt.Text = string.Empty;
            CarColourtxt.Text = string.Empty;
            CarNumbertxt.Text = string.Empty;

            Updatecarlist();


        }

        //Show car info when pressed

        private void Infobtn_Click(object sender, EventArgs e)
        {
            if (Avaiblecarlst.SelectedIndex > -1)
            {
                Car car = (Car)Carreturnlst.SelectedItem;
                MessageBox.Show(string.Format("{0} Booked by {1}", car, car.hiredBy));
            }
            else
            {

                Responselbl2.Text = "No car selected.";
                Responselbl.Text = "Please select a car to view.";

            }
        }

        //Confirming return car button
        private void Returnconfirmbtn_Click(object sender, EventArgs e)
        {
            if (Carreturnlst.SelectedIndex > -1)
            {
                Responselbl2.Text = "Car returned.";
                Responselbl.Text = "Thank you for your buisness!";
                //Setting car status to Avaible
                Car c = (Car)Carreturnlst.SelectedItem;
                c.hiredBy = null;
                c.booked = false;
            }
            else
            {

                Responselbl2.Text = "No car selected.";
                Responselbl.Text = "Please select a car to return.";

            }
            UppdateReturnlist();
            Updatecarlist();
        }

        //Function to update the list of available cars
        public void Updatecarlist()
        {
            //Remove all objects in list
            Avaiblecarlst.Items.Clear();
            foreach (Car x in Cars)
            {
                //Re-adding correct objects
                if (x.booked == false)
                {
                    Avaiblecarlst.Items.Add(x);
                }

            }
            CarinList = Avaiblecarlst.Items.Count;

            CarAvaiblelbl.Text = string.Format("We have {0} cars available.", CarinList);
        }

        //Function to update the booked list
        public void UppdateReturnlist()
        {
            //Remove all objects in list
            Carreturnlst.Items.Clear();

            foreach (Car x in Cars)
            {
                //Re-adding correct objects
                if (x.booked == true)
                    Carreturnlst.Items.Add(x);
            }

        }
        //Cancel button
        private void Cancelbtn2_Click(object sender, EventArgs e)
        {
            Availablecarpnl.Visible = true;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;
            ConfirmBookpnl.Visible = false;

        }

        //Cancel button
        private void Canceladdbtn_Click(object sender, EventArgs e)
        {
            Availablecarpnl.Visible = true;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;
            ConfirmBookpnl.Visible = false;

        }

        //Cancel button
        private void Cancelbtn3_Click(object sender, EventArgs e)
        {
            Availablecarpnl.Visible = true;
            Responselbl2.Text = string.Empty;
            Responselbl.Text = string.Empty;
            Addcarpnl.Visible = false;
            Returncarpnl.Visible = false;
            ConfirmBookpnl.Visible = false;
            FirstNametxt.Text = string.Empty;
            LastNametxt.Text = string.Empty;

        }


    }
}
