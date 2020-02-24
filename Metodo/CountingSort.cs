using System;

namespace Metodo
{
    public class CountingSort
    {
        public static int[] Sort (int[] array)
        {
            int[] array2 = new int[array.Length];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[i] > array[y])
                    {
                        c++;
                    }
                }
                array2[c] = array[i];
                c = 0;
            }
            return array2;
        }
    }
}
