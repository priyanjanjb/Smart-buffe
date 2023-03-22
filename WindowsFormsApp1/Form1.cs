using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Index Number: ICT 19848
 Name J.B.P.perera
 Assignment 02
 SUbject Code: ITC 2303
 */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExt.Text = "Exit";
        }

        private void btnBookingMl_Click(object sender, EventArgs e)
        {
            Booking bking = new Booking(); //create object to access booking form
            this.Hide();//when loard the booking form this form will hide
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderNow ordrNow = new OrderNow();
            this.Hide();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        
    }
}
