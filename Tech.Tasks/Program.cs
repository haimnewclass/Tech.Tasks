using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    internal class Program
    {
        void func()
        {

        }
        static void Main(string[] args)
        {
            MyPaint myPaint = new MyPaint();
            myPaint.Run();            
        }

    }


    public class MyPaint
    {
        Pen.Food food;
        public string BritishCrown(int diamonds)
        {
            return "<**"+diamonds.ToString()+"*>";
        }
        public string AmericanCrown()
        {
            return "<$$$>";
        }
        public string EuropeanCrown()
        {
            return "<^^^>";
        }
        public string EmptyCrown()
        {
            return "<   >";
        }
        public void Run()
        {

            Pen.DrawCrown a;
            Pen.DrawCrown b;

            a = EuropeanCrown;

            Console.WriteLine(a());

            a = AmericanCrown;

            Console.WriteLine(a());

            Pen p = new Pen();
            Console.WriteLine(p.Draw("Aba", AmericanCrown));
            Console.WriteLine(p.Draw("Aba", EuropeanCrown));
        }
    }

}
