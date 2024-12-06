using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParProg3_Henrik_Gytis
{
    internal class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Author { get; set; }
        public string About { get; set; }

        public Book(string title, string genre, string releaseDate, string author, string about)
        {
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
            Author = author;
            About = about;
        }
    }

}
