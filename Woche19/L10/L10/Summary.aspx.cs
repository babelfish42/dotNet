using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L10
{
  public partial class Summary : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      this.txtFirstname.Text = (string)Session["Firstname"];
      this.txtLastname.Text = (string)Session["Lastname"];
      this.txtDate.Text = (string)Session["Date"];
    }
  }
}