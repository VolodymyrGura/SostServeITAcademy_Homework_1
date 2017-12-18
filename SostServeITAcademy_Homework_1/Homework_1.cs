// <copyright file="Homework_1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System;

namespace SoftServeITAcademy_Homework_1
    {
       public class Homework_1
        {
            public static void Main(string[] args)
            {
                // Task B
                int a = Convert.ToInt32(Console.ReadLine());
                int area = a * a;
                int perimert = a + a + a + a;
                Console.WriteLine("Area= {0} Perimetr= {1} ", area, perimert);

                // Task C
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("How old are you, {0}?", name);
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name {0} Age {1} ", name, age);

                // Task D
                double r = Convert.ToDouble(Console.ReadLine());
                double area_circle = Math.PI * Math.Pow(r, 2);
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                Console.WriteLine("Area= {0} Volume= {1} ", area_circle, volume);

                Console.ReadKey();
            }
        }
    }
