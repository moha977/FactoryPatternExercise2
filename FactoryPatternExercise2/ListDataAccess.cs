﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "whatever", Price = 10},

        };
        
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from list database.");
          return Products;
        }

        public void SaveData()  
        {
            Console.WriteLine("I am saving data to a list database.");
        }
    }
}
