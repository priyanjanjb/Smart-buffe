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
    public partial class Delivery : Form
    {

        public static String Fname, Lname, email, MbNumber,address;
        public static int members;
        public static int FrmNumber;
        public static bool timeBreakfast, timeLunch, timeDinner;

        private void cmbMbr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            FrmNumber = 2;//check the form type

            for (int i = 0; i < 40; i++) {
                cmbMbr.Items.Add(i);//for number of memburs
            }
        }

        public Delivery()
        {
            InitializeComponent();
            this.Show();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {//clear the typed values
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtMbNum.Text = "";
            //address
            txtAdrsNo.Text = "";
            txtAddrStrt.Text = "";
            txtAddrCity.Text = "";

            //rdb button time
            rdbBrkFst.Checked = false;
            rdbDnr.Checked = false;
            rdbLnch.Checked = false;

            //rdb near place
            rdbMtl.Checked = false;
            rdbKnd.Checked = false;
            rdbNe.Checked = false;

            //cobo box
            cmbMbr.ResetText();



        }

        private void cmbTblNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMls_Click(object sender, EventArgs e)
        {
            //if there any empty slots are there then it wont load next page
            if (txtFName.Text.Trim() == "" || txtLName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtMbNum.Text.Trim() == "" || (rdbBrkFst.Checked == false && rdbDnr.Checked == false && rdbLnch.Checked == false) ||(rdbMtl.Checked==false &&  rdbKnd.Checked==false && rdbNe.Checked==false)|| cmbMbr.SelectedItem == null || txtAdrsNo.Text.Trim() =="" || txtAddrCity.Text.Trim() == "" || txtAddrStrt.Text.Trim() == "")
            {


                MessageBox.Show("Some feelds are not Filld");

            }
            else
            {//all fill then load next form
                Fname = txtFName.Text;
                Lname = txtLName.Text;
                email = txtEmail.Text;
                MbNumber = txtMbNum.Text;
                members = (int)cmbMbr.SelectedItem; //casting to int
                address = (txtAdrsNo + " \n" + txtAddrStrt + " \n" + txtAddrCity);

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
    }
}
