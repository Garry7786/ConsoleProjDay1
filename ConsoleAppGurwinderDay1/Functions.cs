using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    class Functions
    {
        static void Main() // calling function
        {
            // function always provide service
            // Function - Block of code under name
            // Agreement - Just call me and use me
            // With this agreement function also said if i expect something from your side then
            // you should fullfill my expectation 
            //argument or parameter - data which we pass to function 
            // Inbuilt or User Defined
            /*
             Does Not accept and Does Not Return 
             
             */
            msg(); // 
            sum(22,55);
            int f = fact(5);
            Console.WriteLine($"Fact is {f}");
            double r = 5, a;

            a = pi() * r * r;
            Console.WriteLine($"Area of circle is {a}");

            // Call By Value
            int x = 2;
            Console.WriteLine($"Before call cbv x={x}");
            cbv(x); // x actual argument
            Console.WriteLine($"After call cbv x={x}");
           
            // call by reference
           
            Console.WriteLine($"Before call cbr x={x}");
            cbr(ref x); // x actual argument
            Console.WriteLine($"After call cbr  x={x}");

            // call by out
            Console.WriteLine($"Before call cbo x={x}");
            cbo(out x); // x actual argument
            Console.WriteLine($"After call cbo  x={x}");

        }

        static void cbv(int x) // x formal argument 
        {
            x = 7; // if any change in formal argument it does not affect actual argument
        }

        static void cbr(ref int y) // swaping of 2 nos
        {
            Console.WriteLine($"y={y}");

            y = 7;  // if any change in formal argument it affects actual argument
        }
        static void cbo(out int y)
        {
            //Console.WriteLine($"y={y}");
            y = 70;
        }// result  - marks of 5 subjects by value accept and return total out and percentage out  and division out 
        static void msg() //called function
        {
            // does not accept or does not return
            Console.WriteLine("Hello User");
        }
        static void sum(int n1,int n2)
        {
            // sum function does not return and  accept 2 integer
            // void - function does not return
            int r;
            r = n1 + n2;
            Console.WriteLine($"Total={r}");


        }
        static int fact(int x)// return int and accept int 
        {
            int i, f = 1;
            for (i = 1; i <= x; i++)
                f = f * i;
            
            return f;

        }
        static double pi()
        {
            return 3.14;

        }
    }
}
