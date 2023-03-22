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
    public partial class BillInformation : Form
    {

        

        

        public BillInformation()
        {
            InitializeComponent();
        }


        


        private void BillInformation_Load(object sender, EventArgs e)
        {
            //booking Form
            if (Booking.FrmNumber == 1)
            {

                lblFullNameOut.Text = Booking.Fname + " " + Booking.Lname;
                lblEmlOut.Text = Booking.email;
                lblPhnNumOut.Text = Booking.MbNumber;
                lblMemberOut.Text = Booking.members.ToString();
                lblTblNumOut.Text = Booking.tblNumber.ToString();
                lblFrmTypeOut.Text = "Booking";
                lblAdrsOut.Text = "NO";

                //check time
                if (Booking.timeBreakfast == true)
                {

                    lblTimeOut.Text = "Breakfast";

                }
                else if (Booking.timeLunch == true)
                {

                    lblTimeOut.Text = "Lunch";
                }
                else
                {
                    lblTimeOut.Text = "Dinner";
                }

                //Delivery form
            }
            else if (Delivery.FrmNumber == 2)
            {
                //get static values and asing to billing form labels


                lblFullNameOut.Text = Delivery.Fname + " " + Delivery.Lname;
                lblEmlOut.Text = Delivery.email;
                lblPhnNumOut.Text = Delivery.MbNumber;
                lblMemberOut.Text = Delivery.members.ToString();
                lblTblNumOut.Text = "No";
                lblFrmTypeOut.Text = "Delivery";
                lblAdrsOut.Text = Delivery.address;

                //check time
                if (Delivery.timeBreakfast == true)
                {

                    lblTimeOut.Text = "Breakfast";

                }
                else if (Delivery.timeLunch == true)
                {

                    lblTimeOut.Text = "Lunch";
                }
                else
                {
                    lblTimeOut.Text = "Dinner";
                }

            }
            //Form Order now
            else {

                lblFullNameOut.Text = OrderNow.Fname + " " + OrderNow.Lname;
                lblEmlOut.Text = OrderNow.email;
                lblPhnNumOut.Text = OrderNow.MbNumber;
                lblMemberOut.Text = OrderNow.members.ToString();
                lblTblNumOut.Text = OrderNow.tblNumber.ToString() ;
                lblFrmTypeOut.Text = "Order Now";
                lblAdrsOut.Text = "NO";

                //check time
                if (OrderNow.timeBreakfast == true)
                {

                    lblTimeOut.Text = "Breakfast";

                }
                else if (OrderNow.timeLunch == true)
                {

                    lblTimeOut.Text = "Lunch";
                }
                else
                {
                    lblTimeOut.Text = "Dinner";
                }
            }

            //delivery form


            
            
           

            if (Rice.total > 0)
            {

                lblBilltotal.Text = Rice.total.ToString();

            }
            else if (Noodles.total2 > 0)
            {
                lblBilltotal.Text = Noodles.total2.ToString();
            }
            else {

                lblBilltotal.Text = Drink.total3.ToString();
            }


        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();//application exit
        }
    }
}
