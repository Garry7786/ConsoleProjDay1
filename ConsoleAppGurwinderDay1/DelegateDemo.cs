using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    public delegate void MyDelegate(string param); // declaration
    public delegate int TwoIntDelegate(int param1, int param2);
    public delegate void x();
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class DelegateDemo
    {
        static void Main()
        {
            //MyDelegate del = new MyDelegate(Hello);
            //del("Hello World! Welcome in MyDelegate");


            MyDelegate msg = delegate (string val) { Console.WriteLine(val); };
            msg("Call of anoymous method");
            
            
            Student student = new Student() {Name="Ram",Age = 20 };
            Func<Student, bool> IsTeenAger = (s) => s.Age >= 12 && s.Age <= 20;
            if(IsTeenAger(student))
            {
                Console.WriteLine($"{student.Name} is Teenager");
            }
            else
            {
                Console.WriteLine($"{student.Name} is Not Teenager");
            }

            Func<int, int, int> Big = (n1, n2) => n1 > n2 ? n1 : n2 ;
            Console.WriteLine($" Biggest Number is {Big(10,20)}");

            Action<Student> display = s => Console.WriteLine($"Student Name {s.Name} and Age {s.Age}");
            display(student);

            Action<string> DisplayMsg = s => Console.WriteLine(s);
            DisplayMsg("Hello User ! Welcome in Action Delegate");

            Action action = () => Console.WriteLine("Message from action delegate that does not accept arguments");
            action();


            //PrintHelperMethod(delegate (string val) { Console.WriteLine(val); }, "Passing Delegate as Argument");

            //PrintHelperMethod(Hello, "Passing Delegate as Argument");
            //MyDelegate del1 = new MyDelegate(MyMessage);
            //del1("My Delegate 1");

            //TwoIntDelegate big = new TwoIntDelegate(Big);
            //var result = big(44, 22);
            //Console.WriteLine($"Biggest is {result}");
            //TwoIntDelegate sum = new TwoIntDelegate(Sum);
            //var result1 = sum(44, 22);
            //Console.WriteLine($"Sum is {result1}");

            //Nullable<int> i = null;
            //if (i.HasValue)
            //    Console.WriteLine($"I={i}");
            //else
            //    Console.WriteLine("I has null");

            //Nullable<int> j = null;
            //Console.WriteLine($"j={j.GetValueOrDefault()}");

            //int? k = 101;
            //int? y;

            //y = k ?? 0; //k.HasValue ? k: 0;
            //Console.WriteLine($"Y={y}");

        }
        static void PrintHelperMethod(MyDelegate mydel, string msg)
        {
            string newmsg = $"{msg} !  print from helper method";
            mydel(newmsg);

        }
        static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
        static void MyMessage(string str)
        {
            Console.WriteLine($"Your message is {str}");
        }
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Big(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
