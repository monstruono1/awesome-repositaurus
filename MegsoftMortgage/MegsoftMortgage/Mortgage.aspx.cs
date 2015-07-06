using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegsoftMortgage
{
    public partial class Mortgage : System.Web.UI.Page
    {
        double amount, downPayment, monthly, credit, total;
        int years; 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Good")
            {
                credit = 0.028;

            }
            else if (DropDownList1.SelectedValue == "Bad")
            {
                credit = 0.09;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            amount = double.Parse(TextBox2.Text);
            downPayment = double.Parse(TextBox3.Text);
            years = int.Parse(TextBox4.Text);

            double partial = amount - downPayment;
            total = (partial * credit) + partial;
            int months = years * 12;
            monthly = total / months;

            Label1.Text = (credit * 100).ToString() + "%";
            Label2.Text = total.ToString("C");
            Label3.Text = monthly.ToString("C");

            
            


        }

      
    }
}