//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class Compare<T,T1>
//    {
//        public T Param1 { get; set; }
//        public T Param2 { get; set; }
//        public T1 Param3 { get; set; }
//        public bool IsEqual(Compare<T,T1> obj)
//        {
//            return this.Param1.Equals(obj.Param1) && this.Param2.Equals(obj.Param2);

//        }
//    }

//    class genericClassDemo
//    {
//        static void Main()
//        {
            

//            Compare<int,string> c1 = new Compare<int,string>() { Param1 = 44, Param2 = 44, Param3="Hello"};
//            Compare<int,string> c2 = new Compare<int,string>() { Param1 = 442, Param2 = 44, Param3 ="User" };

            
//            //Compare<string> c3 = new Compare<string>() {Param1="SIRCL", Param2="TECH" };

//            if (c1.IsEqual(c2))
//            {
//                Console.WriteLine("Object equal");
//            }
//            else
//            {
//                Console.WriteLine("Object Not equal");
//            }

//        }

//    }
//}
