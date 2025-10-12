using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    /// <summary>
    /// This class initializes the properties id Name and Price
    /// </summary>
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// Initialzes a new instamce for the product class
        /// </summary>
        /// <param name="id">The unique identifier for the products</param> 
        /// <param name="name">The name of the products</param>
        /// <param name="price">The cost of the products</param>
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
    }
}
