using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Dogecoin_API
{
    public partial class MainUI : Form
    {
        public double originalValue = 0;
        public static double currentValue = 0;

        public MainUI()
        {
            InitializeComponent();
            tmr_Update.Tick += Tmr_Update_Tick;
            btn_Convert.Click += Btn_Convert_Click;
            foreach (Control c in Controls)
            {
                CenterControl(c);
            }
            UpdateValues();
        }

        private void UpdateValues()
        {
            WebRequest wr = WebRequest.Create("https://api.coinmarketcap.com/v1/ticker/dogecoin/");
            WebResponse response = wr.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader dataReader = new StreamReader(dataStream);
            string data = dataReader.ReadToEnd();
            data = data.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
            dynamic rawData = JObject.Parse(data);
            string priceUSD = rawData.price_usd;
            string changeHour = rawData.percent_change_1h;
            string changeDay = rawData.percent_change_24h;
            string changeWeek = rawData.percent_change_7d;
            //MessageBox.Show(priceUSD);

            currentValue = Convert.ToDouble(priceUSD);

            if (originalValue == 0)
            {
                originalValue = Convert.ToDouble(priceUSD);
            }

            lbl_Value.Text = "Value in USD: " + priceUSD;

            if (Convert.ToDouble(priceUSD) < originalValue)
            {
                lbl_Value.ForeColor = Color.Red;
            }
            else if (Convert.ToDouble(priceUSD) > originalValue)
            {
                lbl_Value.ForeColor = Color.Green;
            }
            else
            {
                lbl_Value.ForeColor = Color.Black;
            }

            //lbl_Gain.Text = "Value Gain: " + Math.Round(currentValue - originalValue, 3);
            //MessageBox.Show(originalValue.ToString());

            lbl_PC1H.Text = "Percent Change (1hr): " + changeHour + "%";
            lbl_PC1H.ForeColor = DetermineColor(Convert.ToDouble(changeHour));
            lbl_PC24H.Text = "Percent Change (24hr): " + changeDay + "%";
            lbl_PC24H.ForeColor = DetermineColor(Convert.ToDouble(changeDay));
            lbl_PC7D.Text = "Percent Change (7d): " + changeWeek + "%";
            lbl_PC7D.ForeColor = DetermineColor(Convert.ToDouble(changeWeek));

            foreach (Control c in Controls)
            {
                CenterControl(c);
            }
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            ConvertToDoge ctd = new ConvertToDoge();
            ctd.Show();
        }

        private void CenterControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
        }

        private Color DetermineColor(double value)
        {
            if (value > 0)
            {
                return Color.Green;
            }
            else if (value == 0)
            {
                return Color.Black;
            }
            else if (value < 0)
            {
                return Color.Red;
            }
            return Color.Black;
        }

        private void Tmr_Update_Tick(object sender, EventArgs e)
        {
            UpdateValues();
        }
    }
}
