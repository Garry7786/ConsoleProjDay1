//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class GenericsDemo
//    {
//        static void Main()
//        {
//            object obj;
//            obj = 10; // int => obj : boxing
//            int x;
//            x = Convert.ToInt32(obj); // unboxing
//            ArrayList al = new ArrayList();
           
//            al.Add(10);
//            al.Add("SIRCL");
//            al.Add(3.14);
            
//            object y = al[0];


//            List<string> courses = new List<string>() 
//            {
//                "Java",
//                "Oracle"
//            };
//            courses.Add("C");
//            courses.Add("C++");
//            foreach(var course in courses)
//            {
//                Console.WriteLine(course);
//            }

//            SortedList<string, int> mycourses = new SortedList<string, int>() 
//            { 
//                {"Oracle",4500},
//                {"Java",6500} 
//            };
            
//            mycourses.Add("C", 2000);
//            mycourses.Add("C++", 2500);
//            foreach (var course in mycourses)
//            {
//                Console.WriteLine($"{course.Key} fee is {course.Value} ");

//            }
//            Dictionary<int, string> emplist = new Dictionary<int, string>() { {1001,"Ram" } };
//            // 

//            Dictionary<Dictionary<int, int>, string> grades = new Dictionary<Dictionary<int, int>, string>()
//            {
//                { new Dictionary<int, int>() { { 1000, 5000 } },"C" }
//            };

//            grades.Add(new Dictionary<int, int>() { { 50001, 10000 } },"B");

           
//            Dictionary<int, int> newgrade = new Dictionary<int, int>();
//            newgrade.Add(10001, 15000);
            
            
//            grades.Add(newgrade, "A");

//            // CourseId , CourseName, CourseFee
//            Dictionary<int, Dictionary<string, int>> c = new Dictionary<int, Dictionary<string, int>>() {

//                { 1, new Dictionary<string, int>(){{ "C", 2000}}},
//                { 2, new Dictionary<string, int>(){{ "C++", 3000}}},
//                { 3, new Dictionary<string, int>(){{ "Java", 5000}}},
//                { 4, new Dictionary<string, int>(){{ "Oracle", 2000}}},


//            };

//            IEnumerable<string> countries; // Interface Ref
//            countries = new List<string>() {"India","Canada","US","UK"}; //  refer to list 
//            foreach(var country in countries)
//            {
//                Console.WriteLine(country);
//            }  


//        }
//    }
//}
