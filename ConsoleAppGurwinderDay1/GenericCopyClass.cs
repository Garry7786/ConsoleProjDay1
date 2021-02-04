//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class GenericCopyClass
//    {
//        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
//        {
//            int actualCount = Math.Min(input.Count, maxElements);
//            List<T> ret = new List<T>(actualCount);
//            for (int i = 0; i < actualCount; i++)
//            {
//                ret.Add(input[i]);
//            }
//            return ret;
//        }
//        static void MyFun<T,T1>(T param,T1 param2)
//        {
//            Console.WriteLine($"{param} is {param2} year old");

//        }
        
//        static void Main()
//        {
//            Dictionary<string, int> courses = new Dictionary<string, int>
//            {
//                { "C", 2500 },
//                { "C#", 5500 },
//                { "C++", 3500 }
//            };
//            foreach (var course in courses)
//            {
//                Console.WriteLine($"Learn {course.Key} in INR{course.Value} Only.");
//            }

//            MyFun<string, int>("Ram", 23);
//            List<int> numbers = new List<int>();
//            numbers.Add(5);
//            numbers.Add(10);
//            numbers.Add(20);
//            List<int> firstTwo = CopyAtMost<int>(numbers, 2);
//            Console.WriteLine(firstTwo.Count);
//        }
//    }
//}
