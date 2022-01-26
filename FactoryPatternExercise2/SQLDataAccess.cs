using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database.");
            return new List<Product>()
            {
                new Product(){Name = "Whatever2", Price = 20 }
            };
        }
    

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database.");
        }
    }
}
