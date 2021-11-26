using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDiary.Classes
{
    public class Link
    {
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _definition;
        public string Definition
        {
            get { return _definition; }
            set { _definition = value; }
        }

        public static int CompareByDefinition(Link a, Link b)
        {
            return string.Compare(b.Definition, a.Definition);
        }
    }
}