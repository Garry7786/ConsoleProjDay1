//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class Biggest
//    {
//        // Decision Control Instructions
//        //As we know program is a solution of problem and a problem can not
//        //solved without decision
//        /*
//         if(condition)
//        {
//        ............
//        }
//        else  -- optional
//        {
//        ......
//        }
//         */
//        static void Main()
//        {
//            float mrp, dis=0, net=0;
//            Console.WriteLine("Enter mrp of book");
//            mrp = Convert.ToSingle(Console.ReadLine());
//            if(mrp>=500)
//            {
//                dis = mrp * 10 / 100;
//            }
//            else
//            {
//                dis = mrp * 5 / 100;
//            }
//            net = mrp - dis;
//            Console.WriteLine($" MRP={mrp}\n Discount={dis}\n Net Price={net}");
//            Console.ReadKey();
//        }
//    }
//}
