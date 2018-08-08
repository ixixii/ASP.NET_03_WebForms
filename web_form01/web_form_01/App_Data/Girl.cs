using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_form_01
{
	public class Girl
	{
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public Girl() { }
		public DataSet getGirls() {
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable("girl");
			dataTable.Columns.Add("id", typeof(System.Int32));
			dataTable.Columns.Add("name", typeof(System.String));
			dataTable.Columns.Add("age", typeof(System.Int32));
			dataTable.Rows.Add(new object[] { 5, "Eva", 16 });
			dataTable.Rows.Add(new object[] { 6, "Hana", 17 });
			dataSet.Tables.Add(dataTable);
			return dataSet;
		}
	}
}