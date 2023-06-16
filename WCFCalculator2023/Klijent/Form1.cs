using Klijent.CalcServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class Form1 : Form, ICalcCallback
    {
        private CalcClient proxy;
        public Form1()
        {
            InitializeComponent();

            proxy = new CalcClient(new InstanceContext(this));
            proxy.Register(); //!!!!!!!!!!!!
        }

        public void Rezultat(Rezultat r)
        {
            txtIzraz.Text = r.Izraz;
            txtNumOutput.Text = r.Res.ToString();
            
        }

        private void saberiBtn_Click(object sender, EventArgs e)
        {
            decimal d;
            if(decimal.TryParse(txtNumInput.Text, out d))
            {
                proxy.Dodaj(d);

            }
            else
            {
                MessageBox.Show("Greska u prevodjenju broja!");
            }
        }

        private void saberiNoKolbekBtn_Click(object sender, EventArgs e)
        {
            
            decimal d;
            if (decimal.TryParse(txtNumInput.Text, out d))
            {
                Rezultat rez = proxy.DodajBezKolbeka(d);
                Rezultat(rez);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
