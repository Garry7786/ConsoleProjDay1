//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    public delegate void MyDelegate(string param); // declaration
//    public delegate int TwoIntDelegate(int param1, int param2);

//    class DelegateDemo
//    {
//        static void Main()
//        {
//            MyDelegate del = new MyDelegate(Hello);
//            del("Hello Weorld! Welcome in MyDelegate");
//            MyDelegate del1 = new MyDelegate(MyMessage);
//            del1("My Delegate 1");

//            TwoIntDelegate big = new TwoIntDelegate(Big);
//            var result=big(44, 22);
//            Console.WriteLine($"Biggest is {result}");
//            TwoIntDelegate sum = new TwoIntDelegate(Sum);
//            var result1= sum(44, 22);
//            Console.WriteLine($"Sum is {result1}");
//        }
//        static void Hello(string msg)
//        {
//            Console.WriteLine(msg);
//        }
//        static void MyMessage(string str)
//        {
//            Console.WriteLine($"Your message is {str}");
//        }
//        static int Sum(int n1,int n2)
//        {
//            return n1 + n2;
//        }
//        static int Big(int n1,int n2)
//        {
//            return n1 > n2 ? n1 : n2;
//        }
//    }
//}
