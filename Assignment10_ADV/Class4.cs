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



    public class Intersection
    {
        public static List<int> FindIntersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            List<int> result = new List<int>();


            foreach (int num in nums1)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            foreach (int num in nums2)
            {
                if (countMap.ContainsKey(num) && countMap[num] > 0)
                {
                    result.Add(num);
                    countMap[num]--;
                }
            }

            return result;
        }
    }
}
