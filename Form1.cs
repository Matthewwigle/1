using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC140_A02
{
   
    public partial class Form1 : Form
    {
        decimal decTax = 0;
        decimal decTotalWithTax = 0;
        decimal decTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblLatte_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalTax_Click(object sender, EventArgs e)
        {

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            decTotal = decTotal + 1.99m;
          
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

          }

     
    }
}
