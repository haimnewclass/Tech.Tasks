using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class Food
    {
        public int Regular(int itemPrice)
        {
            float total = itemPrice * 1.18f;
            return (int)total;
        }
        public int Free(int itemPrice)
        {
            return itemPrice;
        }

        public int Partial(int itemPrice)
        {
            float total = itemPrice * 1.01f;
            return (int)total;
        }

        public void Run()
        {
            Item i = new Item();
            Console.WriteLine(i.CalculatePrice(1223423, Free));
            Console.WriteLine(i.CalculatePrice(1223423, Partial));
            Console.WriteLine(i.CalculatePrice(1223423, Regular));
        }
    }
}
