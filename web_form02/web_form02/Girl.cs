using System;
using System.Collections.Generic;

namespace web_form02
{
    public class Girl
    {
        public string ID {get; set;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Birthday { get; set; }

        public static List<Girl> GetGirlList(){
            List<Girl> girlArr = new List<Girl>();
            girlArr.Add(new Girl
            {
                ID = "1",
                Name = "Mathilda",
                Price = 12.1m,
                Birthday = Convert.ToDateTime("2006-06-07")
            });

            girlArr.Add(new Girl
            {
                ID = "2",
                Name = "面码",
                Price = 13.1m,
                Birthday = Convert.ToDateTime("2005-06-07")
            });

            girlArr.Add(new Girl
            {
                ID = "3",
                Name = "Saber",
                Price = 14.1m,
                Birthday = Convert.ToDateTime("2004-06-07")
            });

            girlArr.Add(new Girl
            {
                ID = "4",
                Name = "逢坂大河",
                Price = 15.1m,
                Birthday = Convert.ToDateTime("2003-06-07")
            });

            return girlArr;

        }
    }
}
