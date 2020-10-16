using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace SweeftDigitalTasks
{
    public class Tasks
    {
       public bool isPalindrome(string text)
       {
            string reverseText = new string (text.Reverse().ToArray());
            if (text.ToLower() == reverseText.ToLower())
            {
                return true;
            }
            return false;
       }

       public int minsplit(int money)
        {
            int x = 0;
            int[] arr = { 50, 20, 10, 5, 1 };
            int[] count = { 0, 0, 0, 0, 0 };
            while (money > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (money % arr[i] == 0)
                    {
                        x++;
                        money -= arr[i];
                        count[i]++;
                        break;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " tetriani: " + count[i]);
            }
            return x;
        }

        public int notContains(int [] array)
        {
            if (array.Min() > 0)
            {
            return array.Min() - 1;
            }
            return -1;
        }

        public bool isProperly(string sequence)
        {
            bool success = true;
            HashSet<char> openBrackets = new HashSet<char>() { '(', '{', '[' };
            HashSet<char> closeBrackets = new HashSet<char>() { ')', '}', ']' };
            Stack<char> mystack = new Stack<char>();
            for (int i = 0; i < sequence.Length; i++)
            {
                if (openBrackets.Contains(sequence[i]))
                    mystack.Push(sequence[i]);
                else if (closeBrackets.Contains(sequence[i]))
                {
                    if (mystack.Count == 0)
                    {
                        success = false;
                        break;
                    }
                    else if (sequence[i] == ')' && mystack.Peek() == '(')
                        mystack.Pop();
                    else
                    {
                        success = false;
                        break;
                    }
                }
            }
            if (mystack.Count == 0 && success)
                 return true;
            else return false;
        }

        public int countVariants(int stearsCount)
        {
            if (stearsCount <0)
            {
                throw new Exception("Please Enter Number > 0 ");
            }
            if (stearsCount <= 1)
            {
                return 1;    
            }
            return countVariants(stearsCount - 2) + countVariants(stearsCount - 1);
        }

    }
}
