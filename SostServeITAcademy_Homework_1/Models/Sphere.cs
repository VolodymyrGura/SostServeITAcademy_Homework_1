using System;

namespace SostServeITAcademy_Homework_1.Models
{
    public class Sphere : Circle
    {
        public Sphere(double radius)
            : base(radius) { }

        public double Volume => 4d / 3d * Math.PI * Math.Pow(_radius, 3);
    }
}
