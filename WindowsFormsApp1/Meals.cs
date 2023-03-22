using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Meals : Form
    {
        public Meals()
        {
            InitializeComponent();
            this.Show();
        }

        private void lnlDsrt_Click(object sender, EventArgs e)
        {

        }

        private void btnHmMls_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            Rice rice = new Rice();
            this.Close();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            this.Close();
        }

        private void btnNdls_Click(object sender, EventArgs e)
        {
            Noodles ndls = new Noodles();
            this.Close();
        }

        private void btnDsrt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
