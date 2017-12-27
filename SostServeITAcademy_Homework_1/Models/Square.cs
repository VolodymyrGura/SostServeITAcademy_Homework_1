using System;

namespace SostServeITAcademy_Homework_1.Models
{
    public class Square
    {
        private int _sideLength;

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public int SideLength
        {
            get => _sideLength;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side length cannot be negative", nameof(value));
                }

                _sideLength = value;
            }
        }

        public int Area => (int)Math.Pow(_sideLength, 2);

        public int Perimeter => 4 * _sideLength;

        public override string ToString()
        {
            return $"Area = {Area} \nPerimeter = {Perimeter} ";
        }
    }
}
