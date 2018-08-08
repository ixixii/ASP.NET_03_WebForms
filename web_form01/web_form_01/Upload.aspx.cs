using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form_01
{
	public partial class Upload : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnUpload_Click(object sender, EventArgs e)
		{
			//判断是否上传了文件
			if (fileUpload.HasFile)
			{
				//指定上传文件在服务器上的保存路径
				string savePath = Server.MapPath("~/upload/");
				//检查服务器上是否存在这个物理路径，如果不存在则创建
				if (!System.IO.Directory.Exists(savePath))
				{
					//需要注意的是，需要对这个物理路径有足够的权限，否则会报错
					//另外，这个路径应该是在网站之下，而将网站部署在C盘却把文件保存在D盘
					System.IO.Directory.CreateDirectory(savePath);
				}
				savePath = savePath + "\\" + fileUpload.FileName;
				fileUpload.SaveAs(savePath);//保存文件
											//不过需要注意的是，在客户端访问却需要指定的是URL地址，而不是服务器上的物理地址
				literal.Text = string.Format("<a href='upload/{0}'>upload{0}</a>", fileUpload.FileName);
			}
		}
	}
}