using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231124.ORM
{
    internal class Book
    {
        public string Author { get; set; } = null;
        public string Title { get; set; } = null;
        public int Year { get; set; }

        public override string ToString() => $"'{Title}' by {Author} @{Year}";


    }
}
