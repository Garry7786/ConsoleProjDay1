//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    // function overriding
//    public abstract class MyShape // we can not create an object
//    {
//        public /*virtual*/ abstract void GetArea(); // virtual allow a function to override 
//        //{
//        //    Console.WriteLine("Area of Myshape");
//        //}
//    }
//    public interface IShape
//    {
//        void GetArea();// must overideable
//    }
//    public class Rect :/*MyShape*/IShape
//    {
//        public void GetArea()
//        {
//            Console.WriteLine("Area of Rect");
//        }
//    }
//    public class Circle:IShape
//    {
//        public /*override*/ void GetArea()
//        {
//            Console.WriteLine("Area of Circle");
//        }
//    }
//    class MyShapeProgram
//    {
//        static void Main()
//        {
//            Circle circle = new Circle();
//            circle.GetArea();
//            Rect rect = new Rect();
//            rect.GetArea();

//            IShape shape; // it is a reference of shape class . as per oop rule ref of base class can store the derive class object or we can say can point
//            // and can access those members which are inherit from base to derive
//            shape = circle;
//            shape.GetArea();

//            shape = rect;
//            shape.GetArea();

//            int n1 = 5, n2 = 10, total;
//            total = n1 + n2;
//            string result = string.Format("Sum of {0} and {1} is {2}", n1, n2, total);
//            Console.WriteLine(result);
//            Console.WriteLine($"The sum of {n1} and {n2} is {total}");





//        }
//    }
//}
