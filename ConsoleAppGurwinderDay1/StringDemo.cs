using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    class StringDemo
    {
        static void Main()
        {
            string name = "SIRCL";
            Console.WriteLine("Enter Your name");
            name=Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            
            Console.WriteLine($"Length of String {name.Length}");
            string company = " SIRCL TECH Is";
            
            
            if (company.Trim() == "SIRCL")
                Console.WriteLine($"Welcome to {company}");
            string data = "C,C++,VB,Oracle,Java";
            
            string[] courses = data.Split(',');
            foreach (string course in courses)
                Console.WriteLine(course);

            if (data.Contains("VB"))
                Console.WriteLine("VB contain in data");
            else
                Console.WriteLine("VB Not COntain in data");

            int pos = company.IndexOf("R");
            Console.WriteLine($"R contain at {pos} position in {company}");
            string firstname = company.Trim().Substring(0, 5);
            string lastname = company.Substring(6);// SIRCL TECH
            Console.WriteLine($"{firstname.ToLower()} {lastname.ToLower()}");
            string amount = "584";
            Console.WriteLine($"{amount.PadLeft(6,'*').PadRight(9,'*')}");

            Console.WriteLine($"Reverse order of {company} ");
            for(int i=0;i<company.Length; i++)
            {
                int index = company.Length - (i + 1); 
                Console.Write(company.Substring(index,1));
            }
        }
    }
}
