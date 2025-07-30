using System.Collections;

namespace Assignment10_ADV
{
    internal class Program
    {
        static void Main()
        {
            #region q1: Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //string[] firstLine = Console.ReadLine()!.Split();
            //    int N = int.Parse(firstLine[0]);
            //    int Q = int.Parse(firstLine[1]);

            //    int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);


            //    for (int i = 0; i < Q; i++)
            //    {
            //        int X = int.Parse(Console.ReadLine()!);
            //        int count = 0;


            //        foreach (int num in arr)
            //        {
            //            if (num > X)
            //                count++;
            //        }

            //        Console.WriteLine(count);
            //    }
            #endregion


            #region q2: Given a number N and an array of N numbers. Determine if it's palindrome or not.


            //int N = int.Parse(Console.ReadLine()!);


            //int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            //bool isPalindrome = true;

            //for (int i = 0; i < N / 2; i++)
            //{
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}


            //if (isPalindrome)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            #endregion


            #region q3: Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();


            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //queue.Enqueue(4);
            //queue.Enqueue(3);
            //queue.Enqueue(2);

            //Console.WriteLine("Original Queue: " + string.Join(" ", queue));

            //Reverse.ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue: " + string.Join(" ", queue));

            #endregion



            #region q4 : Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.


            //string input = "[()]{ }";
            //Console.WriteLine(Balanced.IsBalanced(input));


            #endregion


            #region q5: Given an array, implement a function to remove duplicate elements from an array.

            //int[] input = { 1, 5, 4, 2, 4, 3, 5 };
            //int[] result = Duplicates.RemoveDuplicates(input);

            //Console.WriteLine("Array after removing duplicates:");
            //Console.WriteLine(string.Join(", ", result));


            #endregion


            #region q6: Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            //OddNumbers.RemoveOddNumbers(numbers);

            //Console.WriteLine(" after : ");
            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion


            #region q7: Implement a queue that can hold different data types.  And insert the following data:


            //Queue queue = new Queue();

            
            //queue.Enqueue(1);           
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);       

            //Console.WriteLine("Queue contents:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
    
}


