using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flytta_knapp
{
    public partial class Form1 : Form
    {
        int X, Y;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlytta_Click(object sender, EventArgs e)
        {

            X= Convert.ToInt16(tbxX.Text);
            Y = Convert.ToInt16(tbxY.Text);

            Point nyPosition = new Point(X, Y);

            
            btnFlytta.Location = nyPosition;
        }
    }
}
