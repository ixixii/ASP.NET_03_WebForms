using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace web_form02
{
    public class GirlAnime
    {

        public string GirlID { get; set; }
        public string AnimeName { get; set; }
        public int Episode { get; set; }
        public static IEnumerable<GirlAnime> GetGirlAnimeList()
        {
            GirlAnime[] girlAnimeArr = {
                new GirlAnime{
                                  GirlID = "1",
                                  AnimeName = "这个杀手不太冷",
                                  Episode = 1
                            },
                new GirlAnime{
                                  GirlID = "2",
                                  AnimeName = "未闻花名",
                                  Episode = 11
                             },
                new GirlAnime{
                                  GirlID = "3",
                                  AnimeName = "Fate",
                                  Episode = 36
                             },
                new GirlAnime{
                                  GirlID = "4",
                                  AnimeName = "龙与虎",
                                  Episode = 24
                             }
            };


            return girlAnimeArr.OfType<GirlAnime>();
        }

    }
}
