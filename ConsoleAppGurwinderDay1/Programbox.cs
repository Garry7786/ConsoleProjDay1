using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    class Programbox
    {
        static void Main()
        {
            Box b1 = new Box(); // default contrctor - constructor automatically called during an object creation 

            Console.WriteLine($"B1 dimension {b1.Length}x{b1.Breadth}x{b1.Height} and area is {b1.Area()} and Vol is {b1.Vol()}");


            Box b2 = new Box();
            
            b1.Length = 3; // set
            b1.Breadth = 4; // set
            b1.Height = 2; // set

            Console.WriteLine("Enter Length of Box2");
            b2.Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Box2");
            b2.Breadth = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter Height of Box2");
            b2.Height = Convert.ToInt32(Console.ReadLine()); ;


            Console.WriteLine($"B1 dimension {b1.Length}x{b1.Breadth}x{b1.Height} and area is {b1.Area()} and Vol is {b1.Vol()}");
            
            Console.WriteLine($"The Area of B2 is {b2.Area()} and Vol is {b2.Vol()}");

            Box b3 = new Box(b2);
            Console.WriteLine($"B3 dimension {b3.Length}x{b3.Breadth}x{b3.Height} and area is {b3.Area()} and Vol is {b3.Vol()}");
            
            /*
             1. Create BankAccount Class - Property - AccNo, AccHolder, AccBalance - Functions CreateAcc(), ShowAccInfo(), Deposit(), WithDrawl(), ShowBalance()
             2. Distance - Feet, Inch  Input and output 

             
             
             */
        }
    }
}
