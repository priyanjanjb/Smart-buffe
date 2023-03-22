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
    public partial class Noodles : Form
    {
        int NumberOfPlatesNormalNdls, NumberOfPlatesEggNdls, NumberOfPlatesChikenNdls;//Noodles plates
        bool typeNormalFishNdls, typeNormalChknNdls, typeNormalVeggiNdls;//for normal Noodles radio button
        bool typeEggFishNdls, typeEggChiknNdls, typeEggMutnNdls;//for egg Noodles
        bool typeChknFishGrvNdls, typeChknChiknGrvNdls, typeChknMutnGrvNdls;//for chiken Noodles

        public static double total2;

        
        private void btnClearNdls_Click(object sender, EventArgs e)
        {
            //rdb buttons clear

            //normal noodles
            rdbChknNmlNdls.Checked = false;
            rdbNmlFishNdls.Checked = false;
            rdbVegNmlNdls.Checked = false;

            //egg noodles
            rdbFishEgNdls.Checked = false;
            rdbChknEgNdls.Checked = false;
            rdbMtnEgNdls.Checked = false;

            //chiken noodless
            rdbChknGrvNdls.Checked = false;
            rdbFishGrvNdls.Checked = false;
            rdbMutnGrvNdls.Checked = false;

            //numeric button clear
            numericUpDownNmlNdls.Value = 0;
            numericUpDownEgNdls.Value = 0;
            numericUpDownChknNdls.Value = 0;

        }

        


        public Noodles()
        {
            InitializeComponent();
            this.Show();
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            this.Close();
        }

        private void btnHmNdls_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void btnOrdrNdls_Click(object sender, EventArgs e)
        {
            //check if there are any empty feelds
            if ((rdbNmlFishNdls.Checked == false && rdbChknNmlNdls.Checked == false && rdbVegNmlNdls.Checked == false) && (rdbFishEgNdls.Checked == false && rdbChknEgNdls.Checked == false && rdbMtnEgNdls.Checked == false) && (rdbFishGrvNdls.Checked == false && rdbChknGrvNdls.Checked == false && rdbMutnGrvNdls.Checked == false) || (numericUpDownNmlNdls.Value == 0 && numericUpDownEgNdls.Value == 0 && numericUpDownChknNdls.Value == 0))
            {
                MessageBox.Show("Some items are not seleceted");
            }
            else
            {//if all values are filld then run this 


                //Check the true values and assign to the varivle to pass
                if (rdbNmlFishNdls.Checked == true)
                {

                    typeNormalFishNdls = true;

                }
                else if (rdbChknNmlNdls.Checked == true)
                {

                    typeNormalChknNdls = true;

                }
                else if (rdbVegNmlNdls.Checked == true)
                {

                    typeNormalVeggiNdls = true;
                    //Normal rice Part end

                }
                else if (rdbFishEgNdls.Checked == true)
                {

                    typeEggFishNdls = true;

                }
                else if (rdbChknEgNdls.Checked == true)
                {

                    typeEggChiknNdls = true;

                }
                else if (rdbMtnEgNdls.Checked == true)
                {

                    typeEggMutnNdls = true;
                    //Egg rice part End
                }
                else if (rdbFishGrvNdls.Checked == true)
                {

                    typeChknFishGrvNdls = true;

                }
                else if (rdbChknGrvNdls.Checked == true)
                {

                    typeChknChiknGrvNdls = true;

                }
                else if (rdbMutnGrvNdls.Checked == true)
                {

                    typeChknMutnGrvNdls = true;
                    //Chiken rice part
                }


                //Count the number of plates and assign to the varible to pass to parameter
                NumberOfPlatesNormalNdls = (int)numericUpDownNmlNdls.Value;
                NumberOfPlatesEggNdls = (int)numericUpDownEgNdls.Value;
                NumberOfPlatesChikenNdls = (int)numericUpDownChknNdls.Value;


                if (NumberOfPlatesNormalNdls > 0)
                {

                    total2 = 200 * NumberOfPlatesNormalNdls;

                }
                if (NumberOfPlatesEggNdls > 0)
                {

                    total2 = total2 + (200 * NumberOfPlatesEggNdls) + 50;

                }
                if (NumberOfPlatesChikenNdls > 0)
                {

                    total2 = total2 + (200 * NumberOfPlatesEggNdls) + 100;
                }




                //pass the values to the total bill form
                TotalBill ttbill = new TotalBill(typeNormalFishNdls, typeNormalChknNdls, typeNormalVeggiNdls, typeEggFishNdls, typeEggChiknNdls, typeEggMutnNdls, typeChknFishGrvNdls, typeChknChiknGrvNdls, typeChknMutnGrvNdls, NumberOfPlatesNormalNdls, NumberOfPlatesEggNdls, NumberOfPlatesChikenNdls);
                ttbill.Show();
                this.Close();//clos this form
            }
        }
    }
}
