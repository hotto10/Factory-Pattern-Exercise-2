using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Keyboard", Price = 30.99m},
            new Product() { Name = "Mouse", Price = 20.99m },
            new Product() { Name = "MousePad", Price = 9.99m },
            new Product() { Name = "Monitor", Price = 299.99m },
            new Product() { Name = "Laptop", Price = 850.99m },
        };

        public List <Product> LoadData()
        {
            Console.WriteLine("Loading your SQL database...");
            
            return Products;

        }

        public void SaveData()
        {
            Console.WriteLine("I am reading from your SQL....");
        }

       
    }
}
