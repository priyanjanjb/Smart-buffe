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
    public partial class Rice : Form
    {
        /// <summary>
        /// create global variable for easy access pupose
        /// </summary>
        int NumberOfPlatesNormal, NumberOfPlatesEgg, NumberOfPlatesChiken;//rice plates
        bool typeNormalFish, typeNormalChkn,typeNormalVeggi;//for normal rice radio button
        bool typeEggFish, typeEggChikn, typeEggMutn;//for egg rice
        bool typeChknFishGrv, typeChknChiknGrv, typeChknMutnGrv;//for chiken rice

        public static double rice = 200;//price of  all rice

        public static double total;



        private void btnClear_Click(object sender, EventArgs e)
        {
            //rdb buttons
            //normal rice
            rdbNmlFish.Checked = false;
            rdbNmlChkn.Checked = false;
            rdbNmlVeg.Checked = false;
            //egg rice
            rdbFishEg.Checked = false;
            rdbChknEg.Checked = false;
            rdbMtnEg.Checked = false;

            //chicken rice
            rdbChknGrv.Checked = false;
            rdbFishGrv.Checked = false;
            rdbMutnGrv.Checked = false;

            //numeric buttons
            numericUpDownChknRc.Value = 0;
            numericUpDownEgRc.Value = 0;
            numericUpDownRc.Value = 0;

        }

        public Rice()
        {
            InitializeComponent();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRiceNorml_Click(object sender, EventArgs e)
        {

        }

        private void btnHm_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            this.Close();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {


            //check if there are any empty feelds
            if ((rdbNmlFish.Checked == false && rdbNmlChkn.Checked == false && rdbNmlVeg.Checked == false) && (rdbFishEg.Checked == false && rdbChknEg.Checked == false && rdbMtnEg.Checked == false) && (rdbFishGrv.Checked == false && rdbChknGrv.Checked == false && rdbMutnGrv.Checked == false) || (numericUpDownRc.Value == 0 && numericUpDownEgRc.Value == 0 && numericUpDownChknRc.Value == 0))
            {
                MessageBox.Show("Some items are not seleceted");  
            }
            else {//if all values are filld then run this 

                if (rdbNmlFish.Checked == true) {

                    typeNormalFish = true;

                } else if (rdbNmlChkn.Checked == true) {

                    typeNormalChkn = true;

                } else if (rdbNmlVeg.Checked == true) {

                    typeNormalVeggi = true;
                    //Normal rice Part end

                } else if (rdbFishEg.Checked == true) {

                    typeEggFish = true;

                } else if (rdbChknEg.Checked == true) {

                    typeEggChikn = true;

                } else if (rdbMtnEg.Checked == true) {

                    typeEggMutn = true;
                    //Egg rice part End
                } else if (rdbFishGrv.Checked == true) {

                    typeChknFishGrv = true;

                } else if (rdbChknGrv.Checked == true) {

                    typeChknChiknGrv = true;
                   
                } else if (rdbMutnGrv.Checked == true) {

                    typeChknMutnGrv = true;
                    //Chiken rice part
                }
                NumberOfPlatesNormal = (int)numericUpDownRc.Value;
                NumberOfPlatesEgg = (int)numericUpDownEgRc.Value;
                NumberOfPlatesChiken= (int)numericUpDownChknRc.Value;

                if (NumberOfPlatesNormal > 0) {

                    total = rice * NumberOfPlatesNormal;

                } 
                if (NumberOfPlatesEgg > 0) {

                    total = total+(rice * NumberOfPlatesEgg) + 50;

                }
                if (NumberOfPlatesChiken> 0 ) {

                    total =  total+(rice * NumberOfPlatesChiken) + 100;
                }


                TotalBill ttbill = new TotalBill(NumberOfPlatesNormal, NumberOfPlatesEgg, NumberOfPlatesChiken, typeNormalFish, typeNormalChkn, typeNormalVeggi, typeEggFish, typeEggChikn, typeEggMutn, typeChknFishGrv, typeChknChiknGrv, typeChknMutnGrv);
                ttbill.Show();
                this.Close();
            }
        }
    }
}
