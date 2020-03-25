using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TimeZones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void NorthAmericaTimeZone_Click(object sender, EventArgs e)
        {
            DateTime NorthAmerica = DateTime.Now;
            NorthAmerica = NorthAmerica.AddHours(-6);
            MessageBox.Show(NorthAmerica.ToLongTimeString(), "Time In North America");
        }

        private void SouthAmericaTimeZone_Click(object sender, EventArgs e)
        {
            DateTime SouthAmerica = DateTime.Now;
            SouthAmerica = SouthAmerica.AddHours(-3);
            MessageBox.Show(SouthAmerica.ToLongTimeString(), "Time In South America");
        }

        private void AfricaTimeZone_Click(object sender, EventArgs e)
        {
            DateTime Africa = DateTime.Now;
            Africa = Africa.AddHours(-2);
            MessageBox.Show(Africa.ToLongTimeString(), "Time In Africa");
        }

        private void EuropeTimeZone_Click(object sender, EventArgs e)
        {
            DateTime Europe = DateTime.Now;
            Europe = Europe.AddHours(1);
            MessageBox.Show(Europe.ToLongTimeString(), "Time In Europe");
        }

        private void AsiaTimeZone_Click(object sender, EventArgs e)
        {
            DateTime Asia = DateTime.Now;
            Asia = Asia.AddHours(6);
            MessageBox.Show(Asia.ToLongTimeString(), "Time In Asia");
        }

        private void AustraliaTimeZone_Click(object sender, EventArgs e)
        {
            DateTime Australia = DateTime.Now;
            Australia = Australia.AddHours(9);
            MessageBox.Show(Australia.ToLongTimeString(), "Time In Australia");
        }

        private void GreenLandTimeZone_Click(object sender, EventArgs e)
        {
            DateTime GreenLand = DateTime.Now;
            GreenLand = GreenLand.AddHours(-2);
            MessageBox.Show(GreenLand.ToLongTimeString(), "Time In GreenLand");
        }
    }
}
