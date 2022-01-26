using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database Would you like to use : List, SQL, or Mongo");
            string userDataBase = Console.ReadLine();
            IDataAccess database = DataAccessFactory.GetDataAccessType(userDataBase);
            database.LoadData();
            database.SaveData();
        }
    }
}
