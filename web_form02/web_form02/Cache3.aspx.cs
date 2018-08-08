using System;
using System.Web;
using System.Web.UI;

namespace web_form02
{

    public partial class Cache3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            if(this.IsPostBack){
                id_label.Text += "Page Post Back <br/>";
            }else{
                id_label.Text += "Page Created<br/>";
            }

            if(Cache["Key_LastTime"] == null){
                id_label.Text += "Start To Cache LastTime for 30s<br/>";
                DateTime lastTime = DateTime.Now;
                Cache.Insert("Key_LastTime", lastTime,null,DateTime.Now.AddSeconds(30),TimeSpan.Zero);
            }else{
                id_label.Text += "Retrieving Last Time From Cache<br/>";
                DateTime lastTime = (DateTime)Cache["Key_LastTime"];
                id_label.Text += "Last Time is : " + lastTime.ToString() + "<br/>";
            }
            id_label.Text += "<br/>";
        }
    }
}
