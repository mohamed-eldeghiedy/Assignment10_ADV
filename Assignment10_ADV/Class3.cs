
using System.Collections;
using System.Collections.Generic;


namespace Assignment10_ADV
{
    public class Duplicates
    {
        public static int[] RemoveDuplicates(int[] array)
        {
            HashSet<int> unique = new HashSet<int>(array);
            return unique.ToArray();
        }
    }



     public class OddNumbers
    {
        public static void RemoveOddNumbers(ArrayList list)
        {
           
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] is int number && number % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}


