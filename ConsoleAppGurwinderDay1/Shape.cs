//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    // polymorphism - more than one form 
//    // Function Overloading or Constructor Overloading or Operator Overloading
//    // Function Overiding 
//    public class Shape
//    {
//        public void Area(int side)
//        {
//            Console.WriteLine($"Area of Square {side * side}");
//        }
//        public void Area(int l, int b)
//        {
//            Console.WriteLine($"Area of rect {l*b}");
//        }
//        public void Area(double r)
//        {
//            Console.WriteLine($"Area of Circle {3.14*r*r}");
//        }
//    }
//    class ShapProgram
//    {
//        static void Main()
//        {
//            Shape shape = new Shape();
//            shape.Area(3, 2); // static  data binding - connection of a function call with its body
//            shape.Area(3);
//            shape.Area(4.32);

//        }
//    }
//}
