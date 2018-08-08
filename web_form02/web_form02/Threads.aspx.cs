using System;
using System.Threading;
using System.Web;
using System.Web.UI;

namespace web_form02
{

    public partial class Threads : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            ThreadStart runnable = new ThreadStart(subThreadFunction);
            Response.Write("sub thread will start<br/>");

            Thread subThread = new Thread(runnable);
            subThread.Priority = ThreadPriority.Highest;
            subThread.Start();

            Response.Write("Main Thread Will Sleep 2 s<br/>");
            Thread.Sleep(2000);
            Response.Write("Main Thread Will Abort SubThread<br/>");
            subThread.Abort();
        }

        public void subThreadFunction(){
            try{
                id_label.Text = "<br/>sub Thread - started<br/>";

                id_label.Text += "<br/>sub Thread - count to 520<br/>";
                for (int i = 0; i < 520; i++){
                    Thread.Sleep(200);
                    id_label.Text += "<br/>in sub Thread For loop " + i + "<br/>";
                }
                id_label.Text += "<br/>sub Thread - task finished<br/>";
            }catch(ThreadAbortException e){
                id_label.Text += "<br/> sub Thread - Exception";
            }finally{
                id_label.Text += "<br/> finally code";
            }
        }
    }
}
