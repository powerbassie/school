using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /*
     * 
     * Label1 is de geselecteerde datum
     * Label2 is de leeftijd
     * 
     * */
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime datum = KalVerjaardag.SelectedDate;
        Label1.Text = "U heeft de onderstaande datum geselecteerd:<br><br> " + datum;


    }

    protected void KalVerjaardag_SelectionChanged(object sender, EventArgs e)
    {

    }
}