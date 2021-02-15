//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class Compare<T>
//    {
//        public T Param1 { get; set; }
//        public T Param2 { get; set; }
//        public bool IsEqual(Compare<T> obj)
//        {
//            return this.Param1.Equals(obj.Param1) && this.Param2.Equals(obj.Param2);

//        }
//    }

//    class genericClassDemo
//    {
//        static void Main()
//        {

//            Compare<int> c1 = new Compare<int>() { Param1 = 44, Param2 = 44 };
//            Compare<int> c2 = new Compare<int>() { Param1 = 442, Param2 = 44 };
            
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
