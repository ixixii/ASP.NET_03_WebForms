using System;
using System.Threading;
using System.Web;
using System.Web.UI;

namespace web_form02
{

    public partial class Cache1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            Thread.Sleep(1000);
            Response.Write("This Page is Cached at : " + DateTime.Now.ToString());
        }
    }
}
