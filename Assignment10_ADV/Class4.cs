using System;
using System.Collections;
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




    public class SublistWithSum
    {
        public static ArrayList FindSublistWithSum(ArrayList list, int target)
        {
            int start = 0;
            int currentSum = 0;
            ArrayList result = new ArrayList();

            for (int end = 0; end < list.Count; end++)
            {
                currentSum += (int)list[end];


                while (currentSum > target && start < end)
                {
                    currentSum -= (int)list[start];
                    start++;
                }

                if (currentSum == target)
                {
                    result.Clear();
                    for (int i = start; i <= end; i++)
                    {
                        result.Add(list[i]);
                    }
                    return result;
                }
            }

            return null;
        }
    }





     public class ReverseK
    {
         public static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        {
            if (queue == null || k > queue.Count || k < 0)
                throw new ArgumentException("Invalid value of k");

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int size = queue.Count;
            for (int i = 0; i < size - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
        }
    }
}
