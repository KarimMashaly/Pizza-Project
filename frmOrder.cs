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
    public partial class frmOrder : Form
    {
        int TotalPrice;
        string SelectedSize;
        string SelectedToppings = "";
        string SelectedCrust;
        string SelectedWhereToEat;
        public frmOrder()
        {
            InitializeComponent();
            TotalPrice = 0;
           
        }

        int GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToInt32(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToInt32(rbMedium.Tag);
            else if (rbLarge.Checked)
                return Convert.ToInt32(rbLarge.Tag);
            else
                return 0;
        }

        int CalculateToppingsPrice()
        {
            int price = 0;

            if (cbExtraCheese.Checked)
                price += Convert.ToInt32(cbExtraCheese.Tag);
            if (cbMushrooms.Checked)
                price += Convert.ToInt32(cbMushrooms.Tag);
            if (cbTomatoes.Checked)
                price += Convert.ToInt32(cbTomatoes.Tag);
            if (cbOnions.Checked)
                price += Convert.ToInt32(cbOnions.Tag);
            if (cbOlives.Checked)
                price += Convert.ToInt32(cbOlives.Tag);
            if (cbGreenPapers.Checked)
                price += Convert.ToInt32(cbGreenPapers.Tag);


            return price;
        }

        int GetSelectedCrust()
        {
            if(rbThick.Checked)
                return Convert.ToInt32(rbThick.Tag);    
            else if (rbThin.Checked)
                return Convert.ToInt32(rbThin.Tag);
            else return 0;
        }

        int GetSelectedWhereToEat()
        {
            if(rbEatIn.Checked)
                return Convert.ToInt32(rbEatIn.Tag);   
            else if (rbTakeOut.Checked)
                return Convert.ToInt32( rbTakeOut.Tag);
            else return 0; 
        }
       void UpdatePrice()
        {
            TotalPrice = CalculateToppingsPrice() + GetSelectedCrust() + GetSelectedWhereToEat() + GetSelectedSizePrice();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedSize = "Small";
            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedSize = "Medium";

            LbMoney.Text = TotalPrice.ToString();
        }
        
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedSize = "Large";

            LbMoney.Text = TotalPrice.ToString();
        }

        string GetSelectedToppings()
        {
            string Toppings = "";

            if(cbExtraCheese.Checked)   
                Toppings += "Extra Cheese, ";

            if (cbMushrooms.Checked)
                Toppings += "Mushrooms, ";

            if (cbTomatoes.Checked)
                Toppings += "Tomatoes, ";

            if (cbOnions.Checked)
                Toppings += "Onions, ";

            if (cbOlives.Checked)
                Toppings += "Olives, ";

            if (cbGreenPapers.Checked)
                Toppings += "Green Papers, ";

            if (Toppings == "")
                Toppings = "No Toppings  ";

            return Toppings;    
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedCrust = "Thin";

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedCrust = "Thick";

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedWhereToEat = "Eat In";

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            SelectedWhereToEat = "Take Out";


            LbMoney.Text = TotalPrice.ToString();
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;

            cbExtraCheese.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbOnions.Checked = false;
            cbOlives.Checked = false;
            cbOlives.Checked = false;

            rbThick.Checked = false;
            rbThin.Checked = false;

            rbEatIn.Checked = false;    
            rbTakeOut.Checked = false;

            TotalPrice = 0;
            LbMoney.Text = TotalPrice.ToString();
        }

        private void btOrderNow_Click(object sender, EventArgs e)
        {
            SelectedToppings = GetSelectedToppings();
            SelectedToppings = SelectedToppings.Substring(0, SelectedToppings.Length - 2).Trim();

            frmOrderSummary frm = new frmOrderSummary(SelectedSize, SelectedToppings, SelectedCrust,
                SelectedWhereToEat, TotalPrice);
            frm.ShowDialog();

        }
    }
}
