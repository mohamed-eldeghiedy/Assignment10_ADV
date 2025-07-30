using System;
using System.Collections.Generic;


namespace Assignment10_ADV
{
    public class Search
    {

        public static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            foreach (int item in stack)
            {
                count++;
                if (item == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }
    }
}
