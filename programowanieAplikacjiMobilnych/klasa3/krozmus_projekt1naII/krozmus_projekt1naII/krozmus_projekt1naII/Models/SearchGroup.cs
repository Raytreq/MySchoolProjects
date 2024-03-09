using System;
using System.Collections.Generic;
using System.Text;


namespace krozmus_projekt1naII.Models
{
    public class SearchGroup : List<Search>
    {
        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public SearchGroup(string title, string shorttitle) 
        {
            Title = title;
            ShortTitle = shorttitle;
        }
    }

}
