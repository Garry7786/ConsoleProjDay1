using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    public static class ExtensionMethods
    {
        public static bool IsPositive(this int val)
        {
            return val >= 0;
        }
        public static int ABS(this int val)
        {
            return val >= 0 ? val : -val;
            //return IsPositive(val) ? val : -val;

        }
        public static User GetUserWithoutPassword(this User user)
        {
            user.Password = null;
            return user;
        }
        public static List<User> GetUsersWithoutPassword(this List<User> users)
        {
            return users.Select(user => user.GetUserWithoutPassword()).ToList();
        }
    }
}
