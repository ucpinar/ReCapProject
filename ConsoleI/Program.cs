﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
