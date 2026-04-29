using System;
using System.Web;
using System.Web.SessionState;

namespace Tank.Flash
{
    public class sectionlive : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            string username = context.Session["username"] as string;
            string password = context.Session["password"] as string;

            context.Response.ContentType = "text/plain";
            if (!string.IsNullOrEmpty(username)
                && !string.IsNullOrEmpty(password)
                && LoadingManager.Login(username, password))
            {
                context.Response.Write("live");
            }
            else
            {
                context.Response.Write("logout");
            }
        }

        public bool IsReusable => false;
    }
}