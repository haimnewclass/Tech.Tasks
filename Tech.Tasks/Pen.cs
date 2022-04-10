using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class Pen
    {
        public enum Food {Banana, Apple, Bread, Chocolad};

        public delegate string DrawCrown();
        public string Draw(string str, DrawCrown func)
        {
            return str + "*"+func()+"*" + str;
        }

    }
}
