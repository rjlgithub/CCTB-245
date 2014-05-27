using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Product
    {
        //Auto-implemented properties (data)
        public int Id { get; set; }        //int default 0
        public string Name { get; set; }   //string default null

        //Contructors (define the different 'ways' to make my objects)
        //Paramterless constructor
        public Product()
        {
            //empty body - let the properties' values be their defaults
            //default for int is 0
            //default for string is null
        }

        //Greedy contructor
        public Product(int id, string name)
        {
            //simply store the information into my properties/fields
            Id = id;
            Name = name;
        }

        //Virtual Method - use 'virtual' when you intend subclasses to 'override' the behaviour
        public virtual void Purchase()
        {
            //Temp - just ouput to console
            Console.WriteLine("Product Purchase {0}", Name);
        }

    }

}
