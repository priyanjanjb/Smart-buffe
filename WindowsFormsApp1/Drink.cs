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
    public partial class Drink : Form
    {

        int NumberOfCupsNormalCfe, NumberOfCupsJc, NumberOfCupsSftDrink;//Soft dring Cups
        bool typeNormalCfe, typeMlkCfe, typeIceCfe;//for normal Coffee radio button
        bool typeOrngJc, typePnplJc, typeMngJc;//for Juice

        public static double total3;

        private void btnClear_Click(object sender, EventArgs e)
        {
            //rdb Button clear
            //coffee
            rdbNmlCfe.Checked = false;
            rdbMlkCfe.Checked = false;
            rdbIceCfe.Checked = false;

            //juice
            rdbOrngJc.Checked = false;
            rdbPnplJc.Checked = false;
            rdbMngJc.Checked = false;

            //soft drink
            rdbSftCcl.Checked = false;
            rdbSftFnta.Checked = false;
            rdbSftPpc.Checked = false;

            //numeric values
            numericUpDownCfe.Value = 0;
            numericUpDownJc.Value = 0;
            numericUpDownSft.Value = 0;

        }

        bool typeCclSft, typePpcSft, typeFntaSft;//for SoftDring

        public Drink()
        {
            InitializeComponent();
            this.Show();
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

        private void btnOrdrDrink_Click(object sender, EventArgs e)
        {
            //check if there are any empty feelds
            if ((rdbNmlCfe.Checked == false && rdbMlkCfe.Checked == false && rdbIceCfe.Checked == false) && (rdbOrngJc.Checked == false && rdbPnplJc.Checked == false && rdbMngJc.Checked == false) && (rdbSftPpc.Checked == false && rdbSftCcl.Checked == false && rdbSftFnta.Checked == false) || (numericUpDownCfe.Value == 0 && numericUpDownJc.Value == 0 && numericUpDownSft.Value == 0))
            {
                MessageBox.Show("Some items are not seleceted");
            }
            else
            {//if all values are filld then run this 

                if (rdbNmlCfe.Checked == true)
                {

                    typeNormalCfe = true;//

                }
                else if (rdbMlkCfe.Checked == true)
                {

                    typeMlkCfe = true;//

                }
                else if (rdbIceCfe.Checked == true)
                {

                    typeIceCfe = true;//
                    //Normal Coffee Part end

                }
                else if (rdbPnplJc.Checked == true)
                {

                    typePnplJc = true;//

                }
                else if (rdbOrngJc.Checked == true)
                {

                    typeOrngJc = true;//

                }
                else if (rdbMngJc.Checked == true)
                {

                    typeMngJc = true;//
                    //Egg rice part End
                }
                else if (rdbSftCcl.Checked == true)
                {

                    typeCclSft = true;//

                }
                else if (rdbSftPpc.Checked == true)
                {

                    typePpcSft = true;//

                }
                else if (rdbSftFnta.Checked == true)
                {

                    typeFntaSft = true;
                    //Chiken rice part
                }
                NumberOfCupsNormalCfe = (int)numericUpDownCfe.Value;
                NumberOfCupsJc = (int)numericUpDownJc.Value;
                NumberOfCupsSftDrink = (int)numericUpDownSft.Value;

                // price Calculation
                if (NumberOfCupsNormalCfe > 0)
                {

                    total3 = 100 * NumberOfCupsNormalCfe;

                }
                if (NumberOfCupsJc > 0)
                {

                    total3 = total3 + (100 * NumberOfCupsJc) + 50;

                }
                if (NumberOfCupsSftDrink > 0)
                {

                    total3 = total3 + (100 * NumberOfCupsSftDrink) + 100;
                }



                TotalBill ttbill = new TotalBill(typeNormalCfe, NumberOfCupsNormalCfe, NumberOfCupsJc, NumberOfCupsSftDrink, typeMlkCfe, typeIceCfe, typePnplJc, typeOrngJc, typeMngJc, typeCclSft, typePpcSft, typeFntaSft);
                ttbill.Show();
                this.Close();
            }

        }
    }
}
