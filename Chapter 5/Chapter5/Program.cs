using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoInheritance();
            DemoPolymorphism();   //This is a 'Method Call' - It tells the method to run
        }

        //This is a 'Method Declaration' - It states what the instructions are
        static void DemoPolymorphism()
        {
            Store otherStore = new Store(2,"Future Buy");
            Product myProduct = otherStore.GetProduct(5);
            myProduct.Purchase(); //Call the method 

            LaptopComputer myMac = new LaptopComputer();
            myMac.Name = "Macbook Pro";
            myMac.Purchase();
        }


        static void DemoInheritance()
        {
            //Use store and look up a product
            Store store = new Store(1, "Best Store");
            Product product = store.GetProduct(1);

            //Output results to console
            Console.WriteLine("");
            Console.WriteLine("Store is {0}, Product is {1}", store.Name, product.Name);
            Console.WriteLine("");
            Console.WriteLine("");

            //Explore the Computer class
            //Create an object of data type Computer
            Computer oldMachine = new Computer();
            oldMachine.Id = 25;
            oldMachine.Name = "HP 1234-x";
            oldMachine.CPU = "x86";
            oldMachine.OperatingSystem = "Windows XP";

            //Create a LaptopComputer, with an Initializer list
            LaptopComputer laptopComputer = new LaptopComputer()
            {
                Id = 77,
                Name = "HP 532-Y",
                CPU = "Athalon Tiger",
                OperatingSystem = "Windows 10",
                MonitorSize = 27.5
            };
        }
    }
}
