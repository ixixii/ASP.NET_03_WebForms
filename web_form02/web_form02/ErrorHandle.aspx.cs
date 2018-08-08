using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form02
{

    public partial class ErrorHandle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            Trace.Write("Trace_Write");
            Trace.Warn("Trace_Warn");


            if(!IsPostBack){
                string[,] tmpArr = {
                    {"a1","b1"},
                    {"a2","b2"},
                    {"a3","b3"}
                };

                for (int i = 0; i < tmpArr.GetLength(0); i++){
                    id_dropDown.Items.Add(new ListItem(tmpArr[i, 0], tmpArr[i, 1]));

                }
            }
        }

        protected void id_dropDown_SelectedIndexChanged(object sender, EventArgs e){

            try{
                int a = 0;
                int b = 1 / a;
            }catch(Exception ex){
                Trace.Warn("User_Defined_Catergory", "trace_warn_message", ex);
            }

            if(id_dropDown.SelectedIndex != -1){
                id_label2.Text = String.Format("{0}, Maxim: {1}", id_dropDown.SelectedItem.Text, id_dropDown.SelectedValue);
            }
        }
    }
}
