using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_form_01
{
	public class Anime
	{
		protected string animeName;
		protected string girlName;
		public Anime(string aName, string gName)
		{
			this.animeName = aName;
			this.girlName = gName;
		}
		public string AnimeName
		{
			get
			{
				return this.animeName;
			}
			set
			{
				this.animeName = value;
			}
		}

		public string GirlName
		{
			get
			{
				return this.girlName;
			}
			set
			{
				this.girlName = value;
			}
		}
	}
}