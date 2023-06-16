using Klijent.KolikoJeSatiServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class Form1 : Form
    {
        KolikoJeSatiClient proxy;
        public Form1()
        {
            InitializeComponent();

            proxy = new KolikoJeSatiClient();
            proxy.VratiVremeCompleted += Proxy_VratiVremeCompleted;
        }

        private void btnProveri_Click(object sender, EventArgs e)
        {
            //txtVreme.Text = proxy.VratiVreme().ToString();
            proxy.VratiVremeAsync();
        }

        private void Proxy_VratiVremeCompleted(object sender, VratiVremeCompletedEventArgs e)
        {
            txtVreme.Text = e.Result.ToString();
        }

        private void btnPristup_Click(object sender, EventArgs e)
        {
            PristupLog log = proxy.KadJeBioZadnjiPristup();
            txtPristup.Text = $"{log.HostName} :: {log.TimeStamp}";
        }
    }
}
