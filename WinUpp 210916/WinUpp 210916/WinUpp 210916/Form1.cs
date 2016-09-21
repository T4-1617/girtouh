using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUpp_210916
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Collections.ArrayList Category;

            Category = new System.Collections.ArrayList();

            Categories f = new Categories();
            f.Categorytype = "Employee";
            Category.Add(f);

            Categories c = new Categories();
           c.Categorytype = "Customer";
            Category.Add(c);

            Categories d = new Categories();
           d.Categorytype = "Delivery";
            Category.Add(d);

             foreach (Categories item in Category)
            {
                Categorycombx.Items.Add(item);
            }
        }

        

        private void Categorycombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categorycombx.SelectedText = Text("Customer"))
            {

            }  
        }
    }
}
