using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogecoin_API
{
    public partial class ConvertToDoge : Form
    {
        public double dogeAmount = 0;
        public ConvertToDoge()
        {
            InitializeComponent();

            tmr_Update.Tick += Tmr_Update_Tick;

            Shown += ConvertToDoge_Shown;

            txt_DogeAmount.GotFocus += Txt_DogeAmount_GotFocus;
            txt_DogeAmount.LostFocus += Txt_DogeAmount_LostFocus;

            btn_Submit.Click += Btn_Submit_Click;

            AcceptButton = btn_Submit;

            lbl_DOGE.Text = "DOGE: " + dogeAmount;

        }

        private void ConvertToDoge_Shown(object sender, EventArgs e)
        {
            lbl_DOGE.Focus();
            UpdateUSDValue();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            bool parseSuccess = double.TryParse(txt_DogeAmount.Text, out dogeAmount);
            if (parseSuccess)
            {
                lbl_DOGE.Text = "DOGE: " + dogeAmount.ToString();
                tmr_Update.Enabled = true;
                UpdateUSDValue();
            }
            else
            {
                MessageBox.Show("Value is invalid for this operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DogeAmount.Focus();
                txt_DogeAmount.Clear();
            }
        }

        private void Txt_DogeAmount_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_DogeAmount.Text))
            {
                txt_DogeAmount.Text = "Enter Doge Amount";
            }
        }

        private void Txt_DogeAmount_GotFocus(object sender, EventArgs e)
        {
            if (txt_DogeAmount.Text == "Enter Doge Amount")
            {
                txt_DogeAmount.Clear();
            }
        }

        private void UpdateUSDValue()
        {
            if (dogeAmount != 0)
            {
                lbl_USD.Text = "USD: $" + Math.Round(dogeAmount * MainUI.currentValue, 2);
            }
            else
            {
                lbl_USD.Text = "USD: $0.00";
            }
        }

        private void Tmr_Update_Tick(object sender, EventArgs e)
        {
            UpdateUSDValue();
        }
    }
}
