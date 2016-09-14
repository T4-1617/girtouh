using System;
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
        int CarsInList;

        public Form1()
        {
            //Avaible cars
            InitializeComponent();

            CarsInList = Carlist.Items.Count;
            InfoField.Visible = false;
            EditField.Visible = false;

            Cars c1 = new Cars() { CarName = "New car" };
            Carlist.Items.Add(c1);
            Carlist.DisplayMember = "CarName";


         /*   while(CarsInList<5)
            {
                Carlist.Items.Add(c1);
            }*/
        }


        private void Carlist_SelectedIndexChanged(object sender, EventArgs e)
        {


            InfoField.Visible = true;


        }

        //Edit button functions
        private void EditBtn_Click(object sender, EventArgs e)
        {
            InfoField.Visible = false;
            EditField.Visible = true;
        }

        //Cancle button functions
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            EditField.Visible = false;
            InfoField.Visible = true;
        }

        //Save button functions
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //Adding car to system when saved
            Cars AddingCars = new Cars();
            AddingCars.CarName = Typetxt.Text;
            AddingCars.CarColour = Colourtxt.Text;
            AddingCars.CarNumber = Regtxt.Text;
            CarStats.Add(AddingCars);

            Carnamelbl.Text = Typetxt.Text;

            EditField.Visible = false;
            InfoField.Visible = true;





        }
    }
}
