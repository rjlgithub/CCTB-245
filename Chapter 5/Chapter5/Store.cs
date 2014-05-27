using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Store
    {
        #region Properties and Fields
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Store(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public Product GetProduct(int Id)
        {
            //find product in database and return
            Product product = new Product(1, "Visual Studio");
            return product;
        }
        #endregion
    }
}
