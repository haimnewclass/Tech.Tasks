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
        public async void Run()
        {
            var s = await CreatePrintLongTask2();
            s = await CreatePrintLongTask2();
            //  Task.Run(myAction1);
            // Task.Run(myAction2);
        }

        public async void RunLong()
        {
           await CreatePrintLongTask();

           Console.WriteLine("After Start CreatePrintLongTask");
        }

        public Task<string> CreatePrintLongTask()
        {
            Task<string> ret = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000);
                }
                return "123";
            }
           
            );

            return ret;
        }


        public async Task<string> CreatePrintLongTask2()
        {
            Task<string> ret = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000);

                }
                return "123";
            }

            );
            await Task.Delay(1000);

            return "123";
        }

        public Task CreatePrintLongTask1()
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
