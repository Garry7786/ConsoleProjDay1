using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    public class Rectangle
    {
        private int length;
        private int breadth;

        public Rectangle()
        {
            Console.WriteLine("Rect class constructor called");
            length = 1;
            breadth = 1;
        }
        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }
        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Area()
        {
            return length * breadth;
        }

    }
    public class MyBox:Rectangle
    {
        private int height;

        public MyBox():base(2,3)
        {
            Console.WriteLine("Box class constructor called");
            height = 1;
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Vol()
        {
            return Area() * height;
        }
    }
    class MyBoxProgram
    {
        static void Main()
        {
            MyBox box = new MyBox();// { Length=5, Breadth=4, Height=6};
            
            //box.Length = 3;
            //box.Breadth=2;
            //box.Height = 5;

            Console.WriteLine($"Area of Box {box.Area()} and Vol of Box {box.Vol()}");
        }
    }
}

/*
 
 Employee
  FirstName
  LastName
  Hiredate

 FullTimeEmp:Employee
  YearlySalary

 PartTimeEmp:Employee
  HoulryRate
 
 
 */