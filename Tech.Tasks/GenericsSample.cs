using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class GenericsSample
    {
        /*
        public void PrintAny(int obj)
        {
            Console.WriteLine("*** " + obj.ToString() + " ***");
        }
        public void PrintAny(float obj)
        {
            Console.WriteLine("*** " + obj.ToString() + " ***");
        }

        public void PrintAny(string obj)
        {
            Console.WriteLine("*** " + obj.ToString() + " ***");
        }

        public void PrintAny(bool obj)
        {
            Console.WriteLine("*** " + obj.ToString() + " ***");
        }
        */


        public void PrintAny<K>(K obj)
        {
            K b = obj;
                        
            Console.WriteLine("*** "+b.ToString()+" ***");
        }

        public void Run()
        {
            int a = 12;
            float b = 1.45f;
            bool c = false;
            Hashtable ht = new Hashtable();
            string d = "Hi";
            PrintAny<int>(a);
            PrintAny<float>(b);
            PrintAny<bool>(c);
            PrintAny<string>(d);
            PrintAny<IPerson>(new Car());
            PrintAny<Car>(new Car());

            System.Collections.Generic.Queue<IPerson> myQ = new Queue<IPerson>();
            myQ.Enqueue(new Car());

            Hashtable ht2 = new Hashtable();


            Car car1 = new Car() { name = "Volvo" };
            Car car2 = new Car() { name = "Subaro" };
            Car car3 = new Car() { name = "Mazda" };

            ht2.Add(6666, car1);

            ht2.Add(123, car1);
            ht2.Add(456, car2);
            ht2.Add(789, car3);

             object o = ht2[456];
            Car car4 = (Car) o;

            Dictionary<string, Car> ht6 = new Dictionary<string, Car>();
            Dictionary<string, GenericsSample> ht7 = new Dictionary<string, GenericsSample>();

            Dictionary<int,Car> ht5 = new Dictionary<int,Car>();
            ht5.Add(123, car1);
           
            car4 = ht5[456];


        }
    }
}
