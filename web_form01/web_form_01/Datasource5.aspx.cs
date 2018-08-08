using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_form_01
{
	public partial class Datasource5 : System.Web.UI.Page
	{
		protected IList createAnimeList()
		{
			ArrayList animeArr = new ArrayList();
			Anime anime;
			anime = new Anime("未闻花名", "面码");
			animeArr.Add(anime);

			anime = new Anime("这个杀手不太冷", "Mathilda");
			animeArr.Add(anime);

			anime = new Anime("龙与虎", "逢坂大河");
			animeArr.Add(anime);
			
			return animeArr;
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			IList animeList = createAnimeList();
			if (!this.IsPostBack)
			{
				this.id_listBox.DataSource = animeList;
				this.id_listBox.DataTextField = "AnimeName";
				this.id_listBox.DataValueField = "GirlName";

				this.id_dropDown.DataSource = animeList;
				this.id_dropDown.DataTextField = "AnimeName";
				this.id_dropDown.DataValueField = "GirlName";
				
				this.id_radioBtn.DataSource = animeList;
				this.id_radioBtn.DataTextField = "AnimeName";
				this.id_radioBtn.DataValueField = "GirlName";
				
				this.id_checkBox.DataSource = animeList;
				this.id_checkBox.DataTextField = "AnimeName";
				this.id_checkBox.DataValueField = "GirlName";

				// important
				this.DataBind();
			}
		}

		protected void id_listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.id_label_1_listBox.Text = this.id_listBox.SelectedValue;
		}

		protected void id_dropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.id_label_2_dropDown.Text = this.id_dropDown.SelectedValue;
		}

		protected void id_radioBtn_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.id_label_3_radioBtn.Text = this.id_radioBtn.SelectedValue;
		}

		protected void id_checkBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.id_label_4_checkBox.Text = this.id_checkBox.SelectedValue;
		}
	}
}