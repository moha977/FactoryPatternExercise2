using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database Would you like to use : List, SQL, or Mongo");
            string userDataBase = Console.ReadLine();
            IDataAccess database = DataAccessFactory.GetDataAccessType(userDataBase);

            List<Product> products = database.LoadData();
            Console.WriteLine();
            Console.WriteLine(); 
            
            database.SaveData();
            Console.WriteLine();

            Console.WriteLine("Here are your products");
            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }


        }
    }
}
