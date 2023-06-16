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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userTxtBox.Text;
            Form1 forma = new Form1(name);
            forma.ShowDialog();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
