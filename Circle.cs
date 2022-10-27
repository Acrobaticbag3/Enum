using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Circle {
        // variables list
        private int radius;
        private string spacing = "==================";

        public Circle() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() { 
            InputData();
            double circumference = 2 * radius * 3.14;
            Console.WriteLine(value: "the circumference of this circle is: " + circumference);
            Console.WriteLine(value: spacing);
        }
        public void Area() { 
            InputData();
            double area = 3.14 * radius * radius;
            Console.WriteLine(value: "the Area of this circle is: " + area);
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