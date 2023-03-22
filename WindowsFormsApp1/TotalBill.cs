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
    public partial class TotalBill : Form
    {


        //variables for rice
        int NumberOfPlatesNormal, NumberOfPlatesEgg, NumberOfPlatesChiken;
        bool typeNormalFish, typeNormalChkn, typeNormalVeggi;//for normal rice radio button
        bool typeEggFish, typeEggChikn, typeEggMutn;//for egg rice
        bool typeChknFishGrv, typeChknChiknGrv, typeChknMutnGrv;//for chiken rice


        //variables for noodles
        int NumberOfPlatesNormalNdls, NumberOfPlatesEggNdls, NumberOfPlatesChikenNdls;
        bool typeNormalFishNdls, typeNormalChknNdls, typeNormalVeggiNdls;//for normal rice radio button
        bool typeEggFishNdls, typeEggChiknNdls, typeEggMutnNdls;//for egg rice
        bool typeChknFishGrvNdls, typeChknChiknGrvNdls, typeChknMutnGrvNdls;//for chiken rice




        //Varibles For Drinks
        int NumberOfCupsNormalCfe, NumberOfCupsJc, NumberOfCupsSftDrink;//Soft dring Cups
        bool typeNormalCfe, typeMlkCfe, typeIceCfe;//for normal Coffee radio button
        bool typeOrngJc, typePnplJc, typeMngJc;//for Juice
        bool typeCclSft, typePpcSft, typeFntaSft;//for SoftDring


        //Calculation part

        public static double total;
        public static double rice = 100;//price


        public TotalBill()
        {
            InitializeComponent();
            
        }

        public TotalBill(int NumberOfPlatesNormal, int NumberOfPlatesEgg, int NumberOfPlatesChiken, bool typeNormalFish, bool typeNormalChkn, bool typeNormalVeggi, bool typeEggFish, bool typeEggChikn, bool typeEggMutn, bool typeChknFishGrv, bool typeChknChiknGrv, bool typeChknMutnGrv)
        {//normal rice constructor

            InitializeComponent();
            //number of plates
            this.NumberOfPlatesNormal = NumberOfPlatesNormal;
            this.NumberOfPlatesEgg = NumberOfPlatesEgg;
            this.NumberOfPlatesChiken = NumberOfPlatesChiken;
            //normal rice boolian
            this.typeNormalFish = typeNormalFish;
            this.typeNormalChkn = typeNormalChkn;
            this.typeNormalVeggi = typeNormalVeggi;
            //egg rice boolian
            this.typeEggFish = typeEggFish;
            this.typeEggChikn = typeEggChikn;
            this.typeEggMutn = typeEggMutn;
            //chicken rice boolian
            this.typeChknFishGrv = typeChknFishGrv;
            this.typeChknChiknGrv = typeChknChiknGrv;
            this.typeChknMutnGrv = typeChknMutnGrv;

        }


        public TotalBill(bool typeNormalFishNdls, bool typeNormalChknNdls, bool typeNormalVeggiNdls, bool typeEggFishNdls, bool typeEggChiknNdls, bool typeEggMutnNdls, bool typeChknFishGrvNdls, bool typeChknChiknGrvNdls, bool typeChknMutnGrvNdls, int NumberOfPlatesNormalNdls, int NumberOfPlatesEggNdls, int NumberOfPlatesChikenNdls)
        {

            //Constructor for Noodles (overload) 

            InitializeComponent();
            //number of plates
            this.NumberOfPlatesNormalNdls = NumberOfPlatesNormalNdls;
            this.NumberOfPlatesEggNdls = NumberOfPlatesEggNdls;
            this.NumberOfPlatesChikenNdls = NumberOfPlatesChikenNdls;
            //normal Noodls boolian
            this.typeNormalFishNdls = typeNormalFishNdls;
            this.typeNormalChknNdls = typeNormalChknNdls;
            this.typeNormalVeggiNdls = typeNormalVeggiNdls;
            //egg noodls boolian
            this.typeEggFishNdls = typeEggFishNdls;
            this.typeEggChiknNdls = typeEggChiknNdls;
            this.typeEggMutnNdls = typeEggMutnNdls;
            //chicken noodls boolian
            this.typeChknFishGrvNdls = typeChknFishGrvNdls;
            this.typeChknChiknGrvNdls = typeChknChiknGrvNdls;
            this.typeChknMutnGrvNdls = typeChknMutnGrvNdls;

        }


        public TotalBill(bool typeNormalCfe,int NumberOfCupsNormalCfe,int NumberOfCupsJc,int NumberOfCupsSftDrink,bool  typeMlkCfe,bool typeIceCfe,bool typePnplJc,bool typeOrngJc,bool typeMngJc,bool typeCclSft,bool typePpcSft, bool typeFntaSft)
        {
            //drink Constructor
            InitializeComponent();

            //Number Of Cups
            this.NumberOfCupsNormalCfe = NumberOfCupsNormalCfe;
            this.NumberOfCupsJc = NumberOfCupsJc;
            this.NumberOfCupsSftDrink = NumberOfCupsSftDrink;

            //Boolians Coffee
            this.typeNormalCfe = typeNormalCfe;
            this.typeMlkCfe = typeMlkCfe;
            this.typeIceCfe = typeIceCfe;

            //Juice
            this.typeOrngJc = typeOrngJc;
            this.typePnplJc = typePnplJc;
            this.typeMngJc = typeMngJc;

            //Soft Drink

            this.typeCclSft = typeCclSft;
            this.typePpcSft = typePpcSft;
            this.typeFntaSft = typeFntaSft;
        }






        private void TotalBill_Load(object sender, EventArgs e)
        {

            //price for rice 
            txtRcTotlePrice.Text = Rice.total.ToString();

           // price for noodles
            txtNdlsTotlePrice.Text = Noodles.total2.ToString();

           // price for drink
            txtDrinkTotlePrice.Text = Drink.total3.ToString();

            {
                normalRice();
                EggRice();
                ChiknRice();

                //Rice

                void normalRice() {

                    //normal plates (fish,chikan,Veggi)
                    if (NumberOfPlatesNormal > 0 && (typeNormalFish == true))
                    {
                        cboxNmlFishCrry.Checked = typeNormalFish;//assign value to total bill text box to show users
                        txtRcFishCry.Text = NumberOfPlatesNormal.ToString();

                    }
                    else if (NumberOfPlatesNormal > 0 && (typeNormalChkn == true))
                    {
                        cboxNmlChknCrry.Checked = typeNormalChkn;
                        txtRcChknCry.Text = NumberOfPlatesNormal.ToString();

                    }
                    else if (NumberOfPlatesNormal > 0 && (typeNormalVeggi == true))
                    {


                        cboxNmlVeggiCrry.Checked = typeNormalVeggi;
                        txtRcVeggiCry.Text = NumberOfPlatesNormal.ToString();


                    }

                    EggRice();
                    
                }
                

                void EggRice() {
                    //Egg rice (fish,chikcen,mutton)
                    if (NumberOfPlatesEgg > 0 && (typeEggFish == true))
                    {

                        cboxEggFishCrry.Checked = typeEggFish;
                        txtRcEgFishCrry.Text = NumberOfPlatesEgg.ToString();


                    }
                    else if (NumberOfPlatesEgg > 0 && (typeEggChikn == true))
                    {

                        cboxEggChknCrry.Checked = typeEggChikn;
                        txtRcEgChknCry.Text = NumberOfPlatesEgg.ToString();


                    }
                    else if (NumberOfPlatesEgg > 0 && (typeEggMutn == true))
                    {

                        cboxEggMtnCrry.Checked = typeEggMutn;
                        txtRcEgMutCry.Text = NumberOfPlatesEgg.ToString();

                        ChiknRice();
                    }
                }

                
                void ChiknRice() {
                    //Chiken rice (fish,chiken,mutn gravy)
                    if (NumberOfPlatesChiken > 0 && (typeChknFishGrv == true))
                    {
                        cboxFishGrv.Checked = typeChknFishGrv;
                        txtRcChknChknGrv.Text = NumberOfPlatesChiken.ToString();


                    }
                    else if (NumberOfPlatesChiken > 0 && (typeChknChiknGrv == true))
                    {


                        cboxChknGrv.Checked = typeChknChiknGrv;
                        txtRcChknChknGrv.Text = NumberOfPlatesChiken.ToString();

                    }
                    else if (NumberOfPlatesChiken > 0 && (typeChknMutnGrv == true))
                    {

                        cboxMtnGrv.Checked = typeChknMutnGrv;
                        txtRcChknMutGrv.Text = NumberOfPlatesChiken.ToString();
                    }

                    //
                }


                




            }

            //------------------------------------------------------------------------------------------


            { // Noodles
              //normal plates (fish,chikan,Veggi)
                if (NumberOfPlatesNormalNdls > 0 && (typeNormalFishNdls == true))
                {
                    cboxNmlFishCrryNdls.Checked = typeNormalFishNdls;//assign value to total bill text box to show users
                    txtNdlsFishCry.Text = NumberOfPlatesNormalNdls.ToString();//number of pltes

                }
                else if (NumberOfPlatesNormalNdls > 0 && (typeNormalChknNdls == true))
                {
                    cboxNmlChknCrryNdls.Checked = typeNormalChknNdls;
                    txtNdlsChknCry.Text = NumberOfPlatesNormalNdls.ToString();

                }
                else if (NumberOfPlatesNormalNdls > 0 && (typeNormalVeggiNdls == true))
                {


                    cboxNmlVeggiCrryNdls.Checked = typeNormalVeggiNdls;
                    txtNdlsVeggiCry.Text = NumberOfPlatesNormalNdls.ToString();


                }
                else { }



                //Egg Noodles (fish,chikcen,mutton)
                if (NumberOfPlatesEggNdls > 0 && (typeEggFishNdls == true))
                {

                    cboxEggFishCrryNdls.Checked = typeEggFishNdls;
                    txtNdlsEgFishCry.Text = NumberOfPlatesEggNdls.ToString();


                }
                else if (NumberOfPlatesEggNdls > 0 && (typeEggChiknNdls == true))
                {

                    cboxEggChknCrryNdls.Checked = typeEggChiknNdls;
                    txtNdlsEgChknCry.Text = NumberOfPlatesEggNdls.ToString();


                }
                else if (NumberOfPlatesEggNdls > 0 && (typeEggMutnNdls == true))
                {

                    cboxEggMtnCrryNdls.Checked = typeEggMutnNdls;
                    txtNdlsEgMutCry.Text = NumberOfPlatesEggNdls.ToString();


                }




                //Chiken Noodles (fish,chiken,mutn gravy)
                if (NumberOfPlatesChikenNdls > 0 && (typeChknFishGrvNdls == true))
                {
                    cboxFishGrvNdls.Checked = typeChknFishGrvNdls;
                    txtNdlsChknChknGrv.Text = NumberOfPlatesChikenNdls.ToString();


                }
                else if (NumberOfPlatesChikenNdls > 0 && (typeChknChiknGrvNdls == true))
                {


                    cboxChknGrvNdls.Checked = typeChknChiknGrvNdls;
                    txtNdlsChknChknGrv.Text = NumberOfPlatesChikenNdls.ToString();

                }
                else if (NumberOfPlatesChikenNdls > 0 && (typeChknMutnGrvNdls == true))
                {

                    cboxMtnGrvNdls.Checked = typeChknMutnGrvNdls;
                    txtNdlsChknMutGrv.Text = NumberOfPlatesChikenNdls.ToString();
                }



            }//end of noodless scope

            //------------------------------------------------------------------------------------------------------------------------------------------------

            { //Drinks

                //Coffee
                if (NumberOfCupsNormalCfe > 0 && (typeNormalCfe == true))
                {
                    cboxNmlCfe.Checked = typeNormalCfe;//assign value to total bill text box to show users
                    txtCfeNml.Text = NumberOfCupsNormalCfe.ToString();//number of pltes

                }
                else if (NumberOfCupsNormalCfe > 0 && (typeMlkCfe == true))
                {
                    cboxMlkCfe.Checked = typeMlkCfe;
                    txtCfeMlk.Text = NumberOfCupsNormalCfe.ToString();

                }
                else if (NumberOfCupsNormalCfe > 0 && (typeIceCfe == true))
                {


                    cboxIceCfe.Checked = typeIceCfe;
                    txtCfeIce.Text = NumberOfCupsNormalCfe.ToString();


                }
                else { }



                //Jiuce
                if (NumberOfCupsJc > 0 && (typeOrngJc == true))
                {

                    cboxOrngJc.Checked = typeOrngJc;
                    txtJcOrg.Text = NumberOfCupsJc.ToString();


                }
                else if (NumberOfCupsJc > 0 && (typePnplJc == true))
                {

                    cboxPnplJc.Checked = typePnplJc;
                    txtJcPnpl.Text = NumberOfCupsJc.ToString();


                }
                else if (NumberOfCupsJc > 0 && (typeMngJc == true))
                {

                    cboxMngoJc.Checked = typeMngJc;
                    txtJcMng.Text = NumberOfCupsJc.ToString();


                }




                //Soft Drink
                if (NumberOfCupsSftDrink > 0 && (typePpcSft == true))
                {
                    cboxPpcSft.Checked = typePpcSft;
                    txtSftPpc.Text = NumberOfCupsSftDrink.ToString();


                }
                else if (NumberOfCupsSftDrink > 0 && (typePpcSft == true))
                {


                    cboxCclSft.Checked = typePpcSft;
                    txtSftCcl.Text = NumberOfCupsSftDrink.ToString();

                }
                else if (NumberOfCupsSftDrink > 0 && (typeFntaSft == true))
                {

                    cboxFntaSft.Checked = typeFntaSft;
                    txtSftFnt.Text = NumberOfCupsSftDrink.ToString();
                }



            }


            





        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            BillInformation billinfo = new BillInformation();
            billinfo.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNdlsTotlePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetNumberOfPlatesChiken()
        {
            return NumberOfPlatesChiken;
        }


        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
