using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Movie
    {
            public string category;
            public string title;
            public Movie(string t, string cat)
            {
                category = cat;
                title = t;
            }
            public string getCat()
            {
                return category;
            }
        public string getTitle()
        {
            return title;
        }
        }
    }

