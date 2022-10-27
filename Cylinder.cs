using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Cylinder {
        //Variables list
        private int height; 
        private int radius;
        private string spacing = "==================";

        public Cylinder() { // A default constructor 
            
        }

        // === === Calculations === === \\
        public void Circumference() { 
            InputData();
            double circumference = 3.14 * radius * 2;
            Console.WriteLine(value: "the circumference of this cylinder is: " + circumference);
            Console.WriteLine(value: spacing);
        }
        public void Area() { 
            InputData();
            double area = 2 * 3.14 * radius * height + 2 * 3.14 * radius * radius;
            Console.WriteLine(value: "the area of this cylinder is: " + area);
            Console.WriteLine(value: spacing);
        }
        private void InputData() {
            Console.WriteLine(value: spacing);
            Console.Write(value: "Input height: ");
            height = int.Parse(s: Console.ReadLine());

            Console.Write(value: "Input radius: ");
            radius = int.Parse(s: Console.ReadLine());
            Console.WriteLine(value: spacing);
        }
    }
}