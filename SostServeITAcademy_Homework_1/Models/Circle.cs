using System;

namespace SostServeITAcademy_Homework_1.Models
{
    public class Circle
    {
        protected double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative", nameof(value));
                }

                _radius = value;
            }
        }

        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}
