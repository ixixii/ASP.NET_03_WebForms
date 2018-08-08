using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form_01
{
	public partial class Contact : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void id_btn4_Click(object sender, EventArgs e)
		{

			Console.WriteLine("btn clicked");
			Response.Write("----BtnClicked-----");

			StringBuilder sb = new StringBuilder();
			if (id_uploader.HasFile)
			{
				try
				{
					sb.AppendFormat("Uploading file: {0}", id_uploader.FileName);
					//id_uploader.SaveAs("<c:\\SaveDirectory>" + id_uploader.FileName);
					//sb.AppendFormat("<br/>Save As: {0}", id_uploader.PostedFile.FileName);
					//sb.AppendFormat("<br/>File Type: {0}", id_uploader.PostedFile.ContentType);
					//sb.AppendFormat("<br/>File Length: {0}", id_uploader.PostedFile.ContentLength);
					//sb.AppendFormat("<br/>File Name: {0}", id_uploader.PostedFile.FileName);
					id_label4.Text = sb.ToString();
				}
				catch (Exception ex)
				{
					sb.Append("<br/>Error<br/>");
					sb.AppendFormat("Unable to Upload File <br/> {0}", ex.Message);
					id_label4.Text = sb.ToString();
				}
			}
			else
			{
				id_label4.Text = sb.ToString();
			}
		}
	}
}