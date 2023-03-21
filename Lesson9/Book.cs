using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Genre genre { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public Cover cover { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
    }
    


    }

