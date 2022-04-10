using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class Item
    {
        public delegate int CalcTask(int itemPrice);


        public int CalculatePrice(int itemPrice, CalcTask func)
        {
            int ret = 0;

            ret = func(itemPrice * 2);

            return ret;
        }
    }
}
