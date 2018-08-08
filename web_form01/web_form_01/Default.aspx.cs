using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form_01
{
	public partial class _Default : Page
	{
		/*
		 * Page Init 
Page Load 
Page PreRender 


Page Load 
Page Post Back 
Btn Clicked
Page PreRender 

Page Load 
Page Post Back 
Btn Clicked
Page PreRender 
		 */
		protected void Page_Load(object sender, EventArgs e)
		{
			id_lable.Text += "2. Page Load <br/>";
			if (Page.IsPostBack) {
				id_lable.Text += "Page Post Back <br/>";
			}

			// ---------------------------------------------
			if (!IsPostBack)
			{
				DataSet ds = CreateDataSetFunction();
				id_gridView.DataSource = ds.Tables["Girl"];
				id_gridView.DataBind();
			}
			// ---------------------------------------------
			id_label3.Text = "";
			id_input3.Text = "";
		}



		protected void Page_Init(object sender, EventArgs e)
		{
			id_lable.Text += "1. Page Init <br/>";
		}

		protected void Page_PreRender(object sender, EventArgs e)
		{
			id_lable.Text += "3. Page PreRender <br/>";
		}

		protected void id_btn_Click(object sender, EventArgs e)
		{
			id_lable.Text += "Btn Clicked<br/>";
		}

		protected void id_btn2_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(id_input.Text))
			{
				id_label2.Text = "Hello " +Server.HtmlEncode(id_input.Text) + "<br/>" +
					"Url is :" + Server.UrlEncode(Request.Url.ToString());
					
			}
		}
		// -------------------------------------------
		private DataSet CreateDataSetFunction()
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = CreateGirlTableFunction();
			dataSet.Tables.Add(dataTable);
			return dataSet;
		}
		private DataTable CreateGirlTableFunction()
		{
			DataTable dataTable = new DataTable("Girl");
			AddNewColumnFunction(dataTable, "System.Int32", "GirlID");
			AddNewColumnFunction(dataTable, "System.String", "GirlName");
			AddNewColumnFunction(dataTable, "System.Int32", "GirlAge");

			AddNewRowFunction(dataTable, 1, "Saber", 14);
			AddNewRowFunction(dataTable, 2, "Mathilda", 12);
			AddNewRowFunction(dataTable, 3, "Menma", 13);

			return dataTable;
		}

		private void AddNewColumnFunction(DataTable dataTable, string columnType, 
			string columnName)
		{
			// excuse me ???
			//System.Console.wOut(columnName);
			DataColumn dataColumn = 
				dataTable.Columns.Add(columnName, Type.GetType(columnType));
		}

		private void AddNewRowFunction(DataTable dataTable, int id, string girlName, int age)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["girlID"] = id;
			dataRow["girlName"] = girlName;
			dataRow["girlAge"] = age;
			dataTable.Rows.Add(dataRow);
		}

		protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
		{
			id_input3.Text = " ";
			id_label3.Text = "Selected Node is : " + id_treeView1.SelectedNode.Text;
			TreeNodeCollection childNodeArr = id_treeView1.SelectedNode.ChildNodes;
			if(childNodeArr != null)
			{
				id_input3.Text = " ";
				foreach(TreeNode node in childNodeArr)
				{
					id_input3.Text += node.Value;
				}
			}
		}

		
	}
}