using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class Item
    {      
        public int CalculatePrice(int itemPrice, CalcTask callToTaxcalculation)
        {
            int ret = 0;

            ret = callToTaxcalculation(itemPrice);

            return ret;
        }

        public delegate int CalcTask(int itemPrice);

    }
}
