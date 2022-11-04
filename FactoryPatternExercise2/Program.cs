namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? You have 3 choices: List, SQL, or Mongo");
            string dbtype = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(dbtype);

            List<Product> products = data.LoadData();
            data.SaveData();

            Console.WriteLine();
            Console.WriteLine("Here are your products");

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}, Product Price: {product.Price, 0:c}");
            }
        }
    }
}
