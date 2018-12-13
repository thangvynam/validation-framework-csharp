using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationFramework.Attributes
{
    class DemoAttribute : System.Attribute
    {
        private string author;

        public string Url { get; set; }

        public DemoAttribute(string author)
        {
            this.author = author;
        }

        public override string ToString()

        {

            return String.Format("Author: {0}\nLocation: {1}", author, Url);

        }
    }
}
