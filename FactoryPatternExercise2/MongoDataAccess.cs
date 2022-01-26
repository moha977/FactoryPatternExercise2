using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from mongo database.");
            return new List<Product>();
            new Product() { Name = "Whatever3", Price = 30};
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data to a mongo database.");
        }

    }
    
}
