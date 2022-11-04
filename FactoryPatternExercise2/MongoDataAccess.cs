using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
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


        public void SaveData()
        {
            Console.WriteLine("Loading your Mongo database");
        }

        public List <Product> LoadData()
        {
            Console.WriteLine("I am reading from you Mongo...");

            return Products;

        }
    }
}
