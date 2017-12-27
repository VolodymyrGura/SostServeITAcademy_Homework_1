// <copyright file="Homework_1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using SostServeITAcademy_Homework_1.Models;

namespace SostServeITAcademy_Homework_1
{
    public class Homework_1
    {
        private static IValidatable _validator;

        public static void Main()
        {
            _validator = new ConsoleInputValidator();

            // Task B
            var sideLength = _validator.GetIntegerInput("Input square side length: ", 0, int.MaxValue);
            var square = new Square(sideLength);
            Console.WriteLine(square.ToString());

            // Task C
            var name = _validator.GetStringInput("What is your name?");
            var age = _validator.GetIntegerInput("How old are you?", 0, int.MaxValue);
            var person = new Person(name, age);
            Console.WriteLine(person.ToString());

            // Task D
            var radius = _validator.GetDoubleInput("Input radius: ", 0, double.MaxValue);
            var circle = new Circle(radius);
            var sphere = new Sphere(radius);
            Console.WriteLine($"Area= {circle.Area} Volume= {sphere.Volume} ");

            Console.ReadKey();
        }
    }
}
