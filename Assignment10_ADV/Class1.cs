
using System.Collections.Generic;


namespace Assignment10_ADV
{
    public class Reverse
    {
         public static void ReverseQueue(Queue<int> q)
        {
            Stack<int> stack = new Stack<int>();

            
            while (q.Count > 0)
            {
                stack.Push(q.Dequeue());
            }

     
            while (stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }
        }
    }
}
