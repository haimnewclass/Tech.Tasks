using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class TaskSample
    {
        public void myAction1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Action1 "+i.ToString());
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void myAction2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Action2 " + i.ToString());
                System.Threading.Thread.Sleep(900);
            }
        }
        public void Run()
        {
            Task.Run(myAction1);
            Task.Run(myAction2);
        }

        public async void RunLong()
        {
           await CreatePrintLongTask();

           Console.WriteLine("After Start CreatePrintLongTask");
        }


        public Task CreatePrintLongTask()
        {           
            Task ret = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000);
                }
            });

            return ret;
        }


    }
}
