using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace web_form02
{

    public partial class Linq : System.Web.UI.Page
    {
        protected void Page_Load_Back1(object sender, EventArgs e){
            List<Girl> girlArr = Girl.GetGirlList();
            var girlNameArr = from girl in girlArr
                              where girl.Price > 11
                              select girl.Name;
            foreach(var name in girlNameArr){
                id_label.Text += String.Format("{0}<br/>", name);
            }
        }


        protected void Page_Load_Back2(object sender, EventArgs e)
        {
            IEnumerable<Girl> girlArr = Girl.GetGirlList();
            IEnumerable<GirlAnime> girlAnimeArr = GirlAnime.GetGirlAnimeList();

            var tmpGirlArr = from 
                                girl in girlArr 
                             join  
                                girlAnime in girlAnimeArr
                             on 
                                girl.ID equals girlAnime.GirlID
                              where girl.Price > 11
                                    select new {
                resultGirlName = girl.Name, 
                resultAnime = girlAnime.AnimeName
            };

            foreach (var resultStr in tmpGirlArr)
            {
                id_label.Text += String.Format("{0}<br/>", resultStr);
            }
        }


        protected void Page_Load_Back3(object sender, EventArgs e)
        {
            IEnumerable<Girl> girlArr = Girl.GetGirlList();
            IEnumerable<GirlAnime> girlAnimeArr = GirlAnime.GetGirlAnimeList();

            var tmpGirlArr = from
                                girl in girlArr
                             join
                                girlAnime in girlAnimeArr
                             on
                                girl.ID equals girlAnime.GirlID
                             where girl.Price > 11 && girlAnime.Episode > 13
                             select new
                             {
                                 resultGirlName = girl.Name,
                                 resultAnime = girlAnime.AnimeName,
                                 resultAnimeEpisode = girlAnime.Episode,
                                
                             };

            foreach (var resultStr in tmpGirlArr)
            {
                id_label.Text += String.Format("{0}<br/>", resultStr);
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Girl> girlArr = Girl.GetGirlList();
            IEnumerable<GirlAnime> girlAnimeArr = GirlAnime.GetGirlAnimeList();

            var tmpGirlArr = from
                                girl in girlArr
                             join
                                girlAnime in girlAnimeArr
                             on
                                girl.ID equals girlAnime.GirlID
                             where girl.Price > 10 && girlAnime.Episode > 0
                             orderby girl.Price ascending
                             let age = (girl.Price - (decimal)0.1)
                             select new
                             {
                                 resultGirlName = girl.Name,
                                 resultGirlAge = age + "岁",
                                 resultAnime = girlAnime.AnimeName,
                                 resultAnimeEpisode = girlAnime.Episode + "集",

                             };

            foreach (var resultStr in tmpGirlArr)
            {
                id_label.Text += String.Format("{0}<br/>", resultStr);
            }
        }


    }
}
