<%@ WebHandler Language="C#" Class="Tank.Request.LoginSelectListDebug" %>

using System;
using System.Web;

namespace Tank.Request
{
    public class LoginSelectListDebug : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("HELLO WORLD");
        }
    }
}
