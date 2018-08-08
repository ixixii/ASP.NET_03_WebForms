using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form_01
{
	public partial class Datasource6 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// 页面的时候 虽然 会变， 但是 SQL查询结果却已经 被 缓存起来了 60秒
			id_label.Text = String.Format("Page posted at : {0}", DateTime.Now.ToLongTimeString());
		}
	}
}