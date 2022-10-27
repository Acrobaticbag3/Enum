using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Csharp_Interfaces {
    public class Triangle {
        //Variables list
        private int width;
        private int height;
        private string spacing = "==================";
        
        public Triangle() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() {
            InputData();
            int circumference = width * 2 + height * 2;
            Console.WriteLine(value: "the circumference of this triangle is: " + circumference);
            Console.WriteLine(value: spacing);
        }
        public void Area() {
            InputData();
            int area = width * height / 2;
            Console.WriteLine(value: "The area of this triangle is: " + area);
            Console.WriteLine(value: spacing);
        }
        private void InputData() {
            Console.WriteLine(value: spacing);
            Console.Write(value: "Input width: ");
            width = int.Parse(s: Console.ReadLine());

            Console.Write(value: "Input height: ");
            height = int.Parse(s: Console.ReadLine());
            Console.WriteLine(value: spacing);
        }
    }
}