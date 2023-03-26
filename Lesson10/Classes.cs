using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson10
{
    public class Classes
    {
        private string Name { get; set; }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

     public Classes(string name)
        {
            Name = name;
        }

        public static void AddClass(List<Classes> classes, string name)
        {
            classes.Add(new Classes(name));
        }
    }
}
