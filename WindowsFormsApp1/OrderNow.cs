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
    public partial class OrderNow : Form
    {
        public static String Fname, Lname, email, MbNumber;
        public static int tblNumber, members;
        public static bool timeBreakfast, timeLunch, timeDinner;
        public static int FrmNumber;

        public OrderNow()
        {
            InitializeComponent();
            this.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //text feelds
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtMbNum.Text = "";

            //rdb button
            rdbBrkFst.Checked = false;
            rdbLnch.Checked = false;
            rdbDnr.Checked = false;

            //coboBox
            cmbMbr.ResetText();
            cmbTblNum.ResetText();
            
            
        }

        

        private void btnMls_Click(object sender, EventArgs e)
        {

            //if there any empty slots are there then it wont load next page
            if (txtFName.Text.Trim() == "" || txtLName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtMbNum.Text.Trim() == ""|| (rdbBrkFst.Checked == false && rdbDnr.Checked == false && rdbLnch.Checked == false) ||clstCntct.CheckedItems.Count == 0 || cmbTblNum.SelectedItem == null || cmbMbr.SelectedItem == null)
            {


                MessageBox.Show("Some feelds are not Filld");

            }
            else {//all fill then load next form
                Fname = txtFName.Text;
                Lname = txtLName.Text;
                email = txtEmail.Text;
                MbNumber = txtMbNum.Text;
                tblNumber = (int)cmbTblNum.SelectedItem; //casting to int
                members = (int)cmbMbr.SelectedItem;//same above

                timeBreakfast = rdbBrkFst.Checked;//assign boolinavalue
                timeDinner = rdbDnr.Checked;
                timeLunch = rdbLnch.Checked;

                TotalBill totalBill = new TotalBill();//pass to billing process
                Meals meals = new Meals();
                meals.Show();
                this.Close();//add beore meals.show();
            }


        }

        private void btnHm_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void OrderNow_Load(object sender, EventArgs e)
        {
            FrmNumber = 3;

            for (int i = 1; i < 41; i++) { //i as loop counter
                cmbTblNum.Items.Add(i);//fill the combo box table Numbers
                cmbMbr.Items.Add(i);//fill the membur combo box
            }

        }
    }
}
