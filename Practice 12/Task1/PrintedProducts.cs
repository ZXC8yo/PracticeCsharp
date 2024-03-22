using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class PrintedProducts
    {
        protected string name;


        public PrintedProducts(string name)
        {
            this.name = name;
        }

        public string Name
        { 
            get { return name; } 
            set { name = value; }
        }    
    }
}
