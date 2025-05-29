using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary(string SelectedSize, string SelectedToppings, string SelectedCrust,
            string SelectedWhereToEat, int TotalPrice)
        {
            InitializeComponent();

            LbSize.Text += SelectedSize;
            LbToppings.Text += SelectedToppings;    
            LbCrust.Text += SelectedCrust;  
            LbWhereToEat.Text += SelectedWhereToEat;
            LbTotalPrice.Text += TotalPrice; 
        }

        
    }
}
