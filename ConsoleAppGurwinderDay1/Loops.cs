//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class Loops
//    {
//        // Loop is a technique to execute one or more than one instruction again and again
//        //Loop types - Known (for loop) and Unknown (while , do while)
//        // Known - Before start we know the its number of repetition 
//        //Unknown Loop- we do not know 
//        // for example - Ground - we need to run on ground then First Creteria is Lets runing 5  round 
//        // 2nd is Runing on ground until you tired - Unknown 
//        /*
//         * for(init loop counter;condition;incr|decr)
//         * {
//         *  .......
//         *  ...........
//         * }
//         * 
//         */
//        static void Main()
//        {
//            int i;
//            for (i = 1; i <= 5; ++i)
//            {
//                Console.WriteLine("Hello User");
//            }
//            /*
//             1. Hello User
//             2. Hello User
//             3. Hello User 
             
//            Q2.
//            Print 1 to 10
//            Q3. Print table of 2
//            Q4. Input a number and print its table 
//            eg. 
//            5
//            output
//            5x1=5
//            5x2=10
//            5x3=15
//            q5. input a number and print its factorial
//            eg 5
//            output 
//            5x4x3x2x1=120
//            Q6. 
//            input M and N print product of M , N times
//            eg. M=5 and N=3
//            output 
//            5x5x5=125
//            Q7. Print 
//            1
//            2
//            4
//            8
//            16
//            32
//            64
//            128
//            256
//            512

//             */
//            /*While Loop 
//             while(condition)
//              {
//                        .....
//               }
//             */
//            int num,x=0;
//            Console.WriteLine("Enter a number");
//            num = Convert.ToInt32(Console.ReadLine());
//            while(num>0)
//            {

//                x = x + 1;
//                num = num / 10;
//                Console.WriteLine($"after devide num is {num}");
//            }
//            Console.WriteLine($"Digits in number is {x}");
//            /*
//             Sum of Digits
//             1. Reverse of Digits
//             2. Input a number and print it in word
            
//            3. 3123
//               Three One Two Three Only
//            4. Check a number is armstrong or not
//            153

//            1x1x1+5x5x5+3x3x3=153 
//             */
//        }
//    }
//}
