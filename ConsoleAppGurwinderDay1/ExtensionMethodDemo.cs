using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppGurwinderDay1
{
    class ExtensionMethodDemo
    {
        static void Main()
        {
            int x = 0;
            int y=-2;
            // absoulte 
            // IsPostive 
            if(x.IsPositive())
            {
                Console.WriteLine("X is +ve");
            }
            Console.WriteLine($"Y={y.ABS()}");

            List<User> users = new List<User>() 
            {
             new User(){FirstName="abc", LastName="xyz", UserName="temp", Password="123"},
             new User(){FirstName="rai", LastName="singh", UserName="rai", Password="rai@12"},
             new User(){FirstName="urvi", LastName="verma", UserName="samar", Password="singh"}
            };

            var user = users.Where(x => x.UserName == "temp" && x.Password == "123").FirstOrDefault().GetUserWithoutPassword();
            
            //user.Password = null;
            Console.WriteLine($"User Detail : {user.FirstName} {user.LastName}, UserName {user.UserName}, Password {user.Password}");


            var userswithoutpassword = users.GetUsersWithoutPassword();
            foreach(var user1 in userswithoutpassword)
            {
                Console.WriteLine($"User Detail : {user1.FirstName} {user1.LastName}, UserName {user1.UserName}, Password {user1.Password}");

            }
            // Dept Table DNo , DName, Loc

            // Employee , EmpNo, EName, Job, Hiredate, Employee Manager, int MgrId,  Salary, Comm, Dept Department, int Dno
            
            // select all employee of department id  10
            // select all employee who get sal >=5000
            // 10 years eperience
            // select emp who is work under empno no 101
            // department wise total salary
            // get employee of highest
            // list employee sal + comm = totalsal
            // 
            // 

        }
    }
}
