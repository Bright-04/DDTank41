using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Tank.Flash
{
    public partial class CanLoading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"] as string;
            string password = Session["password"] as string;
            bool canLoading = !string.IsNullOrEmpty(username)
                && !string.IsNullOrEmpty(password)
                && LoadingManager.Login(username, password);

            Response.ContentType = "text/plain";
            Response.Write(canLoading ? "true" : "false");

        }
    }
}
