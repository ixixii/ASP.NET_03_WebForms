using System;
using System.Threading;
using System.Web;
using System.Web.UI;

namespace web_form02
{

    public partial class Cache2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Response.Write("This Page is Cached at : " + DateTime.Now.ToString());
        }

        protected void btnClicked(object sender, EventArgs e){
            Response.Write("<br/<br/>");
            Response.Write("<h2>Hello " + this.id_input_girlname.Text + "</h2>");

        }
    }
}
