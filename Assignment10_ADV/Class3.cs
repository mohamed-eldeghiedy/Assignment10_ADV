
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
}
