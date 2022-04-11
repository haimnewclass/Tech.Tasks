using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    public class SystemData
    {

        public void Run()
        {
            Car car1 = new Car() { name = "Volvo" };
            Car car2 = new Car() { name = "Subaro" };

            car1.PrintCarDetails();
            IPerson d = car1;
            d.SetName("Mazda");            
            car1.GetName();

            d.GetName();

            MyInterfaces p1 = new MyInterfaces() { name = "Avi" };
            MyInterfaces p2 = new MyInterfaces() { name = "Shalom" };

            PrintLabels(car1);
            PrintLabels(car2);
            PrintLabels(p1);
            PrintLabels(p2);

            IPerson ip1 = new Car() {name="Tesla",number=123123 };
            IPerson ip2 = new MyInterfaces() {name="Shlomo" };
            IPerson ip3;
            

            ip1.GetName();
            ip2.GetName();

            ip3 = ip1;
            ip3.GetName();
            ip1 = ip2;
            ip2.GetName();
            ip1.GetName();

            ip2 = ip3;
            ip2.GetName();

            MyWorker mw = new MyWorker() { id = 111, name = "Ämram" };
            UsePrinter(mw);
        }

        public void PrintLabels(IPerson person )
        {         
            Console.WriteLine(person.GetName());
        }

        public void UsePrinter(IPrinter printer)
        {
            ////////////////////
            printer.GetSizeOfCard();
            printer.GetLabel();
        }

    }

    public class MyWorker : IPrinter
    {
        public int id { get; set; }
        public string name { get; set; }

        public void checkin()
        {

        }

        public string GetLabel()
        {
            return "Work in Cocacola";
        }

        public Point GetSizeOfCard()
        {
            return new Point { X = 10, Y = 5 };
        }

        public int GetWorkerId()
        {
            return id;
        }
    }


    public interface IPrinter
    {
        Point GetSizeOfCard();
        string GetLabel();

        int GetWorkerId();
    }


    public interface IPerson
    {
        void SetName(string name);
        string GetName();
    }

    public class Car:IPerson
    {
        public string name { get; set; }
        public int number { get; set; }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string PrintCarDetails()
        {
            return name +" "+ number;
        }
    }


    public class MyInterfaces: IPerson
    {
        public string name { get; set; }

        public string GetName()
        {
            return name;
        }

        public string PrintPersonDetails()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
