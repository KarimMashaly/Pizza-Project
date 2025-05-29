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
        public frmOrder()
        {
            InitializeComponent();
            TotalPrice = 0;
           
        }

        enum enSizePrice
        {
            eSmall = 50,
            eMedium = 85,
            eLarge = 130
        }

        enum enToppingsPrice
        {
            eExtraCheese = 10,
            eMushrooms = 5,
            eTomatoes = 5,
            eOnions = 7,
            eOlives = 15,
            eGreenPapers = 10
        }

        enum enCrustPrice
        {
            eThin = 20,
            eThick = 40
        }

        enum enWhereToEatPrice
        {
            eEatIn = 15,
            eTakeOut = 0
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                TotalPrice += (int)enSizePrice.eSmall;
            }
            else if (!rbSmall.Checked)
            {
                TotalPrice -= (int)enSizePrice.eSmall;
            }

            LbMoney.Text = TotalPrice.ToString();
            
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                TotalPrice += (int)enSizePrice.eMedium;
            }
            else if (!rbMedium.Checked)
            {
                TotalPrice -= (int)enSizePrice.eMedium;
            }

            LbMoney.Text = TotalPrice.ToString();
        }
        
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                TotalPrice += (int)enSizePrice.eLarge;
            }
            else if (!rbLarge.Checked)
            {
                TotalPrice -= (int)enSizePrice.eLarge;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExtraCheese.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eExtraCheese;
            }
            else if (!cbExtraCheese.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eExtraCheese;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMushrooms.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eMushrooms;
            }
            else if (!cbMushrooms.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eMushrooms;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTomatoes.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eTomatoes;
            }
            else if (!cbTomatoes.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eTomatoes;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnions.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eOnions;
            }
            else if (!cbOnions.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eOnions;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOlives.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eOlives;
            }
            else if (!cbOlives.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eOlives;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void cbGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreenPapers.Checked)
            {
                TotalPrice += (int)enToppingsPrice.eGreenPapers;
            }
            else if (!cbGreenPapers.Checked)
            {
                TotalPrice -= (int)enToppingsPrice.eGreenPapers;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                TotalPrice += (int)enCrustPrice.eThin;
            }
            else if (!rbThin.Checked)
            {
                TotalPrice -= (int)enCrustPrice.eThin;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                TotalPrice += (int)enCrustPrice.eThick;
            }
            else if (!rbThick.Checked)
            {
                TotalPrice -= (int)enCrustPrice.eThick;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                TotalPrice += (int)enWhereToEatPrice.eEatIn;
            }
            else if (!rbEatIn.Checked)
            {
                TotalPrice -= (int)enWhereToEatPrice.eEatIn;
            }

            LbMoney.Text = TotalPrice.ToString();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                TotalPrice += (int)enWhereToEatPrice.eTakeOut;
            }
            else if (!rbTakeOut.Checked)
            {
                TotalPrice -= (int)enWhereToEatPrice.eTakeOut;
            }

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
    }
}
