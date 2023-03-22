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
    public partial class Booking : Form
    {

        public static String Fname, Lname, email,MbNumber;
        public static int FrmNumber;
        public static int tblNumber, members;
        public static bool timeBreakfast, timeLunch, timeDinner;

        


        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear text fields
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtMbNum.Text = "";

            //rdb button
            rdbBrkFst.Checked = false;
            rdbLnch.Checked = false; 
            rdbDnr.Checked = false;

            //combo box
            cmbMbNum.ResetText();
            cmbTblNum.ResetText();

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            FrmNumber = 1; //check the form type

            for (int i = 0; i < 40; i++)
            {
                cmbMbNum.Items.Add(i);// for cmbo box Number ofmemmbur
                cmbTblNum.Items.Add(i); //for table numbers
            }
        }

        public Booking()
        {
            InitializeComponent();
            this.Show();
        }

        private void btnHm_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void btnMls_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Trim() == "" || txtLName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtMbNum.Text.Trim() == "" || (rdbBrkFst.Checked == false && rdbDnr.Checked == false && rdbLnch.Checked == false) || clstCntct.CheckedItems.Count == 0 || cmbTblNum.SelectedItem == null || cmbMbNum.SelectedItem == null)
            {
                //check to the empty feelds

                MessageBox.Show("Some feelds are not Filld");

            }
            else
            {//all fill then load next form
                Fname = txtFName.Text;
                Lname = txtLName.Text;
                email = txtEmail.Text;
                MbNumber = txtMbNum.Text;//mobile number
                tblNumber = (int)cmbMbNum.SelectedItem; //casting to int
                members = (int)cmbTblNum.SelectedItem;//same above

                timeBreakfast = rdbBrkFst.Checked;//assign boolinavalue
                timeDinner = rdbDnr.Checked;
                timeLunch = rdbLnch.Checked;



                TotalBill totalBill = new TotalBill();//pass to billing process
                Meals meals = new Meals();
                meals.Show();
                this.Close();//add before meals.show();
            }
            
            
        }
    }
}
