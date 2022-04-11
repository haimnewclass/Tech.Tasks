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
            SystemData sd = new SystemData();
            sd.Run();

            TaskSample ts = new TaskSample();
            ts.RunLong();
            int number = int.Parse(Console.ReadLine());
            WriteStart ws = new WriteStart();
            ws.linesNumer = number ;
        
            ws.writeToFileAsTask(@"C:\Users\ASI\source\repos\Tech.Tasks\Tech.Tasks\Output\number.txt");


            MyPaint myPaint = new MyPaint();
            //myPaint.Run();            

            Food f = new Food();
            //f.Run();

          
            ts.myAction1();
            ts.myAction2();




            ts.Run();
            Console.ReadLine();
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
