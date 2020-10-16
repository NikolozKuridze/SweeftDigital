using System;
using System.Collections.Generic;
using System.Linq;
using SweeftDigitalTasks;

namespace TasksTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            #region Check Task 1 IsPalindrome
            Console.WriteLine(tasks.isPalindrome("Anna"));
            #endregion

            #region Check Task 2 MinSplit
            Console.WriteLine("Coins Count is "+tasks.minsplit(165));
            #endregion

            #region Check Task 3 NotContains
            Console.WriteLine(tasks.notContains(new int[] { 3, 4, 5, 6, 7, 8 }).ToString());
            #endregion

            #region Check Task 4 IsProperly
            Console.WriteLine(tasks.isProperly("(((nika)))"));
            #endregion

            #region Check Task 5 CountVariants 
            Console.WriteLine(tasks.countVariants(5));
            #endregion

            Console.ReadKey();
        }
    }
}
