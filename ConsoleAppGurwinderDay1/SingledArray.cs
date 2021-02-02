//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class SingledArray
//    {
//        static void Main()
//        {
//            // Array is second data storage technique in c# after variable
//            // variable can store only one value at a time and array can store 
//            //multiple of same type.. Array Rule 
//            //Declaration of single dimension array
//            //datattype[] arrayname=new datatype[size];
//            //int[] a = new int[5];
//            //int i;
//            //for (i = 0; i < 5; i++)
//            //{
//            //    Console.WriteLine("Enter element");
//            //    a[i] = Convert.ToInt32(Console.ReadLine());
//            //}
//            //Console.WriteLine(" A Array Elements:");
//            //for (i = 0; i < 5; i++)
//            //{
//            //    Console.WriteLine(a[i]);
//            //}
            
//            int[] b = {1,4,63,6,67,47,27,74,33,373,22};// initialization
//            Console.WriteLine(" B Array Elements:");
//            for (int i = 0; i < b.Length; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//            int[] c = new int[] { 4, 4, 3, 32, 3, 3, 3, 3, 4, 4, 2, 5, 6, 7, 3, 6, 6 };
//            Console.WriteLine(" C Array Elements:");
//            foreach (var x in c)
//            {
//                Console.WriteLine(x);
//            }
//            //var cslice = c[..^6];
//            int[] cslice =c[..^6];
//            Console.WriteLine("C Slice elements");
//            foreach(var x in cslice)
//            {
//                Console.WriteLine(x);
//            }
//            // Enter 10 elements in array print in reverese order
//            // Enter 10 elements in array print biggest element
//            // array size 10 - Sort elements of array in ascending order  
//            // sum of array elements
//        }
//    }
//}



///*
// * 
// var array = new int[] { 1, 2, 3, 4, 5 };
//            var a1 =array[1..^3] ;//array[new Range(1,3)]; 
//            foreach(var i in a1)
//            {
//                Console.WriteLine(i);
//            }
//            var array = new int[] { 1, 2, 3, 4, 5 };
//            var slice1 = array[1..^3];    // array[new Range(1, new Index(3, fromEnd: true))]
//            var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
//            var slice3 = array[2..];      // array[Range.StartAt(2)]
//            var slice4 = array[..];       // array[Range.All]
//            foreach(var i in slice3)
//            {
//                Console.WriteLine(i);
//            }
 
 
 
// */
