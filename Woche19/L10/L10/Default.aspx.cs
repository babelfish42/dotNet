using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L10
{
  public partial class _Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      // if the Data is already in the Session, make a redirect
      if (Session["Firstname"] != null && Session["Lastname"] != null &&
        Session["Date"] != null)
      {
        this.Response.Redirect("summary.aspx");
      }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
      // save the Data to the Session and make a Redirect
      Session["Firstname"] = this.txtFirstname.Text;
      Session["Lastname"] = this.txtLastname.Text;
      Session["Date"] = this.txtDate.Text;

      this.Response.Redirect("summary.aspx");
    }

    protected void valDateRange_ServerValidate(object source, ServerValidateEventArgs args)
    {
      // check if the Data is correct

      DateTime minDate = DateTime.Parse("1000/12/28");
      DateTime maxDate = DateTime.Parse("9999/12/28");
      DateTime dt;

      args.IsValid = (DateTime.TryParse(args.Value, out dt)
                      && dt <= maxDate
                      && dt >= minDate);
    }

  }
}
