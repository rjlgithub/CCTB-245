using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class ListDemo
    {
        public void Run()
        {
            //this is an example of the List<T> class AND of 'generics'
            List<string> names;  //declare a strongly-typed list of strings
            //names is a list that can only contain string objects
            names = new List<string>();  // instantiate the list - create an empty list

            FillWithData(names);
            Display(names);
            
            //Remove a name from the list
            names.Remove("Dan");
            Console.WriteLine("Then name 'Dan' is removed from this list...");
            Display(names);

            names.Sort();
            Console.WriteLine("This is a sorted list...");
            Display(names);

        }

        //Private Methods
        private void FillWithData(List<string> theData)
        {
            theData.Add("Guido");
            theData.Add("Dan");
            theData.Add("Sally");
            for (int count = 0; count < 3; count++)
            {
                Console.Write("Enter a name: ");
                theData.Add(Console.ReadLine());
            }
        }

        private void Display(List<string> data)
        {
            //TODO: Code to show the number of elements in the list, and each value in the list
            Console.WriteLine();
            Console.WriteLine("The list has " + data.Count + " elements.");

            foreach (string item in data)  //forward-only for loop through all elements in collection
            {
                Console.WriteLine("\t" + item);
            }

            Console.WriteLine();

        }

    }
}
