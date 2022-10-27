using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Sphere {
        //Variables list
        private int radius;
        private string spacing = "==================";

        public Sphere() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() {
            InputData();
            double circumference = radius * 3.14;
            Console.WriteLine(value: "the circumference of this sphere is: " + circumference);
            Console.WriteLine(value: spacing);
        }
        public void Area() {
            InputData();
            double area = 4 * 3.14 * radius * radius;
            Console.WriteLine(value: "the area of this sphere is: " + area);
            Console.WriteLine(value: spacing);
        }
        private void InputData() {
            Console.WriteLine(value: spacing);
            Console.Write(value: "Input radius: ");
            radius = int.Parse(s: Console.ReadLine());
            Console.WriteLine(value: spacing);
        }
    }
}